using ClassAndInheritance.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Program
    {
        public static List<Appliance> fillList()
        {
            List<Appliance> listapplician = new List<Appliance>();
            string[] lines = Resources.appliances.Split('\n');
            foreach (string line in lines)
            {
                //line by line in file
                try
                {
                    //Console.WriteLine(line);
                    string[] items = line.Split(';');
                    if(items.Length > 1)
                    {
                        if (int.Parse(items[0].Substring(0, 1)) == 1)
                        {
                            Refrigerator rf = new Refrigerator(int.Parse(items[0]), items[1], int.Parse(items[2]),
                                int.Parse(items[3]), items[4], double.Parse(items[5]), int.Parse(items[6]), int.Parse(items[7]), int.Parse(items[8]));
                            listapplician.Add(rf);
                        }
                        else if (int.Parse(items[0].Substring(0, 1)) == 2)
                        {
                            Vacuum vc = new Vacuum(int.Parse(items[0]), items[1], int.Parse(items[2]),
                                        int.Parse(items[3]), items[4], double.Parse(items[5]), items[6],int.Parse(items[7]));
                            listapplician.Add(vc);
                        }
                        else if (int.Parse(items[0].Substring(0, 1)) == 3)
                        {
                            Microwaves mc = new Microwaves(int.Parse(items[0]), items[1], int.Parse(items[2]),
                                        int.Parse(items[3]), items[4], double.Parse(items[5]), double.Parse(items[6]), items[7]);
                            listapplician.Add(mc);
                        }
                        else 
                        {
                            //Dishwasher
                            Dishwasher dishwasher = new Dishwasher(int.Parse(items[0]), items[1], int.Parse(items[2]),
                                        int.Parse(items[3]), items[4], double.Parse(items[5]), items[6], items[7]);
                            listapplician.Add(dishwasher);
                        }
                    }                    
                }
                catch(Exception e)
                {
                    Console.Write($"{e.Message} {e.StackTrace}");
                }
                
            }
            return listapplician;

        }
        //public static string formatForFile(Appliance app)
        //{
        //    string rs = "";
        //    int id = int.Parse(app.Itemnumber.ToString().Substring(0,1));
        //    if (id == 1)
        //    {
        //        Refrigerator rf = (Refrigerator)app;
        //        rs = $"{rf.Itemnumber};{rf.Brand};{rf.Quantity};{rf.Wattage};{rf.Color};{rf.Price};{rf.Doors};{rf.Height};{rf.Width};\n";
        //    }
        //    else if (id == 2)
        //    {
        //        Vacuum vc = (Vacuum)app;
        //        rs = $"{vc.Itemnumber};{vc.Brand};{vc.Quantity};{vc.Wattage};{vc.Color};{vc.Price};{vc.Grade};{vc.BatteryVoltage};\n";
        //    }
        //    else if (id == 3)
        //    {
        //        Microwaves mw = (Microwaves)app;
        //        rs = $"{mw.Itemnumber};{mw.Brand};{mw.Quantity};{mw.Wattage};{mw.Color};{mw.Price};{mw.Capacity};{mw.Roomtype};\n";
        //    }
        //    else
        //    {
        //        //Dishwasher
        //        Dishwasher dw = (Dishwasher)app;
        //        rs = $"{dw.Itemnumber};{dw.Brand};{dw.Quantity};{dw.Wattage};{dw.Color};{dw.Price};{dw.Feature};{dw.SoundRating};\n";
                
        //    }
        //    return rs;
            
        //}
       
        static void Main(string[] args)
        {
            List<Appliance> listapp = fillList();

            
            

            Console.WriteLine("Welcome to Modern Appliances");
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("\nHow may we assist you?");
                Console.WriteLine("1 – Check out appliance");
                Console.WriteLine("2 – Find appliances by brand");
                Console.WriteLine("3 – Display appliances by type");
                Console.WriteLine("4 – Produce random appliance list");
                Console.WriteLine("5 – Save & exit");
                Console.Write("Enter option:\n");
                int opt = Int32.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        //Check out appliance
                        Console.Write("Enter item number of an Appliance:");
                        int applicianid = Int32.Parse(Console.ReadLine());
                        bool notexist = true;
                        foreach (Appliance app in listapp)
                        {
                            if (app.Itemnumber == applicianid)
                            {
                                app.Checkout(applicianid);
                                notexist = false;
                            }
                        }
                        if (notexist == true)
                        {
                            Console.WriteLine("The appliance is not exist!!!!.");
                        }
                        break;
                    case 2:
                        //Find appliances by brand
                        Console.WriteLine("Enter brand to search:");
                        string brand = Console.ReadLine();                                    

                        foreach (Appliance app in listapp)
                        {                           
                            if (brand.ToLower() == app.Brand.ToLower())
                            {
                                Console.WriteLine($"\n{app.ToString()}");
                            }
                        }
                        break;
                    case 3:
                        //Display appliances by type
                        Console.WriteLine("\nAppliance Types");
                        Console.WriteLine("1 - Refrigerators");
                        Console.WriteLine("2 - Vacuums");
                        Console.WriteLine("3 - Microwaves");
                        Console.WriteLine("4 - Dishwasers");
                        int appType = Int32.Parse(Console.ReadLine());                  

                        switch (appType)
                        {
                            case 1:
                                
                                Console.WriteLine("\nEnter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
                                string doors = Console.ReadLine();
                               
                                foreach (Appliance app in listapp)
                                {
                                    
                                    if (appType.ToString() == $"{app.Itemnumber.ToString()[0]}")
                                    {
                                        string[] refri = app.formatForFile().Split(';');
                                        if (refri[6] == $"{doors}")
                                        {
                                            Console.WriteLine($"\n{app.ToString()}");
                                        }                                            
                                    }
                                }
                                 break;

                            case 2:
                                Console.WriteLine("\nEnter battery voltage value. 18 V(low) or 24 V(high)");
                                string voltage = Console.ReadLine();

                                foreach (Appliance app in listapp)
                                {
                                    if (appType.ToString() == $"{app.Itemnumber.ToString()[0]}")
                                    {
                                        string[] vacuum = app.formatForFile().Split(';');
                                        if (vacuum[7] == $"{voltage}")
                                        {
                                            Console.WriteLine($"\n{app.ToString()}");
                                        }
                                    }
                                }
                                break;

                            case 3:
                                Console.WriteLine("\nRoom where the microwave will be installed: K (kitchen) or W (work site):");
                                string room = Console.ReadLine();
                                foreach (Appliance app in listapp)
                                {
                                    if (appType.ToString() == $"{app.Itemnumber.ToString()[0]}")
                                    {
                                        string[] microwave = app.formatForFile().Split(';');
                                        if (microwave[7].ToLower() == $"{room.ToLower()}")
                                        {
                                            Console.WriteLine($"\n{app.ToString()}");
                                        }
                                    }
                                }
                                break;
                            case 4:
                                Console.WriteLine("\nEnter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
                                string volume = Console.ReadLine();
                                foreach (Appliance app in listapp)
                                {
                                    if ("4" == $"{app.Itemnumber.ToString()[0]}" || "5" == $"{app.Itemnumber.ToString()[0]}")
                                    {
                                        string[] dishwasher = app.formatForFile().Split(';');                                        
                                        if (dishwasher[7].ToLower() == $"{volume.ToLower()}")
                                        {
                                            Console.WriteLine($"\n{app.ToString()}");
                                        }
                                    }
                                }
                                break;
                            
                        }                 
                    break;
                    case 4:
                        //Produce random appliance list
                        break;
                    case 5:
                        //EXIT
                        flag = false;
                        using (StreamWriter sw = new StreamWriter(Path.GetFullPath("..\\..\\Resources\\appliances.txt")))
                        {
                            foreach(Appliance appl in listapp)
                            {                               
                                sw.Write(appl.formatForFile()+ "\n");
                            }
                        } 
                        break;
                }
            }
      
        }
    }
}

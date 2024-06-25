using ClassAndInheritance.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Program
    {
        // adsdsa
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
        
        static void Main(string[] args)
        {
            List<Appliance> listapp = fillList();
            Console.WriteLine("Welcome to Modern Appliances");
            bool flag = true;
            while (flag==true)
            {
                Console.WriteLine("How may we assist you?");
                Console.WriteLine("1 – Check out appliance");
                Console.WriteLine("2 – Find appliances by brand");
                Console.WriteLine("3 – Display appliances by typ");
                Console.WriteLine("4 – Produce random appliance list");
                Console.WriteLine("5 – Save & exit");
                Console.Write("Enter option:");
                int opt =Int32.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        //Check out appliance
                        Console.Write("Enter item number of an Appliance:");
                        int applicianid = Int32.Parse(Console.ReadLine());
                        foreach (Appliance app in listapp)
                        {
                            if (app.Itemnumber == applicianid)
                            {
                                if (app.IsAvailable > 0)
                                {
                                    Console.WriteLine($"The appliance {app.Brand} available to be checked out.");
                                    app.IsAvailable -= 1; 
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("The appliance is not available to be checked out.");
                                break;
                            }

                        }
                        break;
                    case 2:
                        //Find appliances by brand
                        break;
                    case 3:
                        //Display appliances by type
                        break;
                    case 4:
                        //Produce random appliance list
                        break;
                    case 5:
                        //EXIT
                        flag = false;
                        break;
                }
            }
            //List<Appliance> listapp = fillList();
            //foreach(Appliance app in listapp)
            //{
            //    Console.WriteLine(app.Color);
            //}
      
        }
    }
}

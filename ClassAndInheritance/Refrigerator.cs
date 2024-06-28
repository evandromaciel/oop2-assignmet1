using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Refrigerator:Appliance
    {
        
        private int _doors;
        private int _height;
        private int _width;
        public Refrigerator(int _itemNumber,string _brand,int _quantity,int _wattage,string _color, double _price,int door,int height,int width):base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            _doors = door;
            _height = height;
            _width = width;
        }
        public int Doors
        {
            get { return _doors; }
            set { _doors = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public enum NumsDoor
        {
            Double,
            Three,
            Four

        }
        public override string formatForFile()
        {
            string rs = "";
            rs = $"{Itemnumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Doors};{Height};{Width};";
            return rs;
        }
        public override string ToString()
        {
            return $"Item:{Itemnumber} \nBrand:{Brand} \nQuantity: {Quantity} \nWattage:{Wattage} \nColor:{Color} \nPrice:{Price} \nDoor:{Doors} \nHeight:{Height} \nWidth:{Width}";
        }
    }
}

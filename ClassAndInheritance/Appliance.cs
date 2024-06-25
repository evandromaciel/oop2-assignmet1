using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal abstract class Appliance
    {
        private int _itemNumber;
        private string _brand;
        private int _quantity;
        private int _wattage;
        private string _color;
        private double _price;
        protected Appliance(int itemNumber, string brand, int quantity, int wattage, string color, double price)
        {
            _itemNumber = itemNumber;
            _brand = brand;
            _quantity = quantity;
            _wattage = wattage;
            _color = color;
            _price = price;
        }
        public int Itemnumber 
        {
            get { return _itemNumber; }
            set { _itemNumber = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int Wattage
        {
            get { return _wattage; }
            set { _wattage = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int IsAvailable
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public override string ToString()
        {
            return $"Item number:{_itemNumber} \nBrand:{_brand}\nQuantity: {_quantity}\nWattage: {_wattage}\nColor: {_color}\nPrice: {_price}";
        }
        //I'm doing a GitHUb test

    }
}

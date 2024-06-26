﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Microwaves:Appliance
    {
        private double _capacity;
        private string _roomType;
        public Microwaves(int _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, double capacity, string roomtype) : base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            _capacity = capacity;
            _roomType = roomtype;
        }
        public double Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public string Roomtype
        {
            get { return _roomType; }
            set { _roomType = value; }
        }
        public override string formatForFile()
        {
            string rs = "";
            rs = $"{Itemnumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Capacity};{Roomtype};";
            return rs;
        }
        public override string ToString()
        {
            return $"Item:{Itemnumber} \n Brand:{Brand} \n Quantity: {Quantity} \n Wattage:{Wattage} \n Color:{Color} \n Price:{Price} \n Capacity:{Capacity} \n Roomtype:{Roomtype}";
        }
    }
}

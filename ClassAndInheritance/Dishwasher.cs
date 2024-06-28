using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Dishwasher:Appliance
    {
        private string _feature;
        private string _soundRating;
        public Dishwasher(int _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, string feature, string soundrating) : base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            _feature = feature;
            _soundRating = soundrating;
        }
        public string Feature
        {
            get { return _feature; }
            set { _feature = value; }
        }
        public string SoundRating
        {
            get { return _soundRating; }
            set { _soundRating = value; }
        }
        public enum TypeSoundRating
        {
            Quietest,
            Quieter,
            Quiet,
            Moderate
        }
        public override string formatForFile()
        {
            string rs = "";
            rs = $"{Itemnumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Feature};{SoundRating};";
            return rs;
        }
        public override string ToString()
        {
            return $"Item:{Itemnumber} \nBrand:{Brand} \nQuantity: {Quantity} \nWattage:{Wattage} \nColor:{Color} \nPrice:{Price} \nFeature:{Feature} \nSoundRating:{SoundRating}";
        }
    }
}

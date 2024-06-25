using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class Vacuum:Appliance
    {
        private string _grade;
        private int _batteryvoltage;
        public Vacuum(int _itemNumber, string _brand, int _quantity, int _wattage, string _color, double _price, string grade, int batteryvol) : base(_itemNumber, _brand, _quantity, _wattage, _color, _price)
        {
            _grade = grade;
            _batteryvoltage = batteryvol;
        }
        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public int BatteryVoltage
        {
            get { return _batteryvoltage; }
            set { _batteryvoltage = value; }
        }
    }
}

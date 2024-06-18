using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances.ProblemDomain
{
    internal abstract class Appliance
    {
        private long _itemNumber;
        private string _brand;
        private int _quantity;
        private string _color;
        private double _price;
        private int _wattage;

        public long ItemNumber { get { return _itemNumber; } set { _itemNumber = value; } }
        public string Brand { get { return _brand; } set { _brand = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public int Wattage { get { return _wattage; } set { _wattage = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public double Price { get { return _price; } set { _price = value; } }

        public Appliance(long itemNum, string brand, int quantity, int wattage, string color, double price)
        {
            _itemNumber = itemNum;
            _brand = brand;
            _quantity = quantity;
            _color = color;
            _price = price;
            _wattage = wattage;
        }

        //public abstract string FormatForFile();

    }
}

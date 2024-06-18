using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances.ProblemDomain
{
    internal class Refrigerator : Appliance
    {
        private int _doors;
        private int _height;
        private int _width;

        public int Doors { get { return _doors; } set { _doors = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Width { get { return _width; } set { _width = value; } }

        public Refrigerator(long itemNum, string brand, int quantity, string color, double price, int wattage, int doors, int height, int width) : base(itemNum, brand, quantity, wattage, color, price)
        {
            this._doors = doors;
            this._height = height;
            this._width = width;
        }
    }
}

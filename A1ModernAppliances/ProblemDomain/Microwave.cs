using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances.ProblemDomain
{
    internal class Microwave : Appliance
    {
        double _capacity;
        string _roomType;

        public double Capacity { get { return _capacity; } set { _capacity = value; } }
        public string RoomType { get { return _roomType; } set { _roomType = value; } }

        public Microwave(long itemNum, string brand, int quantity, string color, double price, int wattage, double capacity, string roomType) : base(itemNum, brand, quantity, wattage, color, price)
        {

            this._capacity = capacity;
            this._roomType = roomType;
        }

    }
}

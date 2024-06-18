using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances.ProblemDomain
{
    internal class Vacuum : Appliance
    {
        private int _batteryVoltage;
        private string _grade;

        public int BatteryVoltage { get { return _batteryVoltage; } set { _batteryVoltage = value; } }
        public string Grade { get { return _grade; } set { _grade = value; } }

        public Vacuum(long itemNum, string brand, int quantity, string color, double price, int wattage, int batteryVoltage, string grade) : base(itemNum, brand, quantity, wattage, color, price)
        {
            this._batteryVoltage = batteryVoltage;
            this._grade = grade;
        }

    }
}

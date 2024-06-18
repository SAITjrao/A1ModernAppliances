using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances.ProblemDomain
{
    internal class Dishwasher : Appliance
    {
        string _feature;
        string _soundRating;

        public string Feature { get { return _feature; } set { _feature = value; } }
        public string SoundRating { get { return _soundRating; } set { _soundRating = value; } }

        public Dishwasher(long itemNum, string brand, int quantity, string color, double price, int wattage, string feature, string soundRating) : base(itemNum, brand, quantity, wattage, color, price)
        {
            this._feature = feature;
            this._soundRating = soundRating;
        }
    }
}

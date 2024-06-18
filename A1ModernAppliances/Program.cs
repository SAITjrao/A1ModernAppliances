using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;

namespace ModernAppliances
{
    public abstract class Appliance
    {
        public long _itemNumber;
        public string _brand;
        public int _quantity;
        public string _color;
        public double _price;
        public int _wattage;

        public long ItemNumber { get { return _itemNumber; } set { _itemNumber = value; } }
        public string Brand { get { return _brand; } set { _brand = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public int Wattage { get { return _wattage; } set { _wattage = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public double Price { get { return _price; } set { _price = value; } }

        public Appliance(long itemNum, string brand, int quantity, int wattage, string color, double price) {
            _itemNumber = itemNum;
            _brand = brand;
            _quantity = quantity;
            _color = color;
            _price = price;
            _wattage = wattage;
        }

        public void Checkout() { }

        public void DetermineApplication() { }

        public abstract string FormatForFile();

    }

    public class Refrigerator : Appliance
    {
        private int _doors;
        private int _height;
        private int _width;

        public int Doors { get { return _doors; } set { _doors = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Width { get { return _width; } set { _width = value; } }

        public Refrigerator(long itemNum, string brand, int quantity, string color, double price, int wattage, int doors, int height, int width):base(itemNum, brand, quantity, wattage, color, price) {
            this._doors = doors;
            this._height = height;
            this._width = width;
        }
    }

    public class Microwave : Appliance
    {
        int _capacity;
        string _roomType;

        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        public string RoomType { get { return _roomType; } set { _roomType = value; } }

        public Microwave(long itemNum, string brand, int quantity, string color, double price, int wattage, int capacity, string roomType):base(itemNum, brand, quantity, wattage, color, price)
        {
        
            this._capacity = capacity;
            this._roomType = roomType;
        }

    }

    public class Dishwasher : Appliance
    {
        string _feature;
        string _soundRating;

        public string Feature { get { return _feature; } set { _feature = value; } }
        public string SoundRating { get { return _soundRating; } set { _soundRating = value; } }
        
        public Dishwasher(long itemNum, string brand, int quantity, string color, double price, int wattage, string feature, string soundRating):base(itemNum, brand, quantity, wattage, color, price) {
            _itemNumber = itemNum;
            _brand = brand;
            _quantity = quantity;
            _color = color;
            _price = price;
            _wattage = wattage;
            _feature = feature;
            _soundRating = soundRating;
        }
    }

    public class Vacuum : Appliance 
    {
        int _batteryVoltage;
        int _grade;

        public int BatteryVoltage { get { return _batteryVoltage; } set {  _batteryVoltage = value; } }
        public int Grade { get { return _grade; } set { _grade = value; } }

        public Vacuum(long itemNum, string brand, int quantity, string color, double price, int wattage, int batteryVoltage, int grade) : base(itemNum, brand, quantity, wattage, color, price)
        {
            _itemNumber = itemNum;
            _brand = brand;
            _quantity = quantity;
            _color = color;
            _price = price;
            _wattage = wattage;
            _batteryVoltage = batteryVoltage;
            _grade = grade;
        }

    }

    internal class Program
    {
        
        /// <summary>
        /// Entry point to program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            ModernAppliances modernAppliances = new MyModernAppliances();
            ModernAppliances.Options option = ModernAppliances.Options.None;
            
            while (option != ModernAppliances.Options.SaveExit)
            {
                modernAppliances.DisplayMenu();

                option = Enum.Parse<ModernAppliances.Options>(Console.ReadLine());
                
                switch (option)
                {
                    case ModernAppliances.Options.Checkout:
                    {
                        modernAppliances.Checkout();

                        break;
                    }
                    case ModernAppliances.Options.Find:
                    {
                        modernAppliances.Find();

                        break;
                    }
                    case ModernAppliances.Options.DisplayType:
                    {
                        modernAppliances.DisplayType();

                        break;
                    }
                        
                    case ModernAppliances.Options.RandomList:
                    {
                        modernAppliances.RandomList();
                        break;
                    }
                    case ModernAppliances.Options.SaveExit:
                    {
                        modernAppliances.Save();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid option entered. Please try again.");
                        break;
                    }
                }
            }

            
        }
    }
}
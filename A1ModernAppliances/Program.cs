namespace ModernAppliances
{
    public abstract class Appliance
    {
        long _itemNumber;
        string _brand;
        int _quantity;
        string _color;
        double _price;
        int _wattage;

        public long ItemNumber { get { return _itemNumber; } set { _itemNumber = value; } }
        public string Brand { get { return _brand; } set { _brand = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public int Wattage { get { return _wattage; } set { _wattage = value; } }

    }

    public class Refrigerator : Appliance
    {
        int _doors;
        int _height;
        int _width;

        public int Doors { get { return _doors; } set { _doors = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Width { get { return _width; } set { _width = value; } }

        static void FormatForFile() { }

        static Refrigerator() { }

        public static void ToString()
        {

        }
    }

    public class Microwave : Appliance
    {
        int _capacity;
        string _roomType;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public string RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        public void RoomTypeDisplay()
        {

        }

    public class Dishwasher : Appliance
    {

    }

    public class Vacuum : Appliance 
    {
        
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
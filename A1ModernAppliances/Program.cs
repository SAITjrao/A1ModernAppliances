using ModernAppliances.Entities.Abstract;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;

namespace ModernAppliances
{
    
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

            /*List<ProblemDomain.Appliance> appliances = MyModernAppliances.ParseFile();
            foreach (ProblemDomain.Appliance appliance in appliances)
            {
                Console.WriteLine(appliance.ItemNumber);
            }*/

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
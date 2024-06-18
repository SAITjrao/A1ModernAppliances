using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using ModernAppliances.ProblemDomain;
using Appliance = ModernAppliances.Entities.Abstract.Appliance;
using Refrigerator = ModernAppliances.Entities.Refrigerator;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Jazib Rao</remarks>
    /// <remarks>Date: 06/18/2024</remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Create long variable to hold item number
            long itemNum;
            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            string input = Console.ReadLine();
            itemNum = Convert.ToInt64(input);

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance;
            foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            // Break out of loop (since we found what need to)
            foreach (Entities.Abstract.Appliance appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNum)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if(foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
            if (foundAppliance.IsAvailable)
            {
                foundAppliance.Checkout();
                Console.WriteLine("Appliance has been checked out.");
                Console.WriteLine(foundAppliance.ToString());
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
            
        }
        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brand;
            brand = Console.ReadLine();
            // Create list to hold found Appliance objects
            var foundAppliances = new List<Entities.Abstract.Appliance> { };
            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (Entities.Abstract.Appliance appliance in Appliances)
            {
                if (appliance.Brand == brand)
                {
                    foundAppliances.Add(appliance);
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances,0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            Console.WriteLine("Possible options: \n0 - Any\n2 - Double doors\n3 - Three doors\n4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            int doors;
            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            doors = Convert.ToInt32(input);
            // Create list to hold found Appliance objects
            var foundAppliances = new List<Entities.Abstract.Appliance> { };
            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;
            foreach (Entities.Abstract.Appliance appliance in Appliances)
            {
                if (appliance is Entities.Refrigerator)
                {
                    Entities.Refrigerator refrigerator = (Refrigerator) appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    // Add current appliance in list to found list
                    if (doors == 0)
                    {
                        foundAppliances.Add(refrigerator);
                    }
                    else if (doors == 2)
                    {
                        if(refrigerator.Doors == 2)
                        {
                            foundAppliances.Add(refrigerator);
                        }
                    }
                    else if (doors == 3)
                    {
                        if(refrigerator.Doors == 3)
                        {
                            foundAppliances.Add(refrigerator);
                        }
                    }
                    else
                    {
                        if(refrigerator.Doors == 4)
                        {
                            foundAppliances.Add(refrigerator);
                        }
                    }
                }
               
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            Console.WriteLine("Possible options: \n0 - Any\n1 - Residential\n2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string gradeToFind;

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            switch (input)
            {
                case "0":
                    gradeToFind = "Any";
                    break;
                case "1":
                    gradeToFind = "Residential";
                    break;
                case "2":
                    gradeToFind = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("Possible options: \n0 - Any\n1 - 18 Volt\n2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage");

            // Get user input as string
            // Create variable to hold voltage
            input = Console.ReadLine();
            int voltage;

            switch (input)
            {
                case "0":
                    voltage = 0;
                    break;
                case "1":
                    voltage = 18;
                    break;
                case "2":
                    voltage = 24;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            // Create found variable to hold list of found appliances.
            var found = new List<Entities.Abstract.Appliance> { };

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list
            foreach (Entities.Abstract.Appliance appliance in Appliances)
            {
                if (appliance is Entities.Vacuum)
                {
                    Entities.Vacuum vacuum = (Entities.Vacuum)appliance;

                    if (gradeToFind == "Any" || gradeToFind == vacuum.Grade)
                    {
                        if (voltage == vacuum.BatteryVoltage || voltage == 0)
                        {
                            found.Add(vacuum);
                        }
                    }
                }

            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("Possible options: \n0 - Any\n1 - Kitchen\n2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string input = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;
            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;

            switch (input)
            {
                case "0":
                    roomType = 'A';
                    break;
                case "1":
                    roomType = 'K';
                    break;
                case "2":
                    roomType = 'W';
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of 'found' appliances
            var found = new List<Entities.Abstract.Appliance>{ };

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave
            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            foreach (Entities.Abstract.Appliance appliance in Appliances)
            {
                if (appliance is Entities.Microwave)
                {
                    Entities.Microwave microwave = (Entities.Microwave)appliance;

                    if (microwave.RoomType == roomType)
                    {
                        found.Add(microwave);
                    }
                }

            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("Possible options: \n0 - Any\n1 - Quietest\n2 - Quieter\n3 - Quiet\n4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");

            // Get user input as string and assign to variable
            string input = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating;

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            switch (input)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of found appliances
            var found = new List<Entities.Abstract.Appliance> { };

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher
            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list
            foreach (Entities.Abstract.Appliance appliance in Appliances)
            {
                if (appliance is Entities.Dishwasher)
                {
                    Entities.Dishwasher dishwasher = (Entities.Dishwasher)appliance;

                    if (dishwasher.SoundRating == soundRating || soundRating == "Any")
                    {
                        found.Add(dishwasher);
                    }
                }

            }



            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }

        //reads file, creates appliance objects based on their itemNum, adds appliances to list and returns it
        public static List<ProblemDomain.Appliance> ParseFile()
        {
            string filePath = ModernAppliances.APPLIANCES_TEXT_FILE;
            List<ProblemDomain.Appliance> appliances = new List<ProblemDomain.Appliance>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(";");

                long itemNum = Convert.ToInt64(parts[0]);
                string brand = parts[1];
                int quantity = Convert.ToInt32(parts[2]);
                int wattage = Convert.ToInt32(parts[3]);
                string color = parts[4];
                double price = Convert.ToDouble(parts[5]);


                int firstDigit = Convert.ToInt32(parts[0].Substring(0,1));
                if (firstDigit == 1)
                {
                    int doors = Convert.ToInt32(parts[6]);
                    int height = Convert.ToInt32(parts[7]);
                    int width = Convert.ToInt32(parts[8]);
                    ProblemDomain.Appliance appliance = new ProblemDomain.Refrigerator(itemNum, brand, quantity, color, price, wattage, doors, height, width);
                    appliances.Add(appliance);
                }
                else if (firstDigit == 2)
                {
                    string grade = (parts[6]);
                    int batteryVoltage = Convert.ToInt32(parts[7]);
                    ProblemDomain.Appliance appliance = new ProblemDomain.Vacuum(itemNum, brand, quantity, color, price, wattage, batteryVoltage, grade);
                    appliances.Add(appliance);
                }
                else if (firstDigit == 3)
                {
                    double capacity = Convert.ToDouble(parts[6]);
                    string roomType = (parts[7]);
                    ProblemDomain.Appliance appliance = new ProblemDomain.Microwave(itemNum, brand, quantity, color, price, wattage, capacity, roomType);
                    appliances.Add(appliance);
                }
                else if (firstDigit == 4 || firstDigit == 5)
                {
                    string feature = (parts[6]);
                    string soundRating = (parts[7]);
                    ProblemDomain.Appliance appliance = new ProblemDomain.Dishwasher(itemNum, brand, quantity, color, price, wattage, feature, soundRating);
                    appliances.Add(appliance);
                }

            }
            return appliances;
        }

        public static void PurchaseAppliance()
        {

        }


    }
}

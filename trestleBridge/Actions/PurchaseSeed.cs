using System;
using trestleBridge.Models.Animals;
using trestleBridge.Models.Plants;

namespace trestleBridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sunflower");
            Console.WriteLine("2. Wildflower");
            Console.WriteLine("3. Sesame");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChoosePlowedField.CollectInput(farm, new Sunflower());
                        break;
                    case 2:
                        ChoosePlowedField.CollectInput(farm, new Wildflower());
                        break;
                    case 3:
                        ChoosePlowedField.CollectInput(farm, new Sesame());
                        break;
                    default:
                        break;
                }
        }
    }  
};
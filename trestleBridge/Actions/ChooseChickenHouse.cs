using System;
using trestleBridge.Interfaces;
using trestleBridge.Models.Facilities;
namespace trestleBridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            // Console.Clear();
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine(value: $"Place {animal.Type} where?");            
                
                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

            if (farm.ChickenHouses[choice - 1].currentCapacity < farm.ChickenHouses[choice - 1].Capacity)
            {
                farm.ChickenHouses[choice - 1].AddResource(animal);
            }
            else
            {
                farm.ChickenHouses[choice - 1].atCapacity();                
            }   
            
            }
            /*
   Couldn't get this to work. Can you?
   Stretch goal. Only if the app is fully functional.
*/
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    };

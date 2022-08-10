using System;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class chooseNaturalField
    {
        public static void CollectInput(Farm farm, IFlower flower)
        {
            // Console.Clear();
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine(value: $"Place {flower.Type} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

          farm.PlowedFields[choice-1].AddResource(flower);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);
        }
    }
}

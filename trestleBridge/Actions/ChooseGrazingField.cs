using System;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            // Console.Clear();
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field {farm.GrazingFields[i]._id}");
            }
            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine(value: $"Place {animal.Type} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.GrazingFields[choice - 1].AddResource( animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal , choice);
        }
    }
}


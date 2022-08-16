using System;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
	public class ChooseDuckHouse
	{
	public static void CollectInput(Farm farm, IGrazing animal)
    {
        // Console.Clear();
        for (int i = 0; i < farm.DuckHouses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Duck House");
        }
        Console.WriteLine();
        // How can I output the type of animal chosen here?
        Console.WriteLine(value: $"Place {animal.Type} where?");

        Console.Write("> ");
        int choice = Int32.Parse(Console.ReadLine());



            if (farm.DuckHouses[choice - 1].currentCapacity < farm.DuckHouses[choice - 1].Capacity)
            {
                farm.DuckHouses[choice - 1].AddResource(animal);
            }
            else
            {
                farm.DuckHouses[choice - 1].atCapacity();
            }

            

        /*
            Couldn't get this to work. Can you?
            Stretch goal. Only if the app is fully functional.
         */
        // farm.PurchaseResource<IGrazing>(animal, choice);
    }
}
}
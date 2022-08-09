using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, IFlower flower)
        {
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field");
            }
            Console.WriteLine();
            Console.WriteLine(value: $"Place {flower.Type} where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class DuckHouse : IFacility<IGrazing>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();


        public double currentCapacity
        {
            get
            {
                return _animals.Count();
            }
        }
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing animal)
        {
           _animals.Add(animal);
            ;
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void atCapacity()
        {
            Console.WriteLine(@" Please select a different Duck House, this one is over capacity");
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Duck house {shortId} has {this._animals.Count} ducks, quack, Quack, QUACCCKKKIINNNGGG!\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
}
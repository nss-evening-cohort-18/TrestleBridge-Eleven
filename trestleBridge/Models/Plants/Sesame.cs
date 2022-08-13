using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Plants
{ 
     //d the things here do not want to be read
    public class Sesame : IResource, IFlower, ISeedProducing
    {
        private Guid _id = Guid.NewGuid();
        private string _location = "Plowed Field";
        private string _product = "Seed";
        private int _amount = 520;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Sesame";
        string IResource.Type { get; }
        object ISeedProducing.Type { get; set; }
        int IFlower.Amount { get; set; }
        string IFlower.Type { get; set; }

        // Methods

        public double Harvest()
        {
            return _amount;
        }

        public void Flower()
        {
            Console.WriteLine($"Sesame {this._shortId} produced {this._amount} of seeds");
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }

    }
}

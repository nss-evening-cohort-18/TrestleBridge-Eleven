using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Plants
{
    
    public class Sunflower : IResource, IFlower, ISeedProducing, ICompost
    {
        private Guid _id = Guid.NewGuid();
        private string _location = "Plowed Field or Natural Field";
        private double _seeds = 650;
        private double _amount = 21.6;
        
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Sunflower";
        string IResource.Type { get; }
        object ISeedProducing.Type { get; set; }
        int IFlower.Amount { get; set; }
        string IFlower.Type { get; set; }
        string ICompost.Type { get; set; }

        // Methods

        public double Harvest()
        {
            return this._seeds;
        }

        public void Flower()
        {
            Console.WriteLine($"Sunflower {this._shortId} produced {this._amount} of seeds");
        }
        
        public double Compost()
        {
            return _amount;
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }
    }
}

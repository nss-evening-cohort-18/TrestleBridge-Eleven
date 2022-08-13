using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Plants
{
    public class Wildflower : IResource, IFlower, ICompost
    {
        private Guid _id = Guid.NewGuid();
        private double _amount = 30.3;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Wildflower";
        object IResource.Type { get; set; }
        int IFlower.Amount { get; set; }
        string IFlower.Type { get; set; }
        string ICompost.Type { get; set; }


        // Methods

        public void Flower()
        {
            Console.WriteLine($"Wildflower {this._shortId} produced {this._amount} of seeds");
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

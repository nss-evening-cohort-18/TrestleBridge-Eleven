using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Ostrich : IResource, IEggProducing, IMeatProducing, IGrazing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 2.6;
        private double _eggsProduced = 3;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 2.3;
        public string Type { get; } = "Ostrich";
        object IResource.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEggProducing.Type { get; set; }
        string IMeatProducing.Type { get; set; }

        string IGrazing.Type { get; set; }

        // Methods

        public void Graze()
        {
            Console.WriteLine($"Ostrich {this._shortId} just ate {this.GrassPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public double EggLayer()
        {
            return _eggsProduced;
        }

        public override string ToString()
        {
            return $"Ostrich {this._shortId}. Squack!";
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }
    }
}

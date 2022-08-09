using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Chicken : IResource, IGrazing, IMeatProducing, IEggProducing, IFeatherProducing 
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;
        private double _eggsProduced = 7;
        private double _feathersProduced = .5;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";
        object IResource.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IGrazing.Type { get; set; }
        string IMeatProducing.Type { get; set ; }
        string IEggProducing.Type { get; set; }
        string IFeatherProducing.Type { get; set; }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.GrassPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public double EggLayer()
        {
            return _eggsProduced;
        }

        public double Feather()
        {
            return _feathersProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cock-a-Doodle-doo!";
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Duck : IResource, IGrazing, IEggProducing, IFeatherProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _eggsProduced = 6;
        private double _feathersProduced = .75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = .8;
        public string Type { get; } = "Duck";
        string IGrazing.Type { get; set; }
        string IFeatherProducing.Type { get; set; }
        string IEggProducing.Type { get; set; }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Ostrich {this._shortId} just ate {this.GrassPerDay}kg of feed");
        }

        public double Feather()
        {
            return _feathersProduced;
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

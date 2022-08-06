using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Duck : IResource, IGrazing
    {
        private Guid _id = Guid.NewGuid();

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = .8;
        public string Type { get; } = "Duck";
        object IResource.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IGrazing.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Ostrich {this._shortId} just ate {this.GrassPerDay}kg of grass");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Goat : IResource, IGrazing, ICompost
    {
        private Guid _id = Guid.NewGuid();
        private double _compostProduced = 7.5;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Goat";
        object IResource.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IGrazing.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ICompost.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Graze()
        {
            Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public string ToString()
        {
            return $"Goat {this._shortId}. Baaaah!";
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }

    }
}
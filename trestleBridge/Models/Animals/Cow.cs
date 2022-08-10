﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Cow : IResource, IMeatProducing , IGrazing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 18.25;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Cow";
        string IGrazing.Type { get; set; }
        string IMeatProducing.Type { get; set; }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }
        public string ToString()
        {
            return $"Cow {this._shortId}. Mooo!";
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }
    }
}

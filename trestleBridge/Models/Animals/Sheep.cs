﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Animals
{
    public class Sheep : IResource, IGrazing, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 5;
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 4;
        public string Type { get; } = "Sheep";
        object IResource.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IGrazing.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IMeatProducing.Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Sheep {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }
        public string ToString()
        {
            return $"Sheep {this._shortId}. Bahhhh!";
        }

        public void Resource()
        {
            throw new NotImplementedException();
        }
    }
}

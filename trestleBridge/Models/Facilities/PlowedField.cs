﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Facilities
{
    public class PlowedField : IFacility<IFlower>
    {
        private int _rows = 13;
        private int _plantsPerRow = 5;
        private Guid _id = Guid.NewGuid();

        private List<IFlower> _flowers = new List<IFlower>();

        public double Rows
        {
            get
            {
                return _rows;
            }
        }

        public double PlantsPerRow
        {
            get
            {
                return _plantsPerRow;
            }
        }

        public void AddResource(IFlower flowers)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<IFlower> flowers)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Plowed field {shortId} has {Rows} rows of plants\n");
            this._flowers.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }
    }
};
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IFlower
    {
        public string Location { get; set; }
        public string Product { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        //void Graze();
    }
}

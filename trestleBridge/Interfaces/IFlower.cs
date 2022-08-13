using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IFlower
    {
        public int Amount { get; set; }
        public string Type { get; set; }
        //void Graze();
        void Flower();
    }
}

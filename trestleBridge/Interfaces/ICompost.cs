using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    internal interface ICompost
    {
        public string Type { get; set; }

        public double Compost();
    }

}

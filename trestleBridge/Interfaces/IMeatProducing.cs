using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IMeatProducing
    {
       
        public string Type { get; set; }

        public double Butcher();
    }
}

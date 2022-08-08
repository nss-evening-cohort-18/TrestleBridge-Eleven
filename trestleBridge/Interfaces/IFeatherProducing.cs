using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface IFeatherProducing
    {

        public string Type { get; set; }

        public double Feather();
    }
}

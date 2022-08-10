using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trestleBridge.Interfaces;

namespace trestleBridge.Models.Plants
{
    public class Wildflower : IResource, ISeedProducing, IFlower, ICompost
    {
        private Guid _id = Guid.NewGuid();
        private double _compost = 30.3;


    }
}

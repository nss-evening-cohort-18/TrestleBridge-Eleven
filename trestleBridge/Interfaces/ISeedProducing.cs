﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trestleBridge.Interfaces
{
    public interface ISeedProducing
    {
        object Type { get; set; }
        double Harvest();
    }
}

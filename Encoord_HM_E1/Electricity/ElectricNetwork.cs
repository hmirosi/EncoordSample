using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Electricity
{
    public class ElectricNetwork : Network<ElectricNode, ElectricNodeConnector>
    {
        public double BasePower { get; set; }
        public double BaseFrequency { get; set; }
    }
}

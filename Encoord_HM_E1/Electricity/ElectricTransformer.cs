using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Electricity
{
    public class ElectricTransformer : ElectricNodeConnector
    {
        public double TapRatio { get; set; }
        public double PhaseShiftAngle { get; set; }
    }
}

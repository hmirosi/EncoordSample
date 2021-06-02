using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Electricity
{
    public class ElectricNodeConnector : NetworkNodeConnector<ElectricNode>
    {
        public double VoltageAtFromNode { get; set; }
        public double VoltageAtToNode { get; set; }
        public double ElevationDifference { get; set; }
        public double Resistance { get; set; }
        public double Reactance { get; set; }
        public double Capacitance { get; set; }
        public double Current { get; set; }
    }
}

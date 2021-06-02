using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Gas
{
    public class GasNodeConnector : NetworkNodeConnector<GasNode>
    {
        public double PressureAtFromNode { get; set; }
        public double PressureAtToNode { get; set; }
        public double Diameter { get; set; }
        public double ElevationDifference { get; set; }
        public double GasFlow { get; set; }
    }
}

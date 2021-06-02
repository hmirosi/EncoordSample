using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Gas
{
    public class GasNetwork : Network<GasNode, GasNodeConnector>
    {
        public double CalorificValue { get; set; }
        public double RelativeDensity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Gas
{
    public class GasNode : NetworkNode
    {
        public double Pressure { get; set; }
        public double GasLoad { get; set; }
    }
}

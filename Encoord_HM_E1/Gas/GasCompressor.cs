using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Gas
{
    public class GasCompressor : GasNodeConnector
    {
        public float AdiabaticEfficiency { get; set; }
        public float MechanicalEfficiency { get; set; }
    }
}

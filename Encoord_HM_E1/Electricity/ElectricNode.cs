using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1.Electricity
{
    public class ElectricNode : NetworkNode
    {
        public double Voltage { get; set; }
        public double PowerLoad { get; set; }
    }
}

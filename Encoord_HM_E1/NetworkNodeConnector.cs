using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1
{
    public abstract class NetworkNodeConnector<TNode> : NetworkElement where TNode : NetworkNode
    {
        public TNode FromNode { get; set; }
        public TNode ToNode { get; set; }
    }
}

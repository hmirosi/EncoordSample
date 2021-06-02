using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1
{
    public abstract class Network<TNode, TBranch> : NetworkElement where TNode : NetworkNode where TBranch : NetworkNodeConnector<TNode>
    {
        public List<TNode> Nodes { get; set; }
        public List<TBranch> Branches { get; set; }

        public virtual void Solve()
        { }
    }
}

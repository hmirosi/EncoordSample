using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encoord_HM_E1
{
    public abstract class NetworkElement
    {
        public string Name { get; set; }
        public string Info { get; set; }

        public virtual void Move(float dX, float dY)
        { }

        public virtual void Draw(System.Drawing.Graphics g)
        { }

        public virtual void Zoom(float level)
        { }
    }
}

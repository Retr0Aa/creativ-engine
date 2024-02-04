using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativEngine.Framework.ComponentSystem
{
    public abstract class Component
    {
        public string displayName;

        protected Component(string displayName)
        {
            this.displayName = displayName;
        }

        public abstract void OnGUIRender(Panel parent);
    }
}

using CreativEngine.Framework.ComponentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativEngine.Framework
{
    public class GameObject
    {
        public string name;
        public List<Component> components;

        public GameObject(string name)
        {
            this.name = name;
        }
    }
}

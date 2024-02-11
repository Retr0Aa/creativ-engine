using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativEngine.Framework
{
    public class Scene
    {
        public string name;
        public List<GameObject> gameObjects;

        public Scene() { name = "Untitled"; }

        public Scene(string name)
        {
            this.name = name;
        }
    }
}

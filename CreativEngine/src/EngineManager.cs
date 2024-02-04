using CreativEngine.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativEngine
{
    public class EngineManager
    {
        public Project openedProject;

        public EngineManager()
        {
            openedProject = new Project() { title = "Untitled Project", scenes = new List<Scene>() };
        }

        public bool LoadEditorProject(string projectPath)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                return false;
            }
        }
    }
}

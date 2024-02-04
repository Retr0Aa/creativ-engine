using CreativEngine.Framework;
using RetroLog;
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
        public Log engineLog;

        public EngineManager()
        {
            engineLog = new Log("CREATIVENGINE");
            engineLog.PrintLogLine("Log Loaded.", MessageType.Success);

            openedProject = new Project() { title = "Untitled Project", scenes = new List<Scene>() };
        }

        public bool LoadEditorProject(string projectPath)
        {
            try
            {
                engineLog.PrintLogLine("Project Loaded.", MessageType.Success);

                return true;
            }
            catch (Exception ex)
            {
                engineLog.PrintLogLine("Error Loading Project!", MessageType.Error);
                return false;
            }
        }
    }
}

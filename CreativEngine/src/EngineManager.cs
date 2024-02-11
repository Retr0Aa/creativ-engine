using CreativEngine.Framework;
using Newtonsoft.Json;
using RetroLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativEngine
{
    public class EngineManager
    {
        public Project openedProject;
        public string currentProjectPath;

        public Log engineLog;

        public EngineManager()
        {
            engineLog = new Log("CREATIVENGINE");
            engineLog.PrintLogLine("Log Loaded.", MessageType.Success);

            openedProject = new Project() { title = "Untitled Project", scenes = new List<Scene>() };

            /*// Just For Testing
            List<GameObject> gameObjects = new List<GameObject>() { new GameObject("My Object") };
            openedProject.scenes.Add(new Scene() { name = "TestScene", gameObjects = gameObjects });*/
        }

        public bool SaveEditorProject()
        {
            try
            {
                var jsonString = JsonConvert.SerializeObject(openedProject);
                File.WriteAllText(currentProjectPath, jsonString);

                engineLog.PrintLogLine("Project Saved.", MessageType.Success);

                return true;
            }
            catch (Exception ex)
            {
                engineLog.PrintLogLine("Error Saving Project!:\n\t" + ex.Message, MessageType.Error);
                return false;
            }
        }

        public bool LoadEditorProject(string projectPath)
        {
            try
            {
                openedProject = JsonConvert.DeserializeObject<Project>(File.ReadAllText(projectPath));
                currentProjectPath = projectPath;

                engineLog.PrintLogLine("Project Loaded.", MessageType.Success);

                return true;
            }
            catch (Exception ex)
            {
                engineLog.PrintLogLine("Error Loading Project!:\n" + ex.Message, MessageType.Error);
                return false;
            }
        }
    }
}

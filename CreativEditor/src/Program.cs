using CreativEditor.Graphics;
using CreativEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativEditor
{
    public class Program
    {
        public static EngineManager engineManager = new EngineManager();
        
        static void Main()
        {
            engineManager.LoadEditorProject("C:/test.crproj");

            Window window = new Window(1080, 720, "Creativengine Editor");

            // Panels
            ObjectOutlinePanel objectOutlinePanel = new ObjectOutlinePanel();
            objectOutlinePanel.LoadPanel(window);

            Application.Run(window.form);
        }
    }
}

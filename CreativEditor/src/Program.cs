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
        
        public static ObjectOutlinePanel objectOutlinePanel;

        static void Main()
        {
            engineManager.LoadEditorProject("C:/test/test.crproj");

            Window window = new Window(1080, 720, "Creativengine Editor");

            // Panels
            objectOutlinePanel = new ObjectOutlinePanel();
            objectOutlinePanel.LoadPanel(window);

            window.SetupToolbar();

            Application.Run(window.form);
        }
    }
}

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
        static void Main()
        {
            EngineManager engineManager = new EngineManager();
            engineManager.SaveEditorProject();
            engineManager.LoadEditorProject("C:/Users/retr0/Documents/test.crproj");

            Application.Run(new Form());
        }
    }
}

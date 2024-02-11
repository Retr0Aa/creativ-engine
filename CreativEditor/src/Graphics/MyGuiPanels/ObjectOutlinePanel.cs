using MyGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CreativEngine;

namespace CreativEditor.Graphics
{
    public class ObjectOutlinePanel
    {
        public MyGuiPanel panel;

        private TreeView objectsView;

        public void LoadPanel(Window parentWindow)
        {
            panel = new MyGuiPanel("Objects List", new Size(200, 200), DockStyle.Left, parentWindow.form);
            panel.Init();
            panel.SetDock(DockStyle.Left);

            objectsView = new TreeView() {
                BackColor = Color.LightGray, BorderStyle = BorderStyle.None, Dock = DockStyle.Top
            };
            RefreshDisplayedItems();

            panel.addControl(objectsView);
        }

        public void RefreshDisplayedItems()
        {
            objectsView.Nodes.Clear();

            foreach (var item in Program.engineManager.openedProject.scenes[0].gameObjects)
            {
                objectsView.Nodes.Add(item.name);
            }
        }
    }
}

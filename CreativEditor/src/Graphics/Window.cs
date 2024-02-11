using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativEditor.Graphics
{
    public class Window
    {
        private int m_Width, m_Height;
        private string m_Title;

        public Form form;

        public Window(int width, int height, string title)
        {
            m_Width = width;
            m_Height = height;
            m_Title = title;

            form = new Form();
            form.Width = m_Width;
            form.Height = m_Height;
            form.Text = m_Title;
        }

        public void SetupToolbar()
        {
            ToolStrip toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Top;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;

            ToolStripDropDownButton fileDropdownMenu = new ToolStripDropDownButton();
            fileDropdownMenu.Text = "File";
            fileDropdownMenu.DropDownItemClicked += FileDropdownMenu_ItemClicked;
            fileDropdownMenu.DropDownItems.Add("Save Project");

            ToolStripDropDownButton editDropdownMenu = new ToolStripDropDownButton();
            editDropdownMenu.Text = "Edit";
            editDropdownMenu.DropDownItemClicked += EditDropdownMenu_ItemClicked;
            editDropdownMenu.DropDownItems.Add("Create New Object");

            toolStrip.Items.Add(fileDropdownMenu);
            toolStrip.Items.Add(editDropdownMenu);

            form.Controls.Add(toolStrip);
        }

        private void FileDropdownMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Save Project")
            {
                Program.engineManager.SaveEditorProject();
            }
        }

        private void EditDropdownMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Create New Object")
            {
                Program.engineManager.openedProject.scenes[0].gameObjects.Add(new CreativEngine.Framework.GameObject("Empty Object"));
                Program.objectOutlinePanel.RefreshDisplayedItems();
            }
        }
    }
}

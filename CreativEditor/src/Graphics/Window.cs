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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplad
{
    public partial class materiais : Form
    {
        public materiais()
        {
            InitializeComponent();
        }

        private void notebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                PictureBox p = new PictureBox();
                p.Width = 100;
                p.Height = 100;
                p.BorderStyle = BorderStyle.Fixed3D;
                p.BackColor = Color.Azure;
                p.Parent = flowLayoutPanel1;
                flowLayoutPanel1.Refresh();
            }
        }
    }
}

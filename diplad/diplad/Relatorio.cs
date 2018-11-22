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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            dataGridView1.DataSource = Bd.relatorio();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            
        }
    }
}

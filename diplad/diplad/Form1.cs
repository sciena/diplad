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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Bd.visualizar();
            dataGridView1.Refresh();
             
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro abrir = new Cadastro();
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 abrir = new Form2(); 
            abrir.ShowDialog();
            dataGridView1.DataSource = Bd.visualizar();
            dataGridView1.Refresh();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Relatorio abrir = new Relatorio();
                abrir.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cadastrarmateriais abrir = new cadastrarmateriais();
            abrir.Show(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int codigoretirada = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);

                new devolver(codigoretirada).ShowDialog();
                dataGridView1.DataSource = Bd.visualizar();
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

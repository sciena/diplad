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
    public partial class cadastrarmateriais : Form
    {
        public cadastrarmateriais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                string nome = textBox2.Text;
                Bd.cadastrarmateriais(codigo, nome);
                MessageBox.Show("Registrado com sucesso");
                this.Close();
            }
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

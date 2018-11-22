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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datahora = dateTimePicker1.Value;
            int codigo = 0;
            string local = textBox3.Text;
            string senha = textBox5.Text;
            int siape = 0;
            string nomematerial = "";
            int.TryParse(textBox2.Text, out codigo);
            if (codigo == 0)
            {
                nomematerial = textBox2.Text;
            }
            int cod = Bd.idmaterial(nomematerial, codigo);
            if (cod == 0)
            {
                MessageBox.Show("Deu bosta esse equipamento n existe");
                return;
            }
            
             string nome = "";
             int.TryParse(textBox4.Text, out siape);
             if (siape == 0)
                {
                    nome = textBox4.Text;
                }
             int siapeokay = Bd.validsiape(siape, nome, senha);
             if (siapeokay > 0)
                {
                    Bd.retirada(datahora,cod, siapeokay, local);
                    MessageBox.Show("Regsitrado com sucesso");
                    this.Close();
                }
             else
                {
                    MessageBox.Show("Deu bosta");
                }




            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        // {
        //   if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //(e.KeyChar != '.'))
        //   {
        //       e.Handled = true;
        //   }

        // only allow one decimal point
        //   if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //   {
        //       e.Handled = true;
        //}
    }   
}

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
            string[] materiais = textBox2.Text.Split(',');
            int valor = 0;
            foreach (string material in materiais)
            {

                

                string nomematerial = "";
                int.TryParse(material, out codigo);
                if (codigo == 0)
                {
                    nomematerial = material;
                }
                int cod = Bd.idmaterial(nomematerial, codigo);
                if (cod == 0)
                {
                    MessageBox.Show("Equipamento inexistente");
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
                    Bd.retirada(datahora, cod, siapeokay, local);
                    valor = valor + 1;
                    this.Close();
              
                }
                else
                {
                    MessageBox.Show("Deu bosta");
                }


            }
            if (valor > 0)
            {
                MessageBox.Show("Registrado com sucesso");
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

        private void button3_Click(object sender, EventArgs e)
        {
            materiais abrir = new materiais();
            abrir.Show();
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

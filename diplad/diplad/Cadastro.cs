﻿using System;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int siape = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string senha = textBox3.Text;
            string csenha = textBox4.Text; 
            if (senha == csenha)
            {
                Bd.cadastrarservidor(siape, nome, senha);
                MessageBox.Show("boa muleke");
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite a mesma senha nos dois campos");
            }
        }
    }
}

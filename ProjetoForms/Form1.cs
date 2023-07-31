using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//titulo cadastro pessoa

       
        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(maskedTextBox2.Text);
            string nome = textBox2.Text;
            string telefone = maskedTextBox1.Text;
            string endereco = textBox4.Text;
            string cidade = textBox5.Text;
            string estado = textBox6.Text; //.text é para guadar oque foi digitado

            MessageBox.Show("Codigo: " + codigo +
                "\nNome: " + nome + 
                "\nTelefone: " + telefone +
                "\nEndereço: " + endereco +
                "\nCidade: " + cidade +
                "\nEstado: " + estado);

        }//botao cadastrar

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// campo nome

      
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//campo endereco

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }// campo cidade

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//campo estado

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//codigo

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//telefone

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }//fim da classe
}//fim do codigo

using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double parsed))
            {
                resultado = parsed;
                AtualizarCategoria();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AtualizarCategoria()
        {
            string categoria = string.Empty;

            if (resultado < 18.5)
            {
                categoria = "Magreza";
            }
            else if (resultado >= 18.5 && resultado <= 24.9)
            {
                categoria = "Normal";
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                categoria = "Sobrepeso";
            }
            else if (resultado >= 30)
            {
                categoria = "Obesidade Grave";
            }

            textBox4.Text = categoria;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            resultado = valor1 / (valor2 * valor2);

            textBox3.Text = resultado.ToString("F2");
            AtualizarCategoria();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}

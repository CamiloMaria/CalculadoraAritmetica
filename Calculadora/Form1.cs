using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operadores;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operadores == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operadores == '−')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operadores == 'X')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operadores == '∕')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operadores = '\0';
            txtResultado.Text = "0";
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void Signo_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Numero1 *= -1;
            txtResultado.Text = Numero1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operadores = Convert.ToChar(boton.Tag);

            if (Operadores == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                txtResultado.Text = Numero1.ToString();
            }
            else if (Operadores == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                txtResultado.Text = Numero1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }
        }
    }
}

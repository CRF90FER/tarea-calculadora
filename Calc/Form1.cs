using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{

    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5,
    }



    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        bool unNumeroLeido = false;




        public Form1()
        {
            InitializeComponent();
        }

        private void leerNumero(string numero)
        {
            unNumeroLeido = true;
            if (Cajaresultado.Text == "0" && Cajaresultado.Text != null)
            {
                Cajaresultado.Text = numero;
            }
            else
            {
                Cajaresultado.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }




















        private void button3_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (Cajaresultado.Text.Contains("."))
            {
                return;
            }
            Cajaresultado.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            leerNumero("4");
        }

        private void Cajaresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton0_Click(object sender, EventArgs e)
        {
            unNumeroLeido =true;
            if (Cajaresultado.Text == "0")
            {
                return;
            }
            else
            {
                Cajaresultado.Text += "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            leerNumero("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            leerNumero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }




        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(Cajaresultado.Text);
            lbl.Text = Cajaresultado.Text + operador;
            Cajaresultado.Text = "0";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

        }

        private void button15Igual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDouble(Cajaresultado.Text);
                lbl.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                Cajaresultado.Text = Convert.ToString(resultado);
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("X");
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void C_Click(object sender, EventArgs e)
        {
            Cajaresultado.Text = "0";
            lbl.Text = "";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (Cajaresultado.Text.Length > 1)
            {
                string txtResultado = Cajaresultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    Cajaresultado.Text = "0";
                }
                else
                {
                    Cajaresultado.Text = txtResultado;
                }

                Cajaresultado.Text = txtResultado;
            }
            else
            {
                Cajaresultado.Text = "0";
            }
        }
    }
}



































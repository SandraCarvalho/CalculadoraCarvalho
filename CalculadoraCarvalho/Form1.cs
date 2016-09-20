using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace CalculadoraCarvalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            long numeroA;
            long numeroB;
            long resultado;
            long.TryParse(textBoxNumeroA.Text, out numeroA);
            long.TryParse(textBoxNumeroB.Text, out numeroB);
            resultado = numeroA + numeroB;

            textBoxResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            long numeroA;
            long numeroB;
            long resultado;
            long.TryParse(textBoxNumeroA.Text, out numeroA);
            long.TryParse(textBoxNumeroB.Text, out numeroB);
            resultado = numeroA - numeroB;
            textBoxResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            long numeroA;
            long numeroB;
            long resultado;
            long.TryParse(textBoxNumeroA.Text, out numeroA);
            long.TryParse(textBoxNumeroB.Text, out numeroB);
            resultado = numeroA * numeroB;

            textBoxResultado.Text = resultado.ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            long numeroA;
            long counter;
            BigInteger resultado = 1;

            long.TryParse(textBoxNumeroA.Text, out numeroA);

            if (numeroA >= 1)

                for (counter = 1; counter <= numeroA; counter++)
                {
                    resultado = counter * resultado;
                }
            textBoxResultado.Text = resultado.ToString();

            if (numeroA < 1)
            {
                textBoxResultado.Text = "Não pode calcular o Factorial de um número negativo";
            }

            if (numeroA == 0)
            {
                textBoxResultado.Text = "0";
            }
        }
    }
}

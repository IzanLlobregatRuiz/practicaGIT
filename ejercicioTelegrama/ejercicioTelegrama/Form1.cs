using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama;
            int numPalabras;
            double coste = 0;

            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text.Trim();

            //Determinar tipo
            if (chkUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';

            //Contar palabras correctamente
            string[] palabras = textoTelegrama.Split(' ');
            numPalabras = palabras.Length;

            //Cálculo del precio
            if (tipoTelegrama == 'o')  // ORDINARIO
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else  // URGENTE
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            txtPrecio.Text = coste.ToString() + " euros";
            // si no funciona lloro :)
        }
    }
}

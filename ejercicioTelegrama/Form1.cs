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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama;
            int numPalabras;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // Determino si es urgente u ordinario
            tipoTelegrama = chkUrgente.Checked ? 'u' : 'o';

            // Obtengo el número real de palabras
            numPalabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Cálculo del coste
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numPalabras;
            }
            else // urgente
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }

            txtPrecio.Text = coste.ToString("0.00") + " euros";
        }



    }
}
}

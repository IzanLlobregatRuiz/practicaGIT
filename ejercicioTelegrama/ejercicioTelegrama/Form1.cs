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
            // ============================
            // 1. Leer datos del formulario
            // ============================
            string textoTelegrama = txtTelegrama.Text.Trim();
            bool esUrgente = chkUrgente.Checked;

            // ============================
            // 2. Calcular número de palabras
            // ============================
            string[] palabras = textoTelegrama.Split(' ');
            int numPalabras = palabras.Length;

            // ============================
            // 3. Definir precios base
            // ============================
            double precioBase = esUrgente ? 5.0 : 2.5;
            double precioExtra = esUrgente ? 0.75 : 0.50;

            // ============================
            // 4. Calcular coste final
            // ============================
            double coste;

            if (numPalabras <= 10)
            {
                coste = precioBase;
            }
            else
            {
                int palabrasExtra = numPalabras - 10;
                coste = precioBase + (palabrasExtra * precioExtra);
            }

            // ============================
            // 5. Mostrar resultado
            // ============================
            txtPrecio.Text = coste.ToString("0.00") + " euros";
        }
    }
}

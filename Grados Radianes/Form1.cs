using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grados_Radianes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double CantidadGrados, ResultadoRadianes, Pi = 3.14;

            CantidadGrados = double.Parse(CantidadGradoTextBox.Text);

            ResultadoRadianes = CantidadGrados * Pi / 180;

            ResultadoRadianesTextBox.Text = ResultadoRadianes.ToString();
        }
        private void Limpiar()
        {
            CantidadGradoTextBox.Clear();
            ResultadoRadianesTextBox.Clear();

        }
        private void BorrarGradoRadianesBotton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

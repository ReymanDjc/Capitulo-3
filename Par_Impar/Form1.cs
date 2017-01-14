using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Par_Impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularNumeroButton_Click(object sender, EventArgs e)
        {
            int Numero;
            Numero = int.Parse(DigiteNumeroTextBox.Text);

            if (Numero % 2 == 0)

                ResultadoTextBox.Text = " par".ToString();
            else
                ResultadoTextBox.Text = "impar".ToString();

        }
        private void Limpiar()
        {
            DigiteNumeroTextBox.Clear();
            ResultadoTextBox.Clear();
        }
        private void BorrarBotton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjBhaskhara3256
{
    public partial class Form1 : Form
    {

        double valorA, valorB, valorC, raiz1, raiz2, delta;

        private void btnFec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            valorDeA.Text = null;
            valorDeB.Text = null;
            valorDeC.Text = null;
            raizX1.Text = null;
            raizX2.Text = null;
            valorDeA.Focus();
        }

        void EntradaDados()
        {
            valorA = Convert.ToDouble(valorDeA.Text);
            valorB = Convert.ToDouble(valorDeB.Text);
            valorC = Convert.ToDouble(valorDeC.Text);

        }
        void CalcularBhaskara()
        {

            delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);
            raiz1 = -(valorB + Math.Sqrt(delta)) / (2 * valorA);
            raiz2 = -(valorB - Math.Sqrt(delta)) / (2 * valorA);

            raizX1.Text = raiz1.ToString();
            raizX2.Text = raiz2.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            EntradaDados();
            CalcularBhaskara();
        }
    }
}

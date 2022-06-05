using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII_2022_II_P1_EJERCICIO22
{
    public partial class frmCalculadoraInteres : Form
    {
        public frmCalculadoraInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal montoPrincipal = decimal.Parse(txtMontoPrincipal.Text);
            double tasaInteres = double.Parse(txtTazaInteres.Text);
            int año = (int)nudAños.Value;
            string salida = "Año\tMonto a depositar\r\n";
            //variable sumatoria
            decimal tot=0.0M;
            ///
            for(int contAño =0; contAño<=año; contAño++)
            {
                decimal montoDepositar = montoPrincipal *
                    ((decimal)Math.Pow(1 + tasaInteres / 100, contAño));
                salida += $"{contAño}\t{montoDepositar:C}\r\n";
                //sumando
                tot += montoDepositar;

            }
            //añadimos a la salida
            salida += $"Total a pagar: {tot:C}\r\n";
            txtResumen.Text = salida;
        }
    }
}

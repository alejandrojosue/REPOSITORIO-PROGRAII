using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII_2022_II_P1_EJERCICIO21
{
    public partial class frmCobro : Form
    {
        public frmCobro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal totalPagar = 0.0M;
            if (chkJamon.Checked)
            {
                totalPagar += 15.21M;
            }
            else if (chkPepperoni.Checked)
            {
                totalPagar += 14.31M;
            }
            else if (chkCebolla.Checked)
            {
                totalPagar += 5.63M;
            }
            else if (chkChile.Checked)
            {
                totalPagar += 7.7M;
            }

            MessageBox.Show($"El total a pagar es: {totalPagar:C}","Total a pagar");
        }
    }
}

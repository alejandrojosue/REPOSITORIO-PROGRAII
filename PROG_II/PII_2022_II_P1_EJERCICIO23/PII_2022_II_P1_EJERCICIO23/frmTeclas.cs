using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII_2022_II_P1_EJERCICIO23
{
    public partial class frmTeclas : Form
    {
        public frmTeclas()
        {
            InitializeComponent();
        }

        private void frmTeclas_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTecla.Text = $"Key presionado: {e.KeyChar}";
        }

        private void frmTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            lblInfoTecla.Text = $"Alt: {(e.Alt ? "Si" : "No")}\n" +
                $"Shift: {(e.Shift ? "Si" : "No")}\n" +
                $"Control: {(e.Control ? "Si" : "No")}\n" +
                $"TeclaData: {e.KeyData }\n" +
                $"TeclaValue: {e.KeyValue}\n";
        }

        private void frmTeclas_KeyUp(object sender, KeyEventArgs e)
        {
            lblTecla.Text = "";
            lblInfoTecla.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII_2022_II_P1_EJERCICIO19
{
    public partial class frmCredencial : Form
    {
        public frmCredencial()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            if (!string.IsNullOrEmpty(clave))
            {
                if (clave == "admin")
                {
                    lblMensaje.Text = "Clave correcta!";
                }
                else {
                    lblMensaje.Text = "Clave incorrecta!";
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese una clave!";
                txtClave.Select();
            }
                
            //MessageBox.Show($"Su clave es: {nom}", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}

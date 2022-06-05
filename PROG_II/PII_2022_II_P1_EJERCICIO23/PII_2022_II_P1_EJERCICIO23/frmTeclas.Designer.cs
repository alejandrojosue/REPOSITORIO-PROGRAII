
namespace PII_2022_II_P1_EJERCICIO23
{
    partial class frmTeclas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTecla = new System.Windows.Forms.Label();
            this.lblInfoTecla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTecla
            // 
            this.lblTecla.AutoSize = true;
            this.lblTecla.Location = new System.Drawing.Point(36, 33);
            this.lblTecla.Name = "lblTecla";
            this.lblTecla.Size = new System.Drawing.Size(49, 25);
            this.lblTecla.TabIndex = 0;
            this.lblTecla.Text = "Tecla";
            // 
            // lblInfoTecla
            // 
            this.lblInfoTecla.AutoSize = true;
            this.lblInfoTecla.Location = new System.Drawing.Point(36, 97);
            this.lblInfoTecla.Name = "lblInfoTecla";
            this.lblInfoTecla.Size = new System.Drawing.Size(174, 25);
            this.lblInfoTecla.TabIndex = 1;
            this.lblInfoTecla.Text = "Informacion de tecla";
            // 
            // frmTeclas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfoTecla);
            this.Controls.Add(this.lblTecla);
            this.Name = "frmTeclas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teclas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTeclas_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTeclas_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTeclas_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecla;
        private System.Windows.Forms.Label lblInfoTecla;
    }
}


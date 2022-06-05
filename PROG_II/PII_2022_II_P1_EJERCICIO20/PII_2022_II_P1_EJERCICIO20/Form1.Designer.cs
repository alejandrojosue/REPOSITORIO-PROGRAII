
namespace PII_2022_II_P1_EJERCICIO20
{
    partial class Form1
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
            this.grpSaludos = new System.Windows.Forms.GroupBox();
            this.pnlPrueba = new System.Windows.Forms.Panel();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.btnInvitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpSaludos.SuspendLayout();
            this.pnlPrueba.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSaludos
            // 
            this.grpSaludos.Controls.Add(this.btnInvitar);
            this.grpSaludos.Controls.Add(this.btnSaludar);
            this.grpSaludos.Location = new System.Drawing.Point(25, 25);
            this.grpSaludos.Name = "grpSaludos";
            this.grpSaludos.Size = new System.Drawing.Size(267, 214);
            this.grpSaludos.TabIndex = 0;
            this.grpSaludos.TabStop = false;
            this.grpSaludos.Text = "Saludos";
            // 
            // pnlPrueba
            // 
            this.pnlPrueba.Controls.Add(this.button1);
            this.pnlPrueba.Controls.Add(this.button2);
            this.pnlPrueba.Location = new System.Drawing.Point(426, 25);
            this.pnlPrueba.Name = "pnlPrueba";
            this.pnlPrueba.Size = new System.Drawing.Size(253, 214);
            this.pnlPrueba.TabIndex = 1;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(23, 43);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(203, 48);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            // 
            // btnInvitar
            // 
            this.btnInvitar.Location = new System.Drawing.Point(23, 133);
            this.btnInvitar.Name = "btnInvitar";
            this.btnInvitar.Size = new System.Drawing.Size(203, 60);
            this.btnInvitar.TabIndex = 1;
            this.btnInvitar.Text = "Invitar";
            this.btnInvitar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Invitar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Saludar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 356);
            this.Controls.Add(this.pnlPrueba);
            this.Controls.Add(this.grpSaludos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSaludos.ResumeLayout(false);
            this.pnlPrueba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSaludos;
        private System.Windows.Forms.Button btnInvitar;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Panel pnlPrueba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


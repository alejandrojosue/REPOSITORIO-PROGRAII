
namespace PII_2022_II_P1_EJERCICIO22
{
    partial class frmCalculadoraInteres
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
            this.lblMontoPrincipal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAños = new System.Windows.Forms.Label();
            this.txtMontoPrincipal = new System.Windows.Forms.TextBox();
            this.txtTazaInteres = new System.Windows.Forms.TextBox();
            this.nudAños = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResumen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAños)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMontoPrincipal
            // 
            this.lblMontoPrincipal.AutoSize = true;
            this.lblMontoPrincipal.Location = new System.Drawing.Point(51, 76);
            this.lblMontoPrincipal.Name = "lblMontoPrincipal";
            this.lblMontoPrincipal.Size = new System.Drawing.Size(141, 25);
            this.lblMontoPrincipal.TabIndex = 0;
            this.lblMontoPrincipal.Text = "Monto Principal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taza Interés:";
            // 
            // txtAños
            // 
            this.txtAños.AutoSize = true;
            this.txtAños.Location = new System.Drawing.Point(135, 187);
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(57, 25);
            this.txtAños.TabIndex = 2;
            this.txtAños.Text = "Años:";
            // 
            // txtMontoPrincipal
            // 
            this.txtMontoPrincipal.Location = new System.Drawing.Point(204, 73);
            this.txtMontoPrincipal.Name = "txtMontoPrincipal";
            this.txtMontoPrincipal.Size = new System.Drawing.Size(189, 31);
            this.txtMontoPrincipal.TabIndex = 3;
            // 
            // txtTazaInteres
            // 
            this.txtTazaInteres.Location = new System.Drawing.Point(204, 126);
            this.txtTazaInteres.Name = "txtTazaInteres";
            this.txtTazaInteres.Size = new System.Drawing.Size(189, 31);
            this.txtTazaInteres.TabIndex = 4;
            // 
            // nudAños
            // 
            this.nudAños.Location = new System.Drawing.Point(204, 185);
            this.nudAños.Name = "nudAños";
            this.nudAños.Size = new System.Drawing.Size(188, 31);
            this.nudAños.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(51, 234);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(342, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResumen
            // 
            this.txtResumen.Location = new System.Drawing.Point(51, 293);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumen.Size = new System.Drawing.Size(342, 125);
            this.txtResumen.TabIndex = 7;
            // 
            // frmCalculadoraInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudAños);
            this.Controls.Add(this.txtTazaInteres);
            this.Controls.Add(this.txtMontoPrincipal);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMontoPrincipal);
            this.Name = "frmCalculadoraInteres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculadora de Interes";
            ((System.ComponentModel.ISupportInitialize)(this.nudAños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtAños;
        private System.Windows.Forms.TextBox txtMontoPrincipal;
        private System.Windows.Forms.TextBox txtTazaInteres;
        private System.Windows.Forms.NumericUpDown nudAños;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResumen;
    }
}


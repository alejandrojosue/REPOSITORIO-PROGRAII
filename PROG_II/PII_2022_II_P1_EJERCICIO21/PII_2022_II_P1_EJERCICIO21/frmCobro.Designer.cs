
namespace PII_2022_II_P1_EJERCICIO21
{
    partial class frmCobro
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
            this.grbIngredientes = new System.Windows.Forms.GroupBox();
            this.chkChile = new System.Windows.Forms.CheckBox();
            this.chkCebolla = new System.Windows.Forms.CheckBox();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIngredientes
            // 
            this.grbIngredientes.Controls.Add(this.chkJamon);
            this.grbIngredientes.Controls.Add(this.chkPepperoni);
            this.grbIngredientes.Controls.Add(this.chkCebolla);
            this.grbIngredientes.Controls.Add(this.chkChile);
            this.grbIngredientes.Location = new System.Drawing.Point(32, 12);
            this.grbIngredientes.Name = "grbIngredientes";
            this.grbIngredientes.Size = new System.Drawing.Size(241, 187);
            this.grbIngredientes.TabIndex = 0;
            this.grbIngredientes.TabStop = false;
            this.grbIngredientes.Text = "Ingredientes";
            // 
            // chkChile
            // 
            this.chkChile.AutoSize = true;
            this.chkChile.Location = new System.Drawing.Point(19, 45);
            this.chkChile.Name = "chkChile";
            this.chkChile.Size = new System.Drawing.Size(76, 29);
            this.chkChile.TabIndex = 0;
            this.chkChile.Text = "Chile";
            this.chkChile.UseVisualStyleBackColor = true;
            // 
            // chkCebolla
            // 
            this.chkCebolla.AutoSize = true;
            this.chkCebolla.Location = new System.Drawing.Point(19, 80);
            this.chkCebolla.Name = "chkCebolla";
            this.chkCebolla.Size = new System.Drawing.Size(97, 29);
            this.chkCebolla.TabIndex = 1;
            this.chkCebolla.Text = "Cebolla";
            this.chkCebolla.UseVisualStyleBackColor = true;
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(19, 145);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(90, 29);
            this.chkJamon.TabIndex = 3;
            this.chkJamon.Text = "Jamon";
            this.chkJamon.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(19, 110);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(118, 29);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(32, 222);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(241, 39);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbIngredientes);
            this.Name = "frmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobro";
            this.grbIngredientes.ResumeLayout(false);
            this.grbIngredientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIngredientes;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkCebolla;
        private System.Windows.Forms.CheckBox chkChile;
        private System.Windows.Forms.Button btnCalcular;
    }
}


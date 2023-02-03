
namespace TAREA1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValortextBox1 = new System.Windows.Forms.TextBox();
            this.RESULTADO = new System.Windows.Forms.Button();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.ValorestextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Entero :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "El valor es par o impar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "El valor es positivo o negativo : ";
            // 
            // ValortextBox1
            // 
            this.ValortextBox1.Location = new System.Drawing.Point(250, 78);
            this.ValortextBox1.Name = "ValortextBox1";
            this.ValortextBox1.Size = new System.Drawing.Size(100, 20);
            this.ValortextBox1.TabIndex = 3;
            // 
            // RESULTADO
            // 
            this.RESULTADO.Location = new System.Drawing.Point(250, 134);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(82, 30);
            this.RESULTADO.TabIndex = 4;
            this.RESULTADO.Text = "RESULTADO";
            this.RESULTADO.UseVisualStyleBackColor = true;
            this.RESULTADO.Click += new System.EventHandler(this.RESULTADO_Click);
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(250, 193);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(113, 20);
            this.NombretextBox1.TabIndex = 5;
            // 
            // ValorestextBox2
            // 
            this.ValorestextBox2.Location = new System.Drawing.Point(250, 238);
            this.ValorestextBox2.Name = "ValorestextBox2";
            this.ValorestextBox2.Size = new System.Drawing.Size(113, 20);
            this.ValorestextBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 334);
            this.Controls.Add(this.ValorestextBox2);
            this.Controls.Add(this.NombretextBox1);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.ValortextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValortextBox1;
        private System.Windows.Forms.Button RESULTADO;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.TextBox ValorestextBox2;
    }
}


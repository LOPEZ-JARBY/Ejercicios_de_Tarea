
namespace Tarea2
{
    partial class CalculoPromedio
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nota1textBox1 = new System.Windows.Forms.TextBox();
            this.Nota2textBox2 = new System.Windows.Forms.TextBox();
            this.Nota3textBox3 = new System.Windows.Forms.TextBox();
            this.Nota4textBox4 = new System.Windows.Forms.TextBox();
            this.PromediotextBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota2 : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota3 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota4 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Promedio Final : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Nota1textBox1
            // 
            this.Nota1textBox1.Location = new System.Drawing.Point(153, 33);
            this.Nota1textBox1.Name = "Nota1textBox1";
            this.Nota1textBox1.Size = new System.Drawing.Size(100, 20);
            this.Nota1textBox1.TabIndex = 5;
            this.Nota1textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nota2textBox2
            // 
            this.Nota2textBox2.Location = new System.Drawing.Point(153, 64);
            this.Nota2textBox2.Name = "Nota2textBox2";
            this.Nota2textBox2.Size = new System.Drawing.Size(100, 20);
            this.Nota2textBox2.TabIndex = 6;
            // 
            // Nota3textBox3
            // 
            this.Nota3textBox3.Location = new System.Drawing.Point(153, 102);
            this.Nota3textBox3.Name = "Nota3textBox3";
            this.Nota3textBox3.Size = new System.Drawing.Size(100, 20);
            this.Nota3textBox3.TabIndex = 7;
            // 
            // Nota4textBox4
            // 
            this.Nota4textBox4.Location = new System.Drawing.Point(153, 137);
            this.Nota4textBox4.Name = "Nota4textBox4";
            this.Nota4textBox4.Size = new System.Drawing.Size(100, 20);
            this.Nota4textBox4.TabIndex = 8;
            // 
            // PromediotextBox5
            // 
            this.PromediotextBox5.Location = new System.Drawing.Point(201, 242);
            this.PromediotextBox5.Name = "PromediotextBox5";
            this.PromediotextBox5.Size = new System.Drawing.Size(100, 20);
            this.PromediotextBox5.TabIndex = 9;
            this.PromediotextBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "CALCULARbutton1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculoPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PromediotextBox5);
            this.Controls.Add(this.Nota4textBox4);
            this.Controls.Add(this.Nota3textBox3);
            this.Controls.Add(this.Nota2textBox2);
            this.Controls.Add(this.Nota1textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculoPromedio";
            this.Text = "CalculoPromedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nota1textBox1;
        private System.Windows.Forms.TextBox Nota2textBox2;
        private System.Windows.Forms.TextBox Nota3textBox3;
        private System.Windows.Forms.TextBox Nota4textBox4;
        private System.Windows.Forms.TextBox PromediotextBox5;
        private System.Windows.Forms.Button button1;
    }
}


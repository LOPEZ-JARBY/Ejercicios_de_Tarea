using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class CalculoPromedio : Form
    {
        Decimal PromedioFinal;
        public CalculoPromedio()
        {
            InitializeComponent();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal Nota1, Nota2, Nota3, Nota4;

            Nota1 = Decimal.Parse(Nota1textBox1.Text);
            Nota2 = Decimal.Parse(Nota2textBox2.Text);
            Nota3 = Decimal.Parse(Nota3textBox3.Text);
            Nota4 = Decimal.Parse(Nota4textBox4.Text);

            Calculo(Nota1, Nota2, Nota3, Nota4, PromedioFinal);

        }
        private Decimal Calculo(decimal Nota1, decimal Nota2, decimal Nota3, decimal Nota4, decimal Promedio)
        {

            Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            PromediotextBox5.Text = Promedio.ToString();

            return Promedio;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

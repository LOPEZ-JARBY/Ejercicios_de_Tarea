using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void RESULTADO_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(ValortextBox1.Text);

            Valores(valor);
            Nombre(valor);

        }
        private decimal Valores(decimal Numero)
        {
            if (Numero < 0)
            {
                ValorestextBox2.Text = ("NEGATIVO");
            }
            else {
                ValorestextBox2.Text = ("POSITIVO");
            }
            return Numero;

        }
        private void Nombre(decimal ValorEntero)
        {
            if (ValorEntero %  2 == 0)
            {
                NombretextBox1.Text = ("PAR");
            }else
            {
                NombretextBox1.Text = ("IMPAR");
            }
        }
    }
}

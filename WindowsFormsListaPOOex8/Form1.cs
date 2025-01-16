using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maior_Emenor(object sender, EventArgs e)
        {
            double vl1, vl2, resul;
            vl1 = double.Parse(tbx_valor1.Text);
            vl2 = double.Parse(tbx_valor2.Text);

            if (vl1 > vl2)
            {
                resul = vl1;
                lbl_resultado.Text = "O maior é o primeiro: " + vl1.ToString();
            }
            else if (vl1 < vl2)
            {
                resul = vl2;
                lbl_resultado.Text = "O maior é o segundo: " + vl2.ToString();
            }
            else
            {
                lbl_resultado.Text = "Os valores são iguais.";
            }
            lbl_resultado.Visible = true;

        }
    }
}

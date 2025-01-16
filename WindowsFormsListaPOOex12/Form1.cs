using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Descobrir_Triangulo(object sender, EventArgs e)
        {
            double ld1, ld2, ld3;
            ld1 = double.Parse(tbx_lado1.Text);
            ld2 = double.Parse(tbx_lado2.Text);
            ld3 = double.Parse(tbx_lado3.Text);
            if (ld1 > ld2 && ld1 > ld3 && ld1 * ld1 == ld2 * ld2 + ld3 * ld3)
            {
                lbl_resultado.Text = "É um triangulo retangulo";
            }
            else if (ld2 > ld1 && ld2 > ld3 && ld2 * ld2 == ld1 * ld1 + ld3 * ld3)
            {
                lbl_resultado.Text = "É um triangulo retangulo";
            }
            else if (ld3 > ld1 && ld3 > ld2 && ld3 * ld3 == ld1 * ld1 + ld2 * ld2)
            {
                lbl_resultado.Text = "É um triangulo retangulo";
            }
            else
            {
                lbl_resultado.Text = "Não é um triangulo retangulo";
            }
            lbl_resultado.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void descobrir_Seetriangulo(object sender, EventArgs e)
        {
            double ld1, ld2, ld3;
            ld1 = double.Parse(tbx_lado1.Text);
            ld2 = double.Parse(tbx_lado2.Text);
            ld3 = double.Parse(tbx_lado3.Text);
            if (ld1 + ld2 > ld3)
            {

                if (ld1 + ld3 > ld2)
                {

                    if (ld2 + ld3 > ld1)
                    {

                        if (ld1 == ld2)
                        {

                            if (ld1 == ld3)
                            {

                                lbl_resultado.Text = "Equilátero";
                            }
                            else
                                lbl_resultado.Text = "Isósceles";
                        }
                        else
                            if (ld2 == ld3)
                        {

                            lbl_resultado.Text = "Isósceles";
                        }
                        else
                                  if (ld1 == ld3)
                        {

                            lbl_resultado.Text = "Isósceles";
                        }
                        else
                            lbl_resultado.Text = "Escaleno";
                    }
                    else
                        lbl_resultado.Text = "Não forma triângulo";
                }
                else
                    lbl_resultado.Text = "Não forma triângulo";
            }
            else
                lbl_resultado.Text = "Não forma triângulo";

            lbl_resultado.Visible = true;
        }
    }
}

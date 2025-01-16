using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Maior_Emenor(object sender, EventArgs e)
        {
            int Valor1, Valor2, Maior;
            Valor1 = int.Parse(N3.Text);
            Valor2 = int.Parse(N4.Text);
            
            
                if (Valor1 > Valor2)
                {
                    Maior = Valor1;
                    label7.Text = Maior.ToString();
                }
                else if (Valor1 < Valor2)
                {
                    Maior = Valor2;
                    label7.Text = Maior.ToString();
                }
            else if (Valor1 == Valor2)
            {
                label7.Text = "Os valores tem que ser diferentes, Digite novamente";
                
            }




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_IMC(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura=double.Parse(tbx_altura.Text);
            peso=double.Parse(tbx_peso.Text);
            imc = peso/Math.Pow(altura, 2);
            if (imc <= 20)
            {
                lbl_imc.Text="Abaixo do peso - IMC " + imc.ToString();
            }
            else if (imc < 25)
            {
                lbl_imc.Text="Peso ideal - IMC " + imc.ToString();
            }
            else if (imc >= 25)
            {
                lbl_imc.Text="Acima do peso - IMC " + imc.ToString();
            }
            lbl_imc.Visible = true;
        }
    }
}

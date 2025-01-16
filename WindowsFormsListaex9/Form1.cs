using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_AreaRet(object sender, EventArgs e)
        {
            double are, bas, resul;
            are = double.Parse(tbx_altura.Text);
            bas = double.Parse(tbx_base.Text);
            resul = are * bas;
            if (resul > 100)
            {
                lbl_resultado.Text = "Terreno grande";
            }
            else
            {
                lbl_resultado.Text = "Terreno pequeno";
            }
            lbl_resultado.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer3
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Area_diago(object sender, EventArgs e)
        {
            double dia, resul;
            dia = double.Parse(Diagonal.Text);
            resul = (dia * dia) / 2;
            Resultado.Text = resul.ToString();
        }
    }
}

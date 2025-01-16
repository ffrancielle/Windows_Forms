using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer5
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Converte_pKm(object sender, EventArgs e)
        {
            Double milha, resul;
            milha = double.Parse(Milhas.Text);
            resul = milha * 1.852;
            Resultado.Text = resul.ToString() + "Km";
        }
    }
}

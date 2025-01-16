using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer6
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

        private void Converção_Preal(object sender, EventArgs e)
        {
            double dollar, converçao;
            dollar = double.Parse(Dollar.Text);
            converçao = dollar * 5.80;
            Resultado.Text = "R$ " + converçao.ToString();
        }
    }
}

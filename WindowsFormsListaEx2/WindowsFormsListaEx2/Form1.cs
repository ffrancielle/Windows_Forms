using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcular(object sender, EventArgs e)
        {
            Quadrado q;
            q = new Quadrado();
            q.setLado(int.Parse(txtLado.Text));
            q.calcularArea();
            labResultado.Text = q.getArea().ToString();


        }
    }
}

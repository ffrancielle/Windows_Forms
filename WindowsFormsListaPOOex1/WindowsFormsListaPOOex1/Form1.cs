using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaPOOex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularArea(object sender, EventArgs e)
        {
            Retangulo r;
            r = new Retangulo();
            r.setBase(int.Parse(txtBase.Text));
            r.setAltura(int.Parse(txtAltura.Text));
            r.calcularArea();
            lblResultado.Text = r.getArea().ToString();


        }
    }
}

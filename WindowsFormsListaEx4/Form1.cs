using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPooFormsExer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Area_Triangulo(object sender, EventArgs e)
        {
            double alt, bas, are;
            bas = double.Parse(Base.Text);
            alt = double.Parse(Altura.Text);
            are = (bas * alt) / 2;
            Resultado.Text = are.ToString();
        }
    }
}

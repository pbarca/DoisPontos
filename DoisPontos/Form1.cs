using System;
using System.Windows.Forms;

namespace DoisPontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Triangulo T = new Triangulo();

        private void Button1_Click(object sender, EventArgs e)
        {
            T.P1.X = Convert.ToDouble(x1.Text);
            T.P1.Y = Convert.ToDouble(y1.Text);
            T.P1.Z = Convert.ToDouble(z1.Text);
            T.P2.X = Convert.ToDouble(x2.Text);
            T.P2.Y = Convert.ToDouble(y2.Text);
            T.P2.Z = Convert.ToDouble(z2.Text);
            T.P3.X = Convert.ToDouble(x3.Text);
            T.P3.Y = Convert.ToDouble(y3.Text);
            T.P3.Z = Convert.ToDouble(z3.Text);
            if (area.Checked) label1.Text = T.Area.ToString();
            else if (perimetro.Checked) label1.Text = T.Perimetro.ToString();
        }
    }
}

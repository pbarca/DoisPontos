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

        Ponto P1 = new Ponto();
        Ponto P2 = new Ponto();

        private void Button1_Click(object sender, EventArgs e)
        {
            P1.X = Convert.ToDouble(x1.Text);
            P1.Y = Convert.ToDouble(y1.Text);
            P2.X = Convert.ToDouble(x2.Text);
            P2.Y = Convert.ToDouble(y2.Text);
            label1.Text = P1.Distancia(P2).ToString();
        }
    }
}

using System;

namespace DoisPontos
{
    class Triangulo
    {
        public Ponto P1 = new Ponto();
        public Ponto P2 = new Ponto();
        public Ponto P3 = new Ponto();
        public double Perimetro => P1.Distancia(P2) + P2.Distancia(P3) + P3.Distancia(P1);
        public double Area
        {
            get
            {
                double s = this.Perimetro / 2;
                double a = P1.Distancia(P2);
                double b = P2.Distancia(P3);
                double c = P3.Distancia(P1);
                double T = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
                return T;
            }

        }
    }
}

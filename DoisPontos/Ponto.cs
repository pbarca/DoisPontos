using System;

namespace DoisPontos
{
    class Ponto
    {
        private double _X, _Y;
        public double X { set => _X = value; get => _X; }
        public double Y { set => _Y = value; get => _Y; }
        public double Distancia(Ponto P) =>
        Math.Sqrt(Math.Pow(P.X - _X, 2) + Math.Pow(P.Y - _Y, 2));
    }
}

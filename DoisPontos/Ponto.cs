using System;

namespace DoisPontos
{
    class Ponto
    {
        private double _X, _Y, _Z;
        public double X { set => _X = value; get => _X; }
        public double Y { set => _Y = value; get => _Y; }
        public double Z { set => _Z = value; get => _Z; }
        public double Distancia(Ponto P) =>
        Math.Sqrt(Math.Pow(P.X - _X, 2) + Math.Pow(P.Y - _Y, 2) + Math.Pow(P.Z - _Z, 2));
    }
}

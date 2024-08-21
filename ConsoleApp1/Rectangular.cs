using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangular
    {

        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }

        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }
        public int y4 { get; set; }

        public double Base { get; set; }
        public double Altura { get; set; }
        public double Distancia {  get; set; }

        public double Area { get; set; }

        public double Perimetro { get; set; }

        public double CalcularDistancia(int a1, int b1, int a2, int b2) 
        {
            return Distancia = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));

        }
        public void CalcularBase()
        {
            Base = CalcularDistancia(x1, y1, x2, y2);
        }

        public void CalcularAltura()
        {
            Altura = CalcularDistancia(x2, y2, x3, y3);
        }

        public void CalcularArea()
        {
            Area = Base * Altura;
        }
        public void CalcularPerimetro()
        {
            Perimetro = (Base + Altura) * 2; 
        }
    }
}

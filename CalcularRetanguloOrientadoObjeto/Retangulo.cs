using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalcularRetanguloOrientadoObjeto
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
        
    }
}

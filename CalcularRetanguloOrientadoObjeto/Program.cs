using System;
using System.Globalization;

namespace CalcularRetanguloOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Digite os valores do retangulo!");
            Console.WriteLine("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

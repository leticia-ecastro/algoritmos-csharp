// Elabore um algoritmo que calcule a área e o perímetro de um retângulo.
// Área = base x altura
// Perímetro = soma de todos os lados

using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base do retângulo: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo: ");
            int h = int.Parse(Console.ReadLine());
            int area = b * h;
            int perimetro = h + b + h + b;

            Console.WriteLine("Área: " + area + "\nPerímetro: " + perimetro);
        }
    }
}

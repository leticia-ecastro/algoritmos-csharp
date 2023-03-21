// Elabore um algoritmo que entre com valor do raio e calcule a área e o perímetro do círculo correspondente.

using System;

namespace Exercicio14;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor do raio da circunferência: ");
        double raio = double.Parse(Console.ReadLine());
        // raio ao quadrado:
        double raioQuadrado = Math.Pow(raio, 2);
        // Área = pi * raio²
        double area = Math.PI * raioQuadrado;
        // Perímetro = 2*pi*raio
        double perimetro = 2 * Math.PI * raio;

        Console.WriteLine("A circunferência de raio igual a " + raio + " tem área igual a " + area + " e perímetro igual a " + perimetro + ".");
    }
}

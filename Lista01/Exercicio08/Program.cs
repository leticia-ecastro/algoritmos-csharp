//Elabore um algoritmo que calcule a área e o perímetro de um quadrado.
//Área do quadrado = lado ^ 2
//Perímetro = soma de todos os lados

using System;

namespace Exercicio08;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor do lado do quadrado: ");
        double lado = int.Parse(Console.ReadLine());
        double area = Math.Pow(lado, 2);
        double perimetro = lado + lado + lado + lado;

        Console.WriteLine("Área do quadrado: " + area);
        Console.WriteLine("Perímetro do quadrado: " + perimetro);
    }
}

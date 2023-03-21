/*
Construa um algoritmo que possa calcular o volume de um prisma de base triangular
Volume = área da base x altura.
*/

using System;

namespace Exercicio17;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor da Área da base do triângulo: ");
        double areaBase = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor da Altura do triângulo: ");
        double altura = double.Parse(Console.ReadLine());
        double volume = areaBase * altura;

        Console.WriteLine("O Volume do prisma triangular é igual a: " + volume + ".");
    }
}

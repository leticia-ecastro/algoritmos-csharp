//Elabore um algoritmo que possa calcular o volume de um cilindro.

using System;

namespace Exercicio19;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o valor do raio da base do cilindro: ");
        double raio = double.Parse(Console.ReadLine());
        Console.Write("Insira o valor da altura do cilindro: ");
        double altura = double.Parse(Console.ReadLine());
        //Área da base do Cilindro = PI * raio^2
        double areaBase = Math.PI * Math.Pow(raio, 2);
        //Volume do Cilindro = área da base x altura
        double volume = areaBase * altura;

        Console.WriteLine("O cilindo tem volume igual a " + volume + ".");
    }
}

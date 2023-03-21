/*
Elabore um algoritmo que calcule a área de um trapézio qualquer.
Área = [(base maior + base menor) * altura] / 2
*/

using System;

namespace Exercicio16;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor da altura do trapézio: ");
        double altura = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor da base menor do trapézio: ");
        double baseMenor = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor da base maior do trapézio: ");
        double baseMaior = double.Parse(Console.ReadLine());
        double area = ((baseMaior + baseMenor) * altura) / 2;

        Console.WriteLine("O trapézio de bases " + baseMenor + " e " + baseMaior + " e altura igual a " + altura + " tem área igual a " + area + ".");
    }
}

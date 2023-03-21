//Cria um algoritmo que receba 5 números do tipo double e exiba a soma com a seguinte frase: “Os números digitados foram ..., ..., ..., ... e sua soma é ... .

using System;

namespace Exercicio05;
class Program
{
    static void Main(string[] args)
    {
        double? num1, num2, num3, num4, num5;

        Console.Write("Digite o valor do primeiro número: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do segundo número: ");
        num2 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do terceiro número: ");
        num3 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do quarto número: ");
        num4 = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do quinto número: ");
        num5 = double.Parse(Console.ReadLine());

        double soma = num1 + num2 + num3 + num4 + num5;

        Console.WriteLine($"Os números digitados foram {num1}, {num2}, {num3}, {num4}, {num5}, e sua soma é igual a {soma}.");
    }
}

//Entrar com quatro números e imprimir a média ponderada, sabendo-se que os pesos são respectivamente 1, 2, 3 e 4.

using System;

namespace Exercicio13;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro número: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.Write("Digite o quarto número: ");
        double num4 = double.Parse(Console.ReadLine());

        double peso1 = 1;
        double peso2 = 2;
        double peso3 = 3;
        double peso4 = 4;
        double mediaPonderada = (num1 * peso1 + num2 * peso2 + num3 * peso3 + num4 * peso4) / (peso1 + peso2 + peso3 + peso4);

        Console.WriteLine("A média ponderada dos números digitados é igual a " + mediaPonderada + ".");
    }
}

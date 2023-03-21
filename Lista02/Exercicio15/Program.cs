/*
Entrar com os lados A, B e C de um paralelepípedo. Calcular e imprimir o volume.
Volume = A * B * C
*/

using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da altura do paralelepípedo: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da largura do paralelepípedo: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do comprimento do paralelepípedo: ");
            double comprimento = double.Parse(Console.ReadLine());
            double volume = altura * largura * comprimento;
            Console.WriteLine("O volume do paralelepípedo é igual a: " + volume);
        }
    }
}

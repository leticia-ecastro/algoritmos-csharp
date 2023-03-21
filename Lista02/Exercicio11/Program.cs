// Crie um Algoritmo que receba um número e imprima seu valor elevado a 2, elevado a 3, elevado a 4 e elevado a 5.
// SAÍDA:
// O número digitado foi ... E seu valor elevado a 2 é ..., elevado a 3 é ..., ...

using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            double raizQuadrada = Math.Pow(numero,2);
            double raizCubica = Math.Pow(numero,3);
            double raizQuarta = Math.Pow(numero,4);
            double raizQuinta = Math.Pow(numero,5);
            Console.WriteLine("O número digitado foi: " + numero + ".\nSeu valor elevado ao quadrado é: " + raizQuadrada + ".\nSeu valor elevado ao cubo é: " + raizCubica + ".\nSeu valor elevado à quarta é: " + raizQuarta + ".\nSeu valor elevado à quinta é: " + raizQuinta + ".");
        }
    }
}

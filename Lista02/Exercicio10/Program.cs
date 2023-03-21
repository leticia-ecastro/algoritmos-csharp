//Crie um Algoritmo que receba um número e imprima sua raiz quadrada.

using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            double raiz = Math.Sqrt(numero);
            Console.WriteLine("O número digitado foi " + numero + " e sua raiz quadrada é igual a " + raiz + ".");
        }
    }
}

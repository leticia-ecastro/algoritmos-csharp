// Crie um Algoritmo que receba um número e imprima sua raiz quadrada e sua raiz cúbica.
// SAÍDA:
// O número digitado foi ...
// Sua raiz cúbica é ...
// Sua raiz quadrada é ...

using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            double quadrada = Math.Sqrt(numero);
            double cubica = Math.Cbrt(numero);
            Console.WriteLine("O número digitado foi :" + numero + ".\nSua raiz quadrada é igual a " + quadrada + ".\nSua raiz cúbica é igual a " + cubica + ".");
        }
    }
}

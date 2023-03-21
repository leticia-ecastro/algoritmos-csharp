/*
Ler um número inteiro e imprimir seu antecessor e seu sucessor. 
SAÍDA: "O número digitado foi ..., seu antecessor é ... e seu sucessor é ..."
*/

using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, antecessor, sucessor;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            antecessor = numero - 1;
            sucessor = numero + 1;
            Console.WriteLine("O número digitado foi: " + numero + "\nSeu antecessor é " + antecessor + "\nSeu sucessor é " + sucessor + ".");
        }
    }
}
//Crie um algoritmo que leia dois nomes e imprima os nomes na sequência em que foram escritos e posteriormente os imprima na ordem inversa.
using System;

namespace Exercicio03;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro nome: ");
        string nome1 = Console.ReadLine();
        Console.Write("Digite o segundo nome: ");
        string nome2 = Console.ReadLine();

        Console.WriteLine("Nome completo " + nome1 + nome2 + "\nOrdem inversa: " + nome1 + nome2);
    }
}
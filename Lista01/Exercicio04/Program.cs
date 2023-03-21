// Crie um algoritmo que receba duas variáveis do tipo inteiro.
// Atribuir um valor para cada variável e posteriormente exibir este valor.
// Para finalizar, exibir a primeira variável acrescida de uma unidade e exibir a segunda variável decrescida de uma unidade.

using System;

namespace Exercicio04;
class Program
{
    static void Main(string[] args)
    {
        int numero1 = 5, numero2 = 10;
        Console.WriteLine("Variável 1 = " + numero1 + "\nVariável 2 = " + numero2);
        int novoNumero1 = numero1 + 1;
        int novoNumero2 = numero2 - 1;
        Console.WriteLine("Novo valor atribuído à variável 1 = " + novoNumero1 + "\nNovo valor atribuído à variável 2 = " + novoNumero2);
    }
}

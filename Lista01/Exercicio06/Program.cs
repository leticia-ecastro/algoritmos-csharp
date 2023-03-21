// Ler dois números e exibir as seguintes mensagens:
// O números digitados foram ... e .... .
// A soma dos números ... e ... é ... .
// A subtração dos números ... e ... é ... .
// A multiplicação dos números ... e ... é ... .
// A divisão dos números ... e ... é ... .
// A média dos números ... e ... é ... .

using System;

namespace Exercicio06;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int num2 = int.Parse(Console.ReadLine());

        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = num1 / num2;
        double media = soma / 2;

        Console.WriteLine("Os números digitados foram: " + num1 + " e " + num2);
        Console.WriteLine("A soma dos números " + num1 + " e " + num2 + " é igual a " + soma);
        Console.WriteLine("A subtração dos números " + num1 + " e " + num2 + " é igual a " + subtracao);
        Console.WriteLine("A multiplicação dos números " + num1 + " e " + num2 + " é igual a " + multiplicacao);
        Console.WriteLine("A divisão dos números " + num1 + " e " + num2 + " é igual a " + divisao);
        Console.WriteLine("A média dos números " + num1 + " e " + num2 + " é igual a " + media);
    }
}

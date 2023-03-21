/*
Crie um algoritmo que possa calcular a área de uma coroa de forma circular.
Área da circunferência = PI * raio^2
Área da Coroa Cirular = (Área da circunferência Maior) – (Área da circunferência menor)
*/

using System;

namespace Exercicio18 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio da circunferência menor: ");
            double raioMenor = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do raio da circunferência maior: ");
            double raioMaior = double.Parse(Console.ReadLine());
            double areaMenor = Math.PI * Math.Pow(raioMenor, 2);
            double areaMaior = Math.PI * Math.Pow(raioMaior, 2);
            double areaCoroa = areaMaior - areaMenor;

            Console.WriteLine("A coroa circular tem área igual a " + areaCoroa + ".");
        }
    }
}

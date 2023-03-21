//Elabore um algoritmo para calcular o volume e a área de uma esfera.

using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());
            //Área da Esfera: 4 * PI * r²
            double area = 4 * Math.PI * Math.Pow(raio, 2);
            //Volume da Esfera: (4/3) * PI * r³
            double volume = 4 / 3 * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine("A esfera de raio " + raio + " tem área igual a " + area + " e volume igual a " + volume + ".");
        }
    }
}

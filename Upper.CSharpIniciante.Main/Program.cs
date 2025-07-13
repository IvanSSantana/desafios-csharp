using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.CSharpIniciante.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desafio 1 (Soma dos números de 1 a 10 com loop for)
            /* short totalSum = 0;

            for (short i = 0; i <= 10; i++)
            {
                totalSum += i;
            }

            Console.Write($"Total sum by 0 to 10 is: {totalSum}"); */

            // Desafio 2
            Console.Write("Digite o seu peso (kg): ");
            var weight = Convert.ToDouble(Console.ReadLine().Replace(".",","));

            Console.Write("Digite sua altura (m): ");
            var height = Convert.ToDouble(Console.ReadLine().Replace(".",","));

            double imc = weight / (height * height);

            if (imc < 18.5)
            {
                Console.Write("Você está abaixo do peso.");
            } else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.Write("Você está no peso ideal!");
            } else if (imc >= 25 && imc <= 29.9)
            {
                Console.Write("Você está com sobrepeso.");
            } else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.Write("Você se encontra com obesidade grau 1.");
            } else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.Write("Você se encontra com obesidade grau 2.");
            } else
            {
                Console.Write("Você se encontra com obesidade grau 3.");
            }
        }
    }
}
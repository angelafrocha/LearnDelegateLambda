using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLambda
{
    public static class Utilities
    {
        public static int LerNumeroInteiro(string prompt, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int numero;
            bool numValido = false;

            do
            {
                Console.Write($"{prompt}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero >= minValue && numero <= maxValue)
                {
                    numValido = true;
                }
                else
                {
                    Console.WriteLine($"Você não digitou um número válido no intervalo de {minValue} a {maxValue}. Por favor, tente novamente.");
                }
            } while (!numValido);

            return numero;
        }

        public static decimal LerPreco(string prompt, decimal minValue = decimal.MinValue)
        {
            decimal numero;
            bool numValido = false;

            do
            {
                Console.Write($"{prompt}: ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out numero) && numero >= minValue)
                {
                    numValido = true;
                }
                else
                {
                    Console.WriteLine($"O preço deve ser maior do que {minValue}. Por favor, tente novamente.");
                }
            } while (!numValido);

            return numero;
        }

        public static string LerString(string prompt)
        {
            string input;
            bool entradaValida = false;

            do
            {
                Console.Write($"{prompt}: ");
                input = Console.ReadLine();

                entradaValida = !string.IsNullOrWhiteSpace(input);

                if (!entradaValida)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um texto não vazio.");
                }
            } while (!entradaValida);

            return input;
        }
    }
}

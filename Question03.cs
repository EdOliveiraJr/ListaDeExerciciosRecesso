using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosRecesso
{
    internal static class Question03
    {
        private static long CalcFatorial(int value)
        {
            if (value == 0 || value == 1)
            {
                return 1;
            }
            else
            {
                return value * CalcFatorial(value - 1);
            }
        }

        public static void Show()
        {
            Console.Write("Descubra o Fatorial\n" +
                "Digite um número inteiro positivo: \n");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Por favor, insira um número inteiro positivo.");
            }
            else
            {
                long fatorial = CalcFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}\n");
            }
        }
    }

}

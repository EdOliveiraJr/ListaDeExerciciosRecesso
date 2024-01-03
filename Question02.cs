using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosRecesso
{
    internal static class Question02
    {
        private static bool VerificaNumeroPrimoLINQ(int numero)
        {
            bool ePrimo = Enumerable.Range(2, (int)Math.Sqrt(numero) - 1)
                         .All(divisor => numero % divisor != 0);

            return ePrimo;
        }

        internal static void Show()
        {
            Console.WriteLine("Digite o número que deseja verificar se é Primo:\n");

            var value = Convert.ToInt16(Console.ReadLine());

            if (VerificaNumeroPrimoLINQ(value))
                Console.WriteLine($"O número {value} é primo\n");
            else
                Console.WriteLine($"O número {value} não é primo\n");
        }
    }
}

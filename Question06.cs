
namespace ListaDeExerciciosRecesso
{
    internal class Question06
    {
        private static double CalcularRaizQuadrada(double numero)
        {
            if (numero == 0)
            {
                return 0;
            }

            double epsilon = 0.000001; // Precisão desejada
            double inicio = 0;
            double fim = numero;
            double meio = (inicio + fim) / 2;

            while ((fim - inicio) > epsilon)
            {
                if (meio * meio > numero)
                {
                    fim = meio;
                }
                else
                {
                    inicio = meio;
                }

                meio = (inicio + fim) / 2;
            }

            return meio;
        }

        internal static void Show()
        {
            Console.Write("Digite um número para calcular a raiz quadrada: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            else
            {
                double raizQuadrada = CalcularRaizQuadrada(numero);
                Console.WriteLine($"A raiz quadrada de {numero} é aproximadamente {raizQuadrada:F4}");
            }
        }


    }
}

namespace ListaDeExerciciosRecesso
{
    internal class Question07
    {
        private static double ConvertToDollar(double real, double cotacao_dolar)
        {
            return real / cotacao_dolar;
        }

        internal static void Show()
        {
            Console.WriteLine("Digite o valor em Reais que deseja converter para Dolares: \n");
            var real = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da cotação atual do Dolar: \n");
            var cotacao_dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor R${real} equivale a U${ConvertToDollar(real, cotacao_dolar):F2}.");
            
        }
    }
}
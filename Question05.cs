

namespace ListaDeExerciciosRecesso
{
    internal class Question05
    {
        private static bool EhPalindromo(string? str)
        {
            str = str.Replace(" ", "").ToLower();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }

            return true;
        }

        internal static void Show()
        {
            Console.Write("Digite uma palavra: \n");
            string palavra = Console.ReadLine();

            if (EhPalindromo(palavra))
            {
                Console.WriteLine($"A palavra {palavra} é um palíndromo.\n");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} não é um palíndromo.\n");
            }
        }

    }
}

namespace ListaDeExerciciosRecesso
{
    internal class Question10
    {
        private static Dictionary<string, int> AnalisarFrequenciaPalavras(string texto)
        {
            string[] palavras = texto.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequenciaPalavras = new Dictionary<string, int>();

            foreach (string palavra in palavras)
            {
                string palavraFormatada = palavra.ToLower(); 
                if (frequenciaPalavras.ContainsKey(palavraFormatada))
                {
                    frequenciaPalavras[palavraFormatada]++;
                }
                else
                {
                    frequenciaPalavras[palavraFormatada] = 1;
                }
            }

            return frequenciaPalavras;
        }
        internal static void Show()
        {
            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine();

            Dictionary<string, int> frequenciaPalavras = AnalisarFrequenciaPalavras(texto);

            Console.WriteLine("\nFrequência de palavras no texto:");
            foreach (var par in frequenciaPalavras)
            {
                Console.WriteLine($"{par.Key}: {par.Value} vezes");
            }
        }
    }
}

namespace ListaDeExerciciosRecesso
{
    internal class Question08
    {
        static bool ValidarSenha(string senha)
        {
            return senha.Length >= 8 && ContemLetraMaiuscula(senha) && ContemLetraMinuscula(senha) && ContemNumero(senha);
        }

        static bool ContemLetraMaiuscula(string senha)
        {
            foreach (char caractere in senha)
            {
                if (char.IsUpper(caractere))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContemLetraMinuscula(string senha)
        {
            foreach (char caractere in senha)
            {
                if (char.IsLower(caractere))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContemNumero(string senha)
        {
            foreach (char caractere in senha)
            {
                if (char.IsDigit(caractere))
                {
                    return true;
                }
            }
            return false;
        }
        internal static void Show()
        {
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (ValidarSenha(senha))
            {
                Console.WriteLine("Senha válida!");
            }
            else
            {
                Console.WriteLine("Senha inválida.\n Certifique-se de que a senha tenha: \n- pelo menos 8 caracteres, \n- contenha pelo menos uma letra maiúscula, \n- uma letra minúscula \n- e um número.");
            }
        }


    }
}
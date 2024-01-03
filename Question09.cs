
namespace ListaDeExerciciosRecesso
{
    internal class Question09
    {
        public static bool ValidaCPF(string cpf)
        {
            cpf = new string(cpf.ToCharArray().Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
            {
                return false;
            }

            if (new string(cpf[0], cpf.Length) == cpf)
            {
                return false;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int resto = soma % 11;
            int digitoVerificador1 = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != digitoVerificador1)
            {
                return false;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }

            resto = soma % 11;
            int digitoVerificador2 = (resto < 2) ? 0 : 11 - resto;

            return int.Parse(cpf[10].ToString()) == digitoVerificador2;

        }

        internal static void Show()
        {
            Console.WriteLine("Digite o número de CPF que deseja validar: \n");
            string cpf = Console.ReadLine();

            if (ValidaCPF(cpf))
            {
                Console.WriteLine($"O CPF {cpf} é válido!");
            }
            else
            {
                Console.WriteLine($"O CPF {cpf} não é válido!");
            }
        }
    }
}
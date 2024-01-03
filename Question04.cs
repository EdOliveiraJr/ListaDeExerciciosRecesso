
using System.Numerics;

namespace ListaDeExerciciosRecesso
{
    internal static class Question04
    {
        internal static void Show()
        {
            Console.WriteLine("Digite o tamanho do Array que deseja ordenar: \n");
            var tamanho = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[tamanho];
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Digite um número para incluir no Array: \n");
                arr[i] = (Convert.ToInt16(Console.ReadLine()));
            }

           Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.Write( item + " ");
            }

        }
    }
}
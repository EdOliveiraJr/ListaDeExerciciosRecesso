using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosRecesso
{
    internal static class Question01
    {
        private static float ConvertToCelsius(float value)
        {
            return (float)((value-32)/1.8);
        }

        private static float ConvertToFahrenheit(float value)
        {
            return (float)((value * 1.8) + 32);
        }
        public static void Show()
        {

            Console.WriteLine("Escolha a opreção que deseja realizar ( 1 ou 2 ):\n" +
                "1 - Converter de Celsius para Fahrenheit\n" +
                "2 - Converter de Fahrenheit para Celsius\n");

            
            var operation = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Digite o valor que deseja converter:\n");

            var value = Convert.ToInt16(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"O valor {value}°C equivale a {ConvertToFahrenheit(value)}°F\n");
                    break;
                case 2:
                    Console.WriteLine($"O valor {value}°F equivale a {ConvertToCelsius(value)}°C\n");
                    break;
                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            } 
        }
    }
}

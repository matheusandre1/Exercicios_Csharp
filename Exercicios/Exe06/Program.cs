using System;

namespace exe06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Temperatura em °C: ");
            float celsius = float.Parse(Console.ReadLine());

            float conversao = (9 * celsius + 160) / 5;

            Console.WriteLine($"Conversão em °F : {conversao}");
          
        }
    }
}
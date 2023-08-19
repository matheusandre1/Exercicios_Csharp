using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
     class Temperatura
    {
        public float Celsius { get; set; }

        public float F { get; set; }

        public void Conversao()
        {
            Celsius = (F - 32) * 5 / 9;
        }
        public void Exibir()
        {
            Console.Write("Digite a Temperatura em °Fahrenheit:");
            F = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Conversao();

            Console.WriteLine($"A Temperatura convertida:{Celsius.ToString("F2",CultureInfo.InvariantCulture)}°C");
            Console.ReadKey();


        }
    }
}

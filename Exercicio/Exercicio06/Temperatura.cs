using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio06
{
     class Temperatura
    {
        

        public  float  Celsius { get; set; }

        public  float F { get; set; }

        public void Conversao()
        {
            F = (9 * Celsius + 160) / 5;
        }

        public void Exibir()
        {
            Console.Write("Digite a Temperatura em °C:");
            Celsius = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Conversao();

            Console.WriteLine();
            Console.WriteLine($"A Temperatura Convertida para Fahrenheit é: {F}°F ");
        }
    }
}

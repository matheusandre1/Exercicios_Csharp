using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Volume
    {
        double volume;
        public double Raio { get; set; }
        public double Altura { get; set; }


        public double CalculoVolume()
        {
            return volume = 3.14159 * Raio * Raio * Altura;
        }

        public void Exibir()
        {
            Console.Write("Insira o Valor Do Raio: ");
            Raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Insira a Altura: ");
            Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            CalculoVolume();

            Console.WriteLine($"O volume da Lata é : {volume.ToString("F2")}");
            Console.ReadKey();
        }
    }


}

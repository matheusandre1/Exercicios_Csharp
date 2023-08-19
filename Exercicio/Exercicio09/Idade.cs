using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Idade
    {
        public int idadetotal { get; set; }
        public int Anos { get; set; }

        public int Meses { get; set; }
        public int Dias { get; set;}

        public void CalculoIDADETOTAL()
        {
            idadetotal = (Dias + (Anos + 365) + (Meses * 30));
        }

        public void Exibir()
        {
            Console.Write("Idade em Anos: ");
            Anos = int.Parse(Console.ReadLine());

            Console.Write("Idade em Meses");
            Meses = int.Parse(Console.ReadLine());

            Console.Write("Idade em Dias");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sua idade expressa  em dias é : {idadetotal} Dias.");
            Console.ReadKey();
        }
    }
}

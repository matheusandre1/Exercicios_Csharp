using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio05
{
    class Viagem
    {
        double LitrosUsados;
        public double Distancia { get; set; }

        public double TempoGasto { get; set; }
        public double VelocidadeMedia { get; set; }


        public void CalculodeLitrosGastos()
        {
            Console.WriteLine("Digite o Gasto na viagem (em horas)");
            TempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média :");

            VelocidadeMedia = double.Parse(Console.ReadLine());

            Distancia = VelocidadeMedia * TempoGasto;

            LitrosUsados = Distancia / 12;

            Console.WriteLine("\nResultados da Viagem:");
            Console.WriteLine("Velocidade Média: {0} km/h", VelocidadeMedia);
            Console.WriteLine("Tempo Gasto: {0} horas", TempoGasto);
            Console.WriteLine("Distância Percorrida: {0} km", Distancia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Litros Utilizados: {0} litros", LitrosUsados.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

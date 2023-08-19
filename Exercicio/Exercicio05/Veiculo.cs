using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Veiculo
    {
        public float Tempo { get; set; }

        public float vKM { get; set; }

        public double Distancia { get; set; }

        public double LitroUsado { get; set; }


        public void Exibicao()
        {
            Console.Write("Digite o tempo da viagem: ");
            Tempo = float.Parse(Console.ReadLine());

            Console.Write("Velocidade Média do Percurso: ");
            vKM = float.Parse(Console.ReadLine());
            CalculoDistancia();
            LitroUsado = Distancia / 12;
            
            Console.WriteLine($"Tempo de viagem: {Tempo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Velocidde media: + {vKM.ToString("F2",CultureInfo.InvariantCulture)} + Km/h");
            Console.WriteLine($"Distancia percorrida: {Distancia.ToString("F2",CultureInfo.InvariantCulture)} Km");
            Console.WriteLine($"Quantidade de combustiuel gasto: {LitroUsado.ToString("F2",CultureInfo.InvariantCulture)}l");

            Console.ReadKey();
        }

        public void CalculoDistancia()
        {
            Distancia = Tempo * vKM;            

        }
        

        
    }
}

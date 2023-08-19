using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Numeros
    {
        public int NumA { get; set; }
        public int NumB { get; set; }

        public int NumC { get; set; }

        public int NumD { get; set; }

        public void EntradaDeValores()
        {
            Console.Write("Entrada do Valor de A: ");
            NumA = int.Parse(Console.ReadLine());            
            Console.Write("Entrada do Valor de B: ");
            NumB = int.Parse(Console.ReadLine());
            Console.Write("Entrada do Valor de C: ");
            NumC = int.Parse(Console.ReadLine());
            Console.Write("Entrada do Valor de D: ");
            NumD = int.Parse(Console.ReadLine());


        }

        public void SomadeValores()
        {
            Console.WriteLine("A soma dos Valores São : ");
            Console.WriteLine($"{NumA} + {NumB} = {NumA + NumB}");
            Console.WriteLine($"{NumA} + {NumC} = {NumA + NumC}");
            Console.WriteLine($"{NumA} + {NumD} = {NumA + NumD}");
            Console.WriteLine();
            Console.WriteLine($"{NumB} + {NumC} = {NumB + NumC}");
            Console.WriteLine($"{NumB} + {NumD} = {NumB + NumD}");
            Console.WriteLine($"{NumC} + {NumD} = {NumC + NumD}");
        }

        public void MultiplicacaodosValores()
        {
            Console.WriteLine("Multiplicação Dos valores são : ");
            Console.WriteLine();
            Console.WriteLine($"{NumA} x {NumB} = {NumA * NumB}");
            Console.WriteLine($"{NumA} x {NumC} = {NumA * NumC}");
            Console.WriteLine($"{NumA} x {NumD} = {NumA * NumD}");
            Console.WriteLine();
            Console.WriteLine($"{NumB} x {NumC} = {NumB * NumC}");
            Console.WriteLine($"{NumB} x {NumD} = {NumB * NumD}");
            Console.WriteLine($"{NumC} x {NumD} = {NumC * NumD}");

        }
    }
}

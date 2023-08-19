using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    internal class Numeros
    {
        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public int multiplicar { get; set; }

        public int dividir { get; set; }

        public void Exibicao()
        {
            Console.Write("Primeiro Valor: ");
            A = int.Parse(Console.ReadLine());
            ValidacaoNumero();
            Console.Write("Segundo Valor: ");
            B = int.Parse(Console.ReadLine());
            ValidacaoNumero();
            Console.Write("Terceiro Valor: ");
            C = int.Parse(Console.ReadLine());
            ValidacaoNumero();
            ExecucaodasOperacoes();


        }

        public void ValidacaoNumero()
        {
            if (A <= 0)
            {
                Console.WriteLine("Valor Inválido");

            }
            if (B <= 0)
            {
                Console.WriteLine("Valor Inválido");
            }

            if (C <= 0)
            {
                Console.WriteLine("Valor Inválido");
            }
        }

        public void ExecucaodasOperacoes()
        {
            if (A >= B && B >= C)
            {
                multiplicar = C * A;
                dividir = A * C;
                Console.WriteLine($"Multiplicação: {multiplicar}");
                Console.WriteLine($"Divisão: {dividir}");
            }
            if (A <= B && B <= C)
            {
                multiplicar = A * C;
                dividir = C / A;
                Console.WriteLine($"Multiplicação: {multiplicar}");
                Console.WriteLine($"Divisão: {dividir}");
            }
            if (B <= A && A <= C)
            {
                multiplicar = B * C;
                dividir = C / B;
                Console.WriteLine($"A multiplicação é: {multiplicar}");
                Console.WriteLine($"A divisão é: {dividir}");
            }
            if (A <= C && C <= B)
            {
                multiplicar = A * B;
                dividir = B / A;
                Console.WriteLine($"A multiplicação é: {multiplicar}");
                Console.WriteLine($"A divisão é: {dividir}");
            }

            if (B <= C && C <= A)
            {
                multiplicar = B * A;
                dividir = A / B;
                Console.WriteLine($"A multiplicação é: {multiplicar}");
                Console.WriteLine($"A divisão é: {dividir}");


            }

            if (C <= A && A <= B)
            {
                multiplicar = C * B;
                dividir = B / C;
                Console.WriteLine($"A multiplicação é: {multiplicar}");
                Console.WriteLine($"A divisão é: {dividir}");
            }

        }
    }
}

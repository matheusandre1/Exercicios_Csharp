using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    class NumInt
    {
        public double Num1 { get; set; }

        public double Num2 { get; set; }

        public int Opcao { get; set; }


        public void Exibicao()
        {
            while (true)
            {
                EntradaDeDados();
                ExibirOpcoesdaTela();
                VerificarOpcoes();

            }


        }

        public void EntradaDeDados()
        {
            Console.Write("Insira o Primeiro Valor: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o Segundo Valor: ");
            Num2 = double.Parse(Console.ReadLine());


        }

        public void ExibirOpcoesdaTela()
        {
            Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 – Verificar se os dois números lidos são pares");
            Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7.");
            Console.WriteLine("4 – Sair");

            Console.Write("Qual Opção: ");
            Opcao = int.Parse(Console.ReadLine());
            
        }

        public void VerificarOpcoes()
        {
            switch (Opcao)
            {
                case 1:
                    if (Num1 % Num2 == 0 || Num2 % Num1 == 0)
                    {
                        Console.WriteLine("Os numeros inseridos são multiplos!");
                    }
                    else
                    {
                        Console.WriteLine("Os numeros inseridos não são multiplos!");
                        
                    }
                    break;

                case 2:
                    if (Num1 % 2 == 0 || Num2 % 2 == 0)
                    {
                        Console.WriteLine("Numeros Pares!");
                    }
                    else
                    {
                        Console.WriteLine("Não São Pares");
                    }
                    break;
                case 3:
                    if ((Num1 + Num2) / 2 > 7)
                    {
                        Console.WriteLine("Média Maior que 7");
                    }
                    else
                    {
                        Console.WriteLine("Média Menor que 7");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

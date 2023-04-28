using System;
using Exercicio01;

Peca peca1 = new Peca();

Console.WriteLine("Digite a Quantidade Minima: ");
peca1.QuantidadeMinima = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Quantidade Maxima: ");
peca1.QuantidaMaxima = int.Parse(Console.ReadLine());

int resultado = peca1.EstoqueMedio();

Console.WriteLine("A Quantidade de Estoque medio é :" + resultado);
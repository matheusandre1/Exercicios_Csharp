using System;
using Exercicio04;

CalculaNumero calculaNumero = new CalculaNumero();

int a, b, c, d;

Console.Write("Digite o valor de A: ");
a = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de B: ");
b = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de C: ");
c = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de D: ");
d = int.Parse(Console.ReadLine());

calculaNumero.Calcular(a, b, c, d);
using System;
using Exercicio03;

Vendedor vendedor = new Vendedor();

Console.WriteLine("Vendedor, Insira Seu Nome Completo: ");
vendedor.NomeVendedor = Console.ReadLine();

Console.WriteLine("Código Do Produto: ");
vendedor.CodProduto = int.Parse(Console.ReadLine());

Console.WriteLine("Preco Unitário: ");
vendedor.Preco = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade Vendida: ");
vendedor.QuantidadeVendida = int.Parse(Console.ReadLine());

double vendatotal =vendedor.CalcularVenda();
double comissao =vendedor.CalcularComissao();


Console.WriteLine($"Nome:{vendedor.NomeVendedor}");
Console.WriteLine($"Codigo Do Produto: {vendedor.CodProduto}");
Console.WriteLine($"Preco Unitário:{vendedor.Preco}");
Console.WriteLine($"Quantidade Vendida: {vendedor.QuantidadeVendida}");
Console.WriteLine($"Venda Feita : {vendatotal} e o Valor da Comissão é : {comissao}");



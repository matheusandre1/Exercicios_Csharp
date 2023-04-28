using System;
using System.Globalization;
using Exercicio02;

CotaDolar converter = new CotaDolar();

Console.Write("Digite O Dolar a ser convertido:" );
converter.Dolar = Double.Parse(Console.ReadLine());

converter.Cotacao = 5.32;
double resultado =converter.ConverterPraReal();

Console.WriteLine($"O Valor Em Dolar de {converter.Dolar} é de: {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
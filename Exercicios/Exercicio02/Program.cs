using System;
using System.Globalization;
using Exercicio02;

CotaDolar converter = new CotaDolar();

converter.Dolar = Double.Parse(Console.ReadLine());

converter.Cotacao = 5.32;
double resultado =converter.ConverterPraReal();

Console.WriteLine($"O Valor Em Dolar de {converter.Dolar} é de: {resultado}");
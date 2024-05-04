using Exe04;

namespace Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor para A:");
            double numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para B:");
            double numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para C:");
            double numC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para D:");
            double numD = Convert.ToInt32(Console.ReadLine());
            
            Parte soma = new Parte();
            soma.Soma(numA, numB, numC, numD);
            Console.WriteLine();
            soma.Multiplicar(numA, numB, numC, numD);
        }

       
    }
}
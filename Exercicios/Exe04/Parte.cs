using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe04;
public  class Parte
{
    

    public double NumA { get; set; }
    public double NumB { get; set; }
    public double NumC { get; set; }
    public double NumD { get; set; }


    public void Soma(double numA, double numB, double numC, double numD)
    {
        Console.WriteLine("A soma dos valores é:");
        Console.WriteLine($"A + B= {numA + numB}");
        Console.WriteLine($"A + C= {numA + numC}");
        Console.WriteLine($"A + D= {numA + numD}");

        Console.WriteLine($"B + C= {numB + numC}");
        Console.WriteLine($"B + D= {numB + numD}");
        Console.WriteLine($"C + D= {numC + numD}");
    }

    public void Multiplicar(double numA, double numB, double numC, double numD) 
    {
        Console.WriteLine("A multiplicação dos valores é:");
        Console.WriteLine($"A X B= {numA * numB}");
        Console.WriteLine($"A X C= {numA * numC}");
        Console.WriteLine($"A X D= {numA * numD}");

        Console.WriteLine($"B X C= {numB * numC}");
        Console.WriteLine($"B X D= {numB * numD}");
        Console.WriteLine($"C X D= {numC * numD}");
    }

}


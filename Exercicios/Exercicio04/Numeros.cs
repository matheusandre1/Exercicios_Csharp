using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class CalculaNumero
    {

        public void Calcular(int a,int b,int c,int d)
        {
            int ab = a + b;
            int ac = a + c;
            int ad = a + d;
            int bc = b + c;
            int bd = b + d;
            int cd = c + d;

            Console.WriteLine("Resultado das adições:");
            Console.WriteLine("{0} + {1} = {2}", a, b, ab);
            Console.WriteLine("{0} + {1} = {2}", a, c, ac);
            Console.WriteLine("{0} + {1} = {2}", a, d, ad);
            Console.WriteLine("{0} + {1} = {2}", b, c, bc);
            Console.WriteLine("{0} + {1} = {2}", b, d, bd);
            Console.WriteLine("{0} + {1} = {2}", c, d, cd);

            int ab_mul = a * b + b * a;
            int ac_mul = a * c + c * a;
            int ad_mul = a * d + d * a;
            int bc_mul = b * c + c * b;
            int bd_mul = b * d + d * b;
            int cd_mul = c * d + d * c;

            Console.WriteLine("Resultado das multiplicações:");
            Console.WriteLine("{0} * {1} + {1} * {0} = {2}", a, b, ab_mul);
            Console.WriteLine("{0} * {1} + {1} * {0} = {2}", a, c, ac_mul);
            Console.WriteLine("{0} * {1} + {1} * {0} = {2}", a, d, ad_mul);
            Console.WriteLine("{0} * {1} + {1} * {0} = {2}", b, c, bc_mul);
            Console.WriteLine("{0} * {1} + {1} * {0} = {2}", b, d, bd_mul);
            Console.WriteLine("{0} * {1} + {1} * {0} = {2}", c, d, cd_mul);
        }
    }
}

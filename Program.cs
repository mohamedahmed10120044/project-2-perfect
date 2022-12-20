using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2_perfectn
{
    internal class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("enter the n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n2");
            int n2 = int.Parse(Console.ReadLine());
            for(int a = n1; a <= n2; a++)
            {
                int x = 0;
                for (int b = 1; b < a; b++)
                    if (a % b == 0)
                        x += b;
                if (a == x)
                    Console.WriteLine(a + "  ");

                

            }

            Console.ReadKey();
        }
    }
}

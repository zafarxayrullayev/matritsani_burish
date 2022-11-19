using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matritsa_burish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n  = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Siz matritsani necha gradusga burmoqchisiz!\n1 --> 180 gradus, 2 --> 90 gradus");
            
        }
    }
}

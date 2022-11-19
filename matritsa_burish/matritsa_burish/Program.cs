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
            int[,] matrix = new int[n, n], hosil = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Siz matritsani necha gradusga burmoqchisiz!\n1 --> 180 gradus, 2 --> 90 gradus");
            int nechaGradus, burishTanla;
            nechaGradus = Convert.ToInt32(Console.ReadLine());  
            switch (nechaGradus)
            {
                case 1:
                    Console.WriteLine("180 gradus tanlandi.");
                    Console.WriteLine("Matritsani o'ngga burganda ham, chapga burganda ham bir xil bo'lib qoladi.");
                    for (int i = 0, k = n - 1; i < n; i++, k--)
                    {
                        for (int j = 0, d = n - 1; j < n; j++, d--)
                        {
                            hosil[i, j] = matrix[k,d];
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("90 gradusga burish tanlandi!");
                    Console.WriteLine("Matritsani o'nga burmoqchimisiz, chapgami\n1 --> o'ng, 2 --> chap");
                    burishTanla = Convert.ToInt32(Console.ReadLine());
                    switch (burishTanla)
                    {
                        case 1:
                            Console.WriteLine("O'ngga burish tanlandi!");
                            for (int i = 0, k = 0; i < n; i++, k++)
                            {
                                for (int j = 0, d = n - 1; j < n; j++, d--)
                                {
                                    hosil[i, j] = matrix[d, k];
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Chapga burish tanladi!");
                            for (int i = 0, k = n - 1; i < n; i++, k--)
                            {
                                for (int j = 0, d = 0; j < n; j++, d++)
                                {
                                    hosil[i, j] = matrix[d, k];
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{hosil[i, j]} ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

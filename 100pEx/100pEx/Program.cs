using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100pEx
{


    class Program
    {
        static void Main(string[] args)
        {
            int[][] a =
            {
                new int[]{1,2},
                new int[]{1,2,3},
                new int[]{1,2,3,4 }
            };

            int[,] b = {
             {1,2},
             {3,4},
             {5,6 }

            };

            foreach (int[] arr in a)
            {
                foreach (int j in arr)
                {
                    Console.Write(j + " ");
                }

            }
            Console.WriteLine("\n---------------\n");

            foreach (int i in b)
            {
                Console.Write(i + " ");
            }






        }
    }
}

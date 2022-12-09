using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*8. В массиве из 2n чисел найти сумму квадратов элементов 
    с четными индексами и сумму кубов элементов 
    с нечетными индексами. */

namespace Lab_4_1_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] arr = new int[2 * n];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(10);
                Console.Write(arr[i] + " ");
            }                
            Console.WriteLine();

            int sum_even = 0;
            int sum_odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {                
                if (i % 2 ==  0)
                    sum_even += arr[i] * arr[i];
                if (i % 2 != 0)
                    sum_odd += arr[i] * arr[i] * arr[i];
            }            

            Console.WriteLine(sum_even);
            Console.WriteLine(sum_odd);

            // Linq
            Console.WriteLine("^2: " + arr.Where((x, i) => i % 2 == 0).Select(x => x * x).Sum());
            Console.WriteLine("^3: " + arr.Where((x, i) => i % 2 != 0).Select(x => x * x * x).Sum());

            Console.ReadKey();
        }
    }
}

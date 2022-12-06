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
            int n = 10;
            int[] arr = new int[2 * n];
            Random r = new Random();

            int sum_even = 0;
            int sum_odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(50);
                if (i % 2 ==  0)
                    sum_even += arr[i];
                if (i % 2 != 0)
                    sum_odd += arr[i];                
            }

            foreach (var item in arr)            
                Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine(sum_even);
            Console.WriteLine(sum_odd);
            Console.ReadKey();
        }
    }
}

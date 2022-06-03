using System;

namespace LabDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n və m ədədləri arasında 7-ə və 3-ə bölünən ədədlərin tapılması.
            /* int n = 10;
             int m = 80;
             int sum = 0;
             for (int i = n; i < m; i++)
             {
                 if (i % 21 == 0)
                 {
                     sum += i;
                 }
             }
             Console.WriteLine(sum);*/

            //verilmiş arrayda max və min elementlərin cəmi
           /* int[] array = { 1, 2, 3, 100, 4, 5, 6, 7, 8, 9, 10, -11, 12, 11 };
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Sum: {max + min}");*/


            //Ədədin mərtəbəlliyini tapmaq.
            /*int number = 213;
            int i = 0;
            while ((number /= 10) >= 1)
            {
                i++;
            }
            Console.WriteLine(i);*/
        }
    }
}

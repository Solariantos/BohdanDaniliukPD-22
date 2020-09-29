using System;
namespace Construct_if_else_if
{
    class Program
    {
        /*   7.	Перевірити істинність вислову:
          "Серед трьох даних цілих чисел є хоч би одна пара співпадаючих".  */
        static void Main()
        {
            int[] arr = new int[3];
            string temp = "Are there a pair of integers that are the same? - ";
      
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter the "+(j+1)+" integer number : ");
                arr[j] = int.Parse(Console.ReadLine());
            }
            if (arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2])
            {
                Console.WriteLine(temp + true);
            }
            else
            {
                Console.WriteLine(temp + false);
            }
        }
    }
}
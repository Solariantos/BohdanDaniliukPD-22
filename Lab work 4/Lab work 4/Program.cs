using System;

namespace Lab_work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter quantity of numbers in Array - ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Random rndm = new Random();
            for(int i = 0; i < size; i++)
            {
                arr[i] = rndm.Next(-10,10);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            int tempMax = arr[0];
            int tempMin = arr[0];
            for(int i = 0; i < size; i++)
            {
                if (arr[i] > tempMax)
                {
                    tempMax = arr[i];
                }
                if (arr[i] < tempMin)
                {
                    tempMin = arr[i];
                }
            }
            for(int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = tempMin;
                }
                if (arr[i] > 0)
                {
                    arr[i] = tempMax;
                }
            }
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i] +"\t");
            }

        }
    }
}

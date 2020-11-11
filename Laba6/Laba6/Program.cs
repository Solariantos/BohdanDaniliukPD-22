using System;

//конвертация без Array.reverse();
//Данилюк Богдан ПД-22
namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[]arr= {1,2,3,4,5,6,7,8,9};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

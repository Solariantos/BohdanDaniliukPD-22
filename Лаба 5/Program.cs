using System;

namespace Laba_work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter quntity of rows - ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter quntity of columns - ");
            int col = int.Parse(Console.ReadLine());
            int[,] mas = new int[row,col];
            Random rndm = new Random();
            Console.WriteLine();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rndm.Next(100); // random function is filling array;
                } 
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {

                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            int[] maxRow = new int[mas.GetLength(0)];
            int[] minRow = new int[mas.GetLength(0)];
            int[] maxCol = new int[mas.GetLength(1)];
            int[] minCol = new int[mas.GetLength(1)];

            for (int i = 0; i < mas.GetLength(0); i++)
            {   
                int tempMin = mas[i,0];
                int tempMax = mas[i,0];
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > tempMax)
                    {
                        tempMax = mas[i, j];
                    }
                    if (mas[i, j] < tempMin)
                    {
                        tempMin = mas[i, j];
                    }                 
                }
                maxRow[i] = tempMax;
                minRow[i] = tempMin;
            }
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                int tempMin = mas[0,i];
                int tempMax = mas[0,i];
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (mas[j,i] > tempMax)
                    {
                        tempMax = mas[j, i];
                    }
                    if (mas[j, i] < tempMin)
                    {
                        tempMin = mas[j, i];
                    }
                }
                maxCol[i] = tempMax;
                minCol[i] = tempMin;
            }
            Console.WriteLine("-----------------------");
            for (int i = 0; i < maxCol.Length; i++)
            {
                Console.WriteLine("Max in col ["+i+"] - "+maxCol[i]);
                Console.WriteLine("Min in col [" + i + "] - " + minCol[i]);

            }
            Console.WriteLine("-----------------------");
            for (int i = 0; i < maxRow.Length; i++)
            {
                Console.WriteLine("Max in row [" + i + "] - " + maxRow[i]);
                Console.WriteLine("Min in row [" + i + "] - " + minRow[i]);

            }
        }
    }
}

using System;


namespace Lab_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Input the high value of conе - ");
            int highValue = int.Parse(Console.ReadLine());
            Console.Write("Input the radius value of conе - ");
            int radiusValue = int.Parse(Console.ReadLine());
            double capacity = (Math.PI * highValue * Math.Pow(radiusValue,2));
            Console.WriteLine("Capacity of cone equals - " + capacity);

        }
    }
}

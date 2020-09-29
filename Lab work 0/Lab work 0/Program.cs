using System;

namespace Lab_work_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value seconds : ");
            int sec = int.Parse(Console.ReadLine());
            
            int hours = sec / 3600;
            int minutes = (sec / 60)-(hours * 60);
            sec = sec - (hours * 3600) - (minutes * 60);
     
                Console.WriteLine(" "+hours + "h : " + minutes + "m : " + sec+"s");
            
        }
    }
}

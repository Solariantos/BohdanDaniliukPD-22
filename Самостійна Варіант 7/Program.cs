using System;

namespace sr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 7 \n\n");

            var tablets = new Tablets();
            bool exist = true;

            string color;
            int yearOfMade = 0;
            int price = 0;
            int enginePower = 0;

            byte amount = 0;
            string tempForInput;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t------Магазин Планшетов------\n");
            Console.WriteLine("-Есть желание приобрести планшет,указав свои параметры?");
            
            Console.Write("Введите yes или no: ");
            Console.ForegroundColor = ConsoleColor.White;
            tempForInput = Console.ReadLine();

            if (tempForInput == "yes")
            {
                while (exist)
                {
                    amount = 0;
                    color = null;
                    tempForInput = null;

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine();
                    Console.WriteLine("\t\t-------Параметры-------\n");
               

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Введите цвет планшета: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    color = Console.ReadLine();
                    if (color == "-")
                        amount++;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Введите год производства: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else yearOfMade = Convert.ToInt32(tempForInput);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Введите цену: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else price = Convert.ToInt32(tempForInput);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Введите обьем оперативной памяти: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else enginePower = Convert.ToInt32(tempForInput);

                    tablets.findTablets(amount, color, yearOfMade, price, enginePower);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    
                  
                    Console.Write("Для выхода из программы введите (no),если выбрать новый(yes) :  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    exist = tempForInput == "yes" ? true : false;
                }
            }
            else
            {
                tablets.showInfoAboutTablets();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                exist = false;
            }

        }
    }
}

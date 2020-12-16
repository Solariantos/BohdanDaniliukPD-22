using System;
using System.Collections.Generic;

namespace sr_1
{
    class Tablet
    {
        public List<String> colors = new List<String>();
        public int yearOfMade;
        public int price;
        public int ram;

        public Tablet(string[] colors = null, int yom = 0, int price = 0, int ram = 0)
        {
            for(var i = 0; i < colors.Length; i++)
                this.colors.Add(colors[i]);
            yearOfMade = yom;
            this.price = price;
            this.ram = ram;
        }
        public void show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write($"Доступные цвета: ");
            foreach (var color in colors)
                Console.Write($" {color} ");
            Console.WriteLine();
            Console.WriteLine($"Год производства: {yearOfMade} год");
            Console.WriteLine($"Цена: {price}грн.");
            Console.WriteLine($"Обьем оперативной памяти: {ram}");
        }
    }
}
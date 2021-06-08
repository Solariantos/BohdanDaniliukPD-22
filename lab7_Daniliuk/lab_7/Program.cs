using System;
using System.Collections.Generic;

namespace lab_7
{
    class Program
    {
        private static int enterAmountListElements(){
            int size = 0;
            do{
                Console.Write("Введите количество елементов листа: ");  
                try{
                    size = int.Parse(Console.ReadLine());
                }catch{ }
                if(size <= 0)
                    Console.WriteLine($"Количество елементов листа не может быть {size}!!!");
            }while(size <= 0);
            return size;
        }
        private static List<int> CreateListWithOneOrTwoIntValue(int size)
        {
            int value = 0;
            List<int> listOfInt = new List<int>();
            for (var i = 0; i < size; i++){
                Console.Write($"Element {i + 1},Введите 1 либо 2: ");
                value = int.Parse(Console.ReadLine());
                if(value == 1 ||value == 2)
                    listOfInt.Add(value);
                else{
                    Console.WriteLine("Нельзя ввести такое значение, попробуйте еще раз!!!");  
                    i--;
                 }
            }
            return listOfInt;
        }
        private static void printListAtConsole(in List<int> listInt)
        {
            foreach(var elem in listInt)
                Console.Write($"{elem} ");
        }
        private static int countAmountOfValueInList(in List<int> listInt, int value)
        {
            int amount = 0;
            foreach (var elem in listInt)
                if (elem == value)
                    amount++; 
            return amount;
        } 
        private static bool isPtime(int n)
        {
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        return false;
                return true;
            }
            else
                return false;
        }
        private static void deleteElementsOfLIstIntWithSimplIndex(ref List<int> listInt)
        {
            for (var i = 0; i < listInt.Count; i++)
                if (isPtime(i))
                    listInt.RemoveAt(i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа к задаче 9!!");
            int sizeOfList = enterAmountListElements();
            List<int> listOfInt = CreateListWithOneOrTwoIntValue(sizeOfList);
            printListAtConsole(in listOfInt);

            Console.WriteLine();
            Console.WriteLine($"Данный лист имеет {countAmountOfValueInList(in listOfInt, 1)} елементов со значением 1.");
            Console.WriteLine($"Данный лист имеет {countAmountOfValueInList(in listOfInt, 2)} елементов со значением 2.");
            Console.WriteLine("Удаляем все елементи с простими индексами!!!");
            deleteElementsOfLIstIntWithSimplIndex(ref listOfInt);
            printListAtConsole(in listOfInt);
            Console.ReadKey();
        }
    }
}

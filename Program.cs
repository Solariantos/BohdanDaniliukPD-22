using System;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str;
            int code;

            Console.WriteLine("Выберите действие!!!");
            Console.WriteLine("0 - Отобразить число в обратном порядке");
            Console.WriteLine("1 - Отобразит строку в обратном порядке");
            Console.WriteLine("2 - Отобразить дробовое число в обратном порядке");
            Console.WriteLine("3 - Отобразит строку с магическим знаком в обратном порядке");
            Console.WriteLine("4 - Отобразить число в обратном порядке (рекурсив)");
            Console.WriteLine("5 - Отобразит строку в обратном порядке (рекурсив)");
            Console.WriteLine("6 - Отобразить дробовое число в обратном порядке (рекурсив)");
            Console.WriteLine("7 - Отобразит строку с магическим знаком в обратном порядке (рекурсив)");
            inputValue(out code, "код действия");

            switch (code)
            {
                case 0:
                    inputValue(out str, "число");
                    showStrRev(in str);
                    break;
                case 1:
                    inputValue(out str, "cтрочку");
                    showStrRev(in str);
                    break;
                case 2:
                    inputValue(out str, "число с точкою");
                    showStr(in str);
                    break;
                case 3:
                    inputValue(out str, "cтрочку с точкою");
                    showStr(in str);
                    break;
                case 4:
                    inputValue(out str, "число");
                   showStrRevRec(in str);
                    break;
                case 5:
                    inputValue(out str, "cтрочку");
                   showStrRevRec(in str);
                    break;
                case 6:
                    inputValue(out str, "число с точкою");
                    showStrSymRevRec(in str);
                    break;
                case 7:
                    inputValue(out str, "cтрочку с точкою");
                    showStr(in str);
                    break;
            }

            Console.ReadKey();
        }
        static void inputValue(out int variable, string name)
        {
            Console.Write($"Введите {name}: ");
            variable = Convert.ToInt32(Console.ReadLine());
        }
        static void inputValue(out string str, string name)
        {
            Console.Write($"Введите {name}: ");
            str = Console.ReadLine();
        }

        //task 1,2
        static void showStrRev(in string str)
        {
            for (var i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
        }
        //task 3,4
        static void showStr(in string str)
        {
            int indexSymbol = findIndex(in str, '.');
            for (var i = indexSymbol - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.Write('.');
            for (var i = str.Length - 1; i > indexSymbol; i--)
                Console.Write(str[i]);
        }
        static int findIndex(in string str, char symbol)
        {
            for (var i = 0; i < str.Length; i++)
                if (str[i] == symbol)
                    return i;
            return -1;
        }
        //task 6
        static void showStrRevRec(in string str) => Console.Write(Reverse(str));
        static void showStrSymRevRec(in string str)
        {
            string[] words = str.Split(new char[] { '.' });
            Console.Write(Reverse(words[0]));
            Console.Write('.');
            Console.Write(Reverse(words[1]));
        }
        static string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return Reverse(str.Substring(1)) + str[0].ToString();
        }

    }
}
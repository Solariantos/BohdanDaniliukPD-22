
using System;

namespace lab_10_Daniliuk_Bohdan
{
    internal class Program
    {
        private static void printInt32Array(in int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
        static void Main(string[] args)
        {
            int value = 1234567890;

            Console.WriteLine(value);
            Console.WriteLine(value.invertValue());

            string strValue = "wetewery";
            Console.WriteLine(strValue);
            Console.WriteLine(strValue.invertValue());

            string strMagicValue = "wyrywr";
            Console.WriteLine(strMagicValue);
            Console.WriteLine(strMagicValue.invertMagicValue('.'));

            double dbValue = 1234.5678;
            Console.WriteLine(dbValue);
            Console.WriteLine(dbValue.invertValue());

            int[] arrValue = { 1, 2, 3, 4, 5 };
            printInt32Array(arrValue);
            Console.WriteLine();
            printInt32Array(arrValue.invertValue());

            arrValue.pushElement(90, ref arrValue);
            Console.WriteLine();
            printInt32Array(arrValue);

            Console.ReadKey();
        }

    }
    public static class invertExtension
    {
        public static int invertValue(this int value)
        {
            char[] arr = new char[(int)(Math.Log10(value) + 1)];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)('0' + (value % 10));
                value /= 10;
            }
            return Convert.ToInt32(new string(arr));
        }
        public static string invertValue(this string value)
        {
            char[] arr = value.ToCharArray();
            char[] temp = new char[arr.Length];
            byte temp_i = 0;
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                temp[temp_i] = arr[i];
                temp_i++;
            }
            return new string(temp);
        }
        private static sbyte findIndexOfMagicSymbol(in char[] str, char magicSymbol)
        {
            for (var i = 0; i < str.Length; i++)
                if (str[i] == magicSymbol)
                    return (sbyte)i;
            return -1;
        }
        public static string invertMagicValue(this string value, char magicSymbol)
        {
            char[] arr = value.ToCharArray();
            byte indexOfMagicSymbol = (byte)(findIndexOfMagicSymbol(in arr, magicSymbol));
            char[] temp = new char[arr.Length];
            byte temp_i = 0;
            for (var i = indexOfMagicSymbol - 1; i >= 0; i--)
            {
                temp[temp_i] = arr[i];
                temp_i++;
            }
            temp[temp_i] = arr[indexOfMagicSymbol];
            temp_i++;
            for (var i = arr.Length - 1; i > indexOfMagicSymbol; i--)
            {
                temp[temp_i] = arr[i];
                temp_i++;
            }
            return new string(temp);
        }
        public static double invertValue(this double value)
        {
            return Convert.ToDouble(Convert.ToString(value).invertMagicValue(','));
        }
        public static int[] invertValue(this int[] value)
        {
            int[] temp = new int[value.Length];
            byte temp_i = 0;
            for (var i = value.Length - 1; i >= 0; i--)
            {
                temp[temp_i] = value[i];
                temp_i++;
            }
            return temp;
        }
    }
   
    public static class intArrayExtension
    {
        public static void pushElement(this int[] value, int el, ref int[] value_2)
        {
            int[] temp = new int[value.Length + 1];
            for (var i = 0; i < value.Length; i++)
                temp[i] = value[i];
            temp[value.Length] = el;
            value_2 = temp;
        }
    }
}

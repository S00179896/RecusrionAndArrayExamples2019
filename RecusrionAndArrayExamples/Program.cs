using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecusrionAndArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int factorialR(int n)
        {
            if (n == 1) return 1;
            else return (n * factorialR(n - 1));
        }

        public static int factorialL(int n)
        {
            int fact = 1;
            for (int i = n; i > 1; i--)
                fact = fact * i;
            return fact;
        }
        public static string ReverseString_Rec(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return ReverseString_Rec(str.Substring(1)) + str[0];
        }
        public static void printArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i.ToString());
            Console.WriteLine();
        }
        public static void changeValue(int[] arr, int i, int value)
        {
            if (i < arr.Length)
                arr[i] = value;
            printArray(arr);
        }


    }
}

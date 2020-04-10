using System;

namespace BinaryArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 1, 0, 1 };
            Console.WriteLine(Kata.binaryArrayToNumber(array));
        }
    }

    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int length = BinaryArray.Length;
            double sum = 0;
            int lastIndex = length - 1;
            for (int i = 0; i < length; i++, lastIndex--)
            {
                sum += BinaryArray[lastIndex] * Math.Pow(2, i);
            }
            return (int)sum;
        }
    }
}

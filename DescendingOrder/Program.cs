using System;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.DescendingOrder(837428));
            Console.ReadLine();
        }
    }

    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            string input = num.ToString();
            string output = "";

            for (int i = '9'; i >= '0'; i--)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == i)
                    {
                        output += input[j];
                    }
                }
            }
            return Convert.ToInt32(output);
        }
    }
}

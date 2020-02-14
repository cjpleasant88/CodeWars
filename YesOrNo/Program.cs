using System;

namespace YesOrNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Kata
    {
        public static string boolToWord(bool word)
        {
            string output;
            if (word)
            {
                output = "Yes";
                return output;
            }
            return "No";

        }
    }
}

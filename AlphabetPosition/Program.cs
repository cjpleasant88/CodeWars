using System;

namespace AlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
        }
    }

    public static class Kata
    {
        public static string AlphabetPosition(string text)
        {
            text = text.ToUpper();
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                int code = (int)text[i];

                if (code > 64 && code < 91)
                    result += (code - 64) + " ";
            }
            if (result.Length != 0)
            result = result.Substring(0, result.Length - 1);
            return result;
        }
    }
}

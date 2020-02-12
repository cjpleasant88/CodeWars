using System;

namespace IsSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Kata.IsSquare(-1));
            Console.WriteLine(Kata.IsSquare(3));
            Console.WriteLine(Kata.IsSquare(4));
            Console.WriteLine(Kata.IsSquare(25));
            Console.WriteLine(Kata.IsSquare(26));

        }
    }

    public class Kata
    {
        public static bool IsSquare(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("negative numbers aren't square numbers");
                return false;
            }
            for (int i = 0; (i * i) <= n; i++)
            {
                if (i * i == n)
                {
                    Console.WriteLine($"{n} is a square number");
                    return true;
                }
            }
            Console.WriteLine($"{n} isn't a square number");
            return false;
        }
    }
}

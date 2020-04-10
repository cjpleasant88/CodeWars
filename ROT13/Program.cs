using System;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test: {Kata.Rot13("Test()*")}");
            Console.WriteLine($"test: {Kata.Rot13("test")}");
            Console.WriteLine($"Test: {Kata.Rot13("ABCDEFGHIJKLMNOPQRSTUVWXYZ")}");
            Console.WriteLine($"Test: {Kata.Rot13("abcdefghijklmnopqrstuvwxyz")}");
        }
    }

    public class Kata
    {
        public static string Rot13(string message)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 'A' && message[i] <= 'Z')
                {
                    result += (char)(((message[i] - 65 + 13) % 26) + 65);
                }
                else if (message[i] >= 'a' && message[i] <= 'z')
                {
                    result += (char)(((message[i] - 97 + 13) % 26) + 97);
                }
                else
                {
                    result += message[i];
                }
            }
            return result;
        }
    }
}

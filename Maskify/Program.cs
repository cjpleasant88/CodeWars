using System;

namespace Maskify
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Maskify("123456789"));
            Console.WriteLine(Kata.Maskify("1234"));
            Console.WriteLine(Kata.Maskify("12"));
        }
    }

    public static class Kata
    {
        public static string Maskify(string cc)
        {
            string maskedCc = "";
            if (cc.Length < 5)
            {
                return cc;
            }
            else
            {
                for (int i = 0; i < cc.Length - 4; ++i)
                {
                    maskedCc += '#';
                }
                for (int i = cc.Length - 4; i < cc.Length; ++i)
                {
                    maskedCc += cc[i];
                }
                return maskedCc;
            }
        }
    }
}

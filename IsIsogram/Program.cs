using System;

namespace IsIsogram
{
    class Program
    {
        /*
        An isogram is a word that has no repeating letters, consecutive or non-consecutive.
        Implement a function that determines whether a string that contains only letters is
        an isogram.Assume the empty string is an isogram. Ignore letter case.
        */

        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsIsogram("Dermatoglyphics"));
            Console.WriteLine(Kata.IsIsogram("aba"));
            Console.WriteLine(Kata.IsIsogram("moOse"));
        }
    }

    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if(str[i] == str[j])
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}

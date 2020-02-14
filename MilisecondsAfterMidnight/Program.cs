using System;

namespace MilisecondsAfterMidnight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Clock.Past(9,16,56));
            Console.ReadLine();
        }


    }

    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            int past = (((h * 60 + m) * 60) + s) * 1000;
            return past;
        }
    }
}

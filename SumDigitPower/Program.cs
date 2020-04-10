using System;

namespace SumDigitPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long[] result = SumDigPower.SumDigPow(1, 1000);
            DisplayArray(result);
            //char num = '7';
            //string strnum = num.ToString();
            //Console.WriteLine(strnum);
            //int intnum = Int32.Parse(strnum);
            //Console.WriteLine(intnum);
            //intnum += 3;
            //Console.WriteLine(intnum);
        }

        public static void DisplayArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
        }
    }

    /*
    public class SumDigPower
    {

        public static long[] SumDigPow(long a, long b)
        {
            int count = 0;
            for (long i = a; i <= b; i++)
            {
                string num = i.ToString();
                double sum = 0;
                for (int j = 0; j < num.Length; j++)
                {
                   sum += Math.Pow((Double.Parse(num[j].ToString())),j+1);
                }
                if ((long)sum == i)
                {
                    count++;
                }
            }
            long[] result = new long[count];
            int index = 0;
            for (long i = a; i <= b; i++)
            {
                string num = i.ToString();
                double sum = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    sum += Math.Pow((Double.Parse(num[j].ToString())), j + 1);
                }
                if ((long)sum == i)
                {
                    result[index] = i;
                    index++;
                }
            }
            return result;
        }
    }
    */
    
    public class SumDigPower
    {

        public static long[] SumDigPow(long a, long b)
        {
            long[] result = { };
            for (long i = a; i <= b; i++)
            {
                string num = i.ToString();
                double sum = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    sum += System.Math.Pow((System.Double.Parse(num[j].ToString())), j + 1);
                }
                if ((long)sum == i)
                {
                    System.Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = i;
                }
            }
            return result;
        }
    }
    
}

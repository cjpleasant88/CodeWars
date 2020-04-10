using System;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            double x = signature[0];
            double y = signature[1];
            double z = signature[2];
            if (n == 0)
            {
                double[] result = { };
                return result;
            }
            else if (n == 1)
            {
                double[] result = { x };
                return result;
            }
            else if (n == 2)
            {
                double[] result = { x, y };
                return result;
            }
            else
            {
                double[] result = new double[n];
                result[0] = x;
                result[1] = y;
                result[2] = z;
                for (int i = 3; i < n; i++)
                {
                    result[i] = result[i - 1] + result[i - 2] + result[i - 3];
                }
                return result;
            }
        }
    }
}

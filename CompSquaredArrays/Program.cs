using System;

namespace CompSquaredArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                int appearance = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == a[j]) appearance++;
                    if (a[i] * a[i] == b[j])

                        count++;
                }
                if (count < 1 || count != appearance)
                    return false;
            }
            return true;
        }
    }
}

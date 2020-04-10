/*              Rotting Oranges problem
In a given grid, each cell can have one of three values:

the value 0 representing an empty cell;
the value 1 representing a fresh orange;
the value 2 representing a rotten orange.
Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange.If this is impossible, return -1 instead.
*/


using System;
using System.Collections.Generic;

namespace RottingOranges
{
    public struct orange
    {
        public int x;
        public int y;
        public int minute;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 2, 1, 1 }, { 1, 1, 0 }, { 0, 1, 1 } };
            Console.WriteLine("Original Rotting oranges");
            Display(array);
            Console.WriteLine(OrangesRotting(array));
            Console.WriteLine();
            int[,] array2 = { { 2, 1, 1 }, { 0, 1, 1 }, {1, 0, 1} };
            Console.WriteLine("Original Rotting oranges");
            Display(array2);
            Console.WriteLine(OrangesRotting(array2));
            Console.WriteLine();
            int[,] array3 = { { 0 , 2 } };
            Console.WriteLine("Original Rotting oranges");
            Display(array3);
            Console.WriteLine(OrangesRotting(array3));
            Console.WriteLine();
            int[,] array4 = { { 2, 1, 1 ,0,1,2,1,1}, { 0,0,1,2,0,1, 1, 0, }, { 0,2,1,2,0,1, 1, 1 }, { 0, 2, 1, 2, 0, 1, 1, 1 } , { 0, 2, 1, 2, 0, 1, 1, 1 } , { 0, 2, 1, 2, 0, 1, 1, 1 } , { 0, 2, 1, 2, 0, 1, 1, 1 } , { 0, 2, 1, 2, 0, 1, 1, 1 } };
            Console.WriteLine("Original Rotting oranges");
            Display(array4);
            Console.WriteLine(OrangesRotting(array4));
        }

        public static int OrangesRotting(int[,] grid)
        {
            int cols = grid.GetLength(1);
            int rows = grid.GetLength(0);
            Queue<orange> Q = new Queue<orange>();
            orange temp;
            int minutes = 0;
            bool IsFresh = false;

            //Stores all initial rotting oranges in a Queue
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 2)
                    {
                        temp = new orange();
                        temp.x = i;
                        temp.y = j;
                        temp.minute = -1;

                        Q.Enqueue(temp);
                    }
                }
            }

            while(Q.Count > 0)
            {
                temp = Q.Peek();
                int minute;

                //Check cell to the right
                if (IsValid(temp.x, temp.y + 1, rows, cols) && grid[temp.x, temp.y + 1] == 1)
                {
                    minute = temp.minute;
                    grid[temp.x, temp.y + 1] = 2;
                    temp.y++;

                    temp.minute = ++minute;
                    Q.Enqueue(temp);
                    temp.y--;
                }
                //Check cell to the left
                if (IsValid(temp.x, temp.y - 1, rows, cols) && grid[temp.x, temp.y - 1] == 1)
                {
                    minute = temp.minute;
                    grid[temp.x, temp.y - 1] = 2;
                    temp.y--;
                    temp.minute = ++minute;
                    Q.Enqueue(temp);
                    temp.y++;
                }
                //Check cell above
                if (IsValid(temp.x - 1, temp.y, rows, cols) && grid[temp.x - 1, temp.y] == 1)
                {
                    minute = temp.minute;
                    grid[temp.x - 1, temp.y] = 2;
                    temp.x--;
                    temp.minute = ++minute;
                    Q.Enqueue(temp);
                    temp.x++;
                }
                //Check cell below
                if (IsValid(temp.x + 1, temp.y, rows, cols) && grid[temp.x + 1, temp.y] == 1)
                {
                    minute = temp.minute;
                    grid[temp.x + 1, temp.y] = 2;
                    temp.x++;
                    temp.minute = ++minute;
                    Q.Enqueue(temp);
                    temp.x--;
                }
                if (minutes < temp.minute)
                {
                    minutes = temp.minute;
                }
                Q.Dequeue();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(grid[i,j] == 1)
                    {
                        IsFresh = true;
                        break;
                    }
                }
            }
            Console.WriteLine("Final Rotting Oranges");
            Display(grid);

            return IsFresh ? -1 : minutes;
        }

        //Checks if the grid point is inside the array limits
        public static bool IsValid(int x, int y, int rows, int cols)
        {
            return (x >= 0 && x < rows && y >= 0 && y < cols);
        }

        //Displays an array in the console Line
        public static void Display(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write($"{ grid[i, j]}");

                }
                Console.WriteLine();
            }
        }
    }
}
using System;

namespace TicketLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Line
    {
        /*
         The new "Avengers" movie has just been released! There are a lot of people at 
         the cinema box office standing in a huge line. Each of them has a single 100, 
         50 or 25 dollars bill. An "Avengers" ticket costs 25 dollars.    
         Vasya is currently working as a clerk. He wants to sell a ticket to every single person 
         in this line.    
         Can Vasya sell a ticket to each person and give the change if he initially has no money 
         and sells the tickets strictly in the order people follow in the line?    
         Return YES, if Vasya can sell a ticket to each person and give the change with the bills
         he has at hand at that moment. Otherwise return NO.

         Examples:    
         tickets([25, 25, 50]) // => YES 
         tickets([25, 100]) // => NO. Vasya will not have enough money to give change to 100 dollars
         tickets([25, 25, 50, 50, 100]) // => NO. Vasya will not have the right bills to give 75 dollars
         of change (you can't make two bills of 25 from one of 50)
         */

        public static string Tickets(int[] peopleInLine)
        {
            int cash50 = 0;
            int cash25 = 0;

            for(int i = 0; i < peopleInLine.Length; i++)
            {
                switch (peopleInLine[i])
                {
                    case 100:
                        if (cash50 > 0 && cash25 > 0)
                        {
                            cash50 -= 1;
                            cash25 -= 1;
                        }
                        else if (cash25 > 2) cash25 -= 3;
                        else return "NO";
                        break;
                    case 50:
                        if (cash25 > 0)
                        {
                            cash25 -= 1;
                            cash50 += 1;
                        }
                        else return "NO";
                        break;
                    case 25:
                        cash25 += 1;
                        break;
                }
            }
            return "YES";
        }
    }
}

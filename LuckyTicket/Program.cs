using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int part1;
            int part2;

            for (int number = 1000; number <= 999999; number++)
            {
                part1 = number % 1000;
                part2 = number / 1000;

                if (CountSum(part1) == CountSum(part2))
                    Console.Write(number + " ");
            }
        }
        public static int CountSum(int number)
        {
            var array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = number % 10;
                number = number / 10;
            }
            return array[0] + array[1] + array[2];
        }
    }
}

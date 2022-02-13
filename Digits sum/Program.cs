﻿namespace DigitsSum
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(SolutionPrimeiro(14) == 19 ? "Correto" : "Errado");
            Console.WriteLine(SolutionPrimeiro(10) == 11 ? "Correto" : "Errado");
            Console.WriteLine(SolutionPrimeiro(99) == 9999 ? "Correto" : "Errado");
        }

        internal static int SolutionPrimeiro(int N)
        {
            int sum = GetSum(N) * 2;
            for (int i = N + 1; i < int.MaxValue; i++)
            {
                if (GetSum(i) == sum)
                    return i;
            }
            return 0;
        }

        internal static int GetSum(int N)
        {
            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N /= 10;
            }
            return sum;
        }
    }
}
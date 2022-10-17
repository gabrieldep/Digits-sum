namespace DigitsSum
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Solution(765) == 9999 ? "Correto" : "Errado");
            Console.WriteLine(Solution(14) == 19 ? "Correto" : "Errado");
            Console.WriteLine(Solution(10) == 11 ? "Correto" : "Errado");
            Console.WriteLine(Solution(99) == 9999 ? "Correto" : "Errado");
        }

        internal static int Solution(int N)
        {
            int sum = GetSum(N) * 2;
            int i = N;
            while (true)
            {
                i = GetNextCompare(i);
                if (GetSum(i) == sum)
                    return i;
            }
        }

        internal static int GetNextCompare(int N)
        {
            var digits = N.ToString().Select(c => c - '0').ToArray();
            int sum = GetSum(N) * 2;
            for (int i = digits.Length - 1; i >= 0; i--)
                if (digits[i] != 9)
                {
                    digits[i] = digits[i] + 1;
                    int result = 0;
                    for (int j = 0; j < digits.Length; j++)
                        result = result * 10 + digits[j];
                    return result;
                }
            return N + (int)Math.Pow(10, digits.Length);
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
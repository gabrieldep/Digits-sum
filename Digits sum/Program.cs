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
            for (int i = N; i < int.MaxValue; GetNextCompare(ref i))
                if (GetSum(i) == sum)
                    return i;
            return -1;
        }

        internal static void GetNextCompare(ref int N)
        {
            var digits = N.ToString().Select(c => c - '0').ToList();
            if (digits.All(d => d == 9))
            {
                N += (int)Math.Pow(10, digits.Count);
                return;
            }
            var i = digits.LastIndexOf(digits.Last(a => a != 9));
            digits[i] = digits[i] + 1;
            int result = 0;
            for (int j = 0; j < digits.Count; j++)
                result = result * 10 + digits[j];
            N = result;
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
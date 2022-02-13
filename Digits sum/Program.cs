namespace DigitsSum
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
            int sum = GetAlgSum(N) * 2;
            for (int i = N; i < int.MaxValue; i++)
            {
                if (GetAlgSum(i) == sum)
                    return i;
            }
            return 0;
        }

        internal static int GetAlgSum(int N)
        {
            string aux = N.ToString();
            int sum = 0;
            for (int i = 0; i < aux.Length; i++)
            {
                sum += int.Parse(aux[i].ToString());
            }
            return sum;
        }
    }
}
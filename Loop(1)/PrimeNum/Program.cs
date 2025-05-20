internal class Program
{
    private static void Main(string[] args)
    {
        int isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return 1;
        }

        for (int i = 2; i < 100; i++)
        {
            if (isPrime(i) == 1)
            {
                Console.WriteLine(i);
            }

        }

    }

}

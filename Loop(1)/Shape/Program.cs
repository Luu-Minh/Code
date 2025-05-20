internal class Program
{
    private static void Main(string[] args)
    {
        //Print rectangle
        System.Console.WriteLine("Nhap chieu dai: ");
        int length = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Nhap chieu rong: ");
        int width = int.Parse(System.Console.ReadLine());

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        //Print square triangle
        System.Console.WriteLine("Nhap chieu cao: ");
        int height = int.Parse(System.Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        //Print isosceles triangle
        System.Console.WriteLine("Nhap chieu cao: ");
        int height2 = int.Parse(System.Console.ReadLine());
        for (int i = 1; i <= height2; i++)
        {
            for (int j = 1; j <= height2 - i; j++)
            {
                System.Console.Write(" ");
            }
            for (int j = 1; j <= i * 2 - 1; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

    }
}
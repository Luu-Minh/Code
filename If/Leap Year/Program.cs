internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Nhap nam: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
            System.Console.WriteLine($"{year} la nam nhuan");
        }
        else {
            System.Console.WriteLine($"{year} khong phai la nam nhuan");
        }
    }
}
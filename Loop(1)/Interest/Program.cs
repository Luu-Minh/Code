internal class Program
{
    private static void Main(string[] args)
    {
        double money, interestRate;
        int month;

        System.Console.WriteLine("Nhap so tien gui:");
        money = double.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Nhap so thang gui:");
        month = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Nhap lai suat: ");
        interestRate = double.Parse(System.Console.ReadLine());

        double interest = 0;
        for (int i = 0; i <= month; i++)
        {
            interest += money * interestRate / 100 / 12;
        }
        System.Console.WriteLine("Lai suat la: " + interest);
    }
}
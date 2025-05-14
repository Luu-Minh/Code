internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Nhap thang: ");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month) {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                System.Console.WriteLine("Thang " + month + " co 31 ngay");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                System.Console.WriteLine("Thang " + month + " co 30 ngay");
                break;
            case 2:
                System.Console.WriteLine("Thang " + month + " co 28 hoac 29 ngay");
                break;
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Nhap so: ");
        int n = Convert.ToInt32(System.Console.ReadLine());
        if (n < 10 && n >= 0) {
            switch (n) {
                case 0:
                    System.Console.WriteLine("Khong");
                    break;
                case 1:
                    System.Console.WriteLine("Mot");
                    break;
                case 2:
                    System.Console.WriteLine("Hai");
                    break;
                case 3:
                    System.Console.WriteLine("Ba");
                    break;
                case 4:
                    System.Console.WriteLine("Bon");
                    break;
                case 5:
                    System.Console.WriteLine("Nam");
                    break;
                case 6:
                    System.Console.WriteLine("Sau");
                    break;
                case 7:
                    System.Console.WriteLine("Bay");
                    break;
                case 8:
                    System.Console.WriteLine("Tam");
                    break;
                case 9:
                    System.Console.WriteLine("Chin");
                    break;
            }
        } else if(n >= 10 && n < 100) {
            int ones = n % 10;
            int tens = n / 10;
            switch (tens) {
                case 1:
                    System.Console.Write("Muoi");
                    break;
                case 2:
                    System.Console.Write("Hai");
                    break;
                case 3:
                    System.Console.Write("Ba");
                    break;
                case 4:
                    System.Console.Write("Bon");
                    break;
                case 5:
                    System.Console.Write("Nam");
                    break;
                case 6:
                    System.Console.Write("Sau");
                    break;
                case 7:
                    System.Console.Write("Bay");
                    break;
                case 8:
                    System.Console.Write("Tam");
                    break;
                case 9:
                    System.Console.Write("Chin");
                    break;
            }
            switch (ones) {
                case 0:
                    System.Console.WriteLine("Muoi");
                    break;
                case 1:
                    System.Console.WriteLine("Mot");
                    break;
                case 2:
                    System.Console.WriteLine("Hai");
                    break;
                case 3:
                    System.Console.WriteLine("Ba");
                    break;
                case 4:
                    System.Console.WriteLine("Bon");
                    break;
                case 5:
                    System.Console.WriteLine("Nam");
                    break;
                case 6:
                    System.Console.WriteLine("Sau");
                    break;
                case 7:
                    System.Console.WriteLine("Bay");
                    break;
                case 8:
                    System.Console.WriteLine("Tam");
                    break;
                case 9:
                    System.Console.WriteLine("Chin");
                    break;
            }
        } else if(n >= 100 && n < 1000) {
            int ones = n % 10;
            int tens = (n / 10) % 10;
            int hundreds = n / 100;
            if (tens == 0 && ones == 0) {
                
            }
            switch (hundreds) {
                case 1:
                    System.Console.Write("Mot tram");
                    break;
                case 2:
                    System.Console.Write("Hai tram");
                    break;
                case 3:
                    System.Console.Write("Ba tram");
                    break;
                case 4:
                    System.Console.Write("Bon tram");
                    break;
                case 5:
                    System.Console.Write("Nam tram");
                    break;
                case 6:
                    System.Console.Write("Sau tram");
                    break;
                case 7:
                    System.Console.Write("Bay tram");
                    break;
                case 8:
                    System.Console.Write("Tam tram");
                    break;
                case 9:
                    System.Console.Write("Chin tram");
                    break;
            }
            switch (tens) {
                case 0:
                    System.Console.WriteLine("Le");
                    break;
                case 1:
                    System.Console.WriteLine("Muoi");
                    break;
                case 2:
                    System.Console.WriteLine("Hai");
                    break;
                case 3:
                    System.Console.WriteLine("Ba");
                    break;
                case 4:
                    System.Console.WriteLine("Bon");
                    break;
                case 5:
                    System.Console.WriteLine("Nam");
                    break;
                case 6:
                    System.Console.WriteLine("Sau");
                    break;
                case 7:
                    System.Console.WriteLine("Bay");
                    break;
                case 8:
                    System.Console.WriteLine("Tam");
                    break;
                case 9:
                    System.Console.WriteLine("Chin");
                    break;
            }
            switch (ones) {
                case 0:
                    System.Console.WriteLine("Muoi");
                    break;
                case 1:
                    System.Console.WriteLine("Mot");
                    break;
                case 2:
                    System.Console.WriteLine("Hai");
                    break;
                case 3:
                    System.Console.WriteLine("Ba");
                    break;
                case 4:
                    System.Console.WriteLine("Bon");
                    break;
                case 5:
                    System.Console.WriteLine("Nam");
                    break;
                case 6:
                    System.Console.WriteLine("Sau");
                    break;
                case 7:
                    System.Console.WriteLine("Bay");
                    break;
                case 8:
                    System.Console.WriteLine("Tam");
                    break;
                case 9:
                    System.Console.WriteLine("Chin");
                    break;
            }
        }
    }
}
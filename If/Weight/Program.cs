internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter weight: ");
        double weight = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);

        if (bmi < 18.5) {
            System.Console.WriteLine("Underweight");
        } else if (18.5 <= bmi && bmi < 25) {
            System.Console.WriteLine("Normal");
        } else if (25 <= bmi && bmi < 30 ) {
            System.Console.WriteLine("Overweight");
        } else {
            System.Console.WriteLine("Obese");
        }
    }
}
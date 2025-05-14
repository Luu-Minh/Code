﻿public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Nhap so a: ");
        int a = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Nhap so b: ");
        int b = int.Parse(System.Console.ReadLine());

        if (a == 0) {
            if (b == 0) {
                System.Console.WriteLine("Phuong trinh co vo so nghiem");
            } else {
                System.Console.WriteLine("Phuong trinh vo nghiem");

            }
        } else {
            double x = -b / a;
            System.Console.WriteLine($"Phuong trinh co nghiem x = {x}");
        }
    }
}
using System;

class URI
{

    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine() ?? "0");
        double B = double.Parse(Console.ReadLine() ?? "0");
        double C = double.Parse(Console.ReadLine() ?? "0");

        double MEDIA = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

        Console.WriteLine("MEDIA = {0}", MEDIA.ToString("F1"));
    }

}
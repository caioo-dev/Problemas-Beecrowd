using System;

class URI
{

    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine() ?? "0");
        double B = double.Parse(Console.ReadLine() ?? "0");

        double MEDIA = (A * 3.5 + B * 7.5) / 11.0;

        Console.WriteLine("MEDIA = {0}", MEDIA.ToString("F5"));
    }

}
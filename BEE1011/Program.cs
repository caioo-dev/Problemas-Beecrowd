using System;

class URI
{

    static void Main(string[] args)
    {
        int raio = Convert.ToInt32(Console.ReadLine());

        double pi = 3.14159;

        double volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3.0);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }

}
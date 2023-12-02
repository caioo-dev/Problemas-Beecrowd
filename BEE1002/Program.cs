using System;

class URI
{

    static void Main(string[] args)
    {

        double raio = double.Parse(Console.ReadLine() ?? "0");
        double N = 3.14159;

        double A = N * Math.Pow(raio, 2.0);

        Console.WriteLine("A={0}", A.ToString("F4"));

    }

}
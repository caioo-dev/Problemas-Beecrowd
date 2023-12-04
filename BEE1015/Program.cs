using System;

class URI
{

    static void Main(string[] args)
    {
        string[] valores1 = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(valores1[0]);
        double y1 = Convert.ToDouble(valores1[1]);

        string[] valores2 = Console.ReadLine().Split(' ');
        double x2 = Convert.ToDouble(valores2[0]);
        double y2 = Convert.ToDouble(valores2[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

        Console.WriteLine(distancia.ToString("F4"));
    }

}
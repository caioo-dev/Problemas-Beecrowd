using System;

class URI
{

    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(valores[0]);
        double B = Convert.ToDouble(valores[1]);
        double C = Convert.ToDouble(valores[2]);

        double delta = Math.Pow(B, 2.0) - 4 * A * C;

        if (delta < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double R1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double R2 = (-B - Math.Sqrt(delta)) / (2 * A);

            Console.WriteLine("R1 = " + R1.ToString("F5"));
            Console.WriteLine("R2 = " + R2.ToString("F5"));
        }
    }

}
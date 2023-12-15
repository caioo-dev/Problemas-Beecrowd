using System;

class URI
{

    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double v1 = Convert.ToDouble(valores[0]);
        double v2 = Convert.ToDouble(valores[1]);
        double v3 = Convert.ToDouble(valores[2]);

        if (v1 + v2 > v3 && v1 + v3 > v2 && v2 + v3 > v1)
        {
            double perimetro = v1 + v2 + v3;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
        }
        else
        {
            double area = (v1 + v2) * v3 / 2.0;
            Console.WriteLine("Area = " + area.ToString("F1"));
        }
    }

}
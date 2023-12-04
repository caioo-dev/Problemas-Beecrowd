using System;

class URI
{

    static void Main(string[] args)
    {
        double pi = 3.14159;

        string[] numeros = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(numeros[0]);
        double B = Convert.ToDouble(numeros[1]);
        double C = Convert.ToDouble(numeros[2]);

        double triangulo = A * C / 2.0;
        double circulo = pi * Math.Pow(C, 2.0);
        double trapezio = (A + B) * C / 2.0;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
    }

}
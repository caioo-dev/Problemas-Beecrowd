using System;

class URI
{

    static void Main(string[] args)
    {
        double valor = Convert.ToDouble(Console.ReadLine());

        if (valor < 0.0 || valor > 100.00)
        {
            Console.WriteLine("Fora de intervalo");
        }
        else if (valor <= 25.00)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor <= 50.00)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (valor <= 75.00)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else
        {
            Console.WriteLine("Intervalo (75,100]");
        }
    }

}
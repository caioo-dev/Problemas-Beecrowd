using System;

class URI
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(valores[0]);
        double b = Convert.ToDouble(valores[1]);
        double c = Convert.ToDouble(valores[2]);

        double[] valoresDecrescente = new double[] { a, b, c };

        Array.Sort(valoresDecrescente);
        Array.Reverse(valoresDecrescente);

        a = valoresDecrescente[0];
        b = valoresDecrescente[1];
        c = valoresDecrescente[2];


        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }

        else
        {
            if (Math.Pow(a, 2.0) == Math.Pow(b, 2.0) + Math.Pow(c, 2.0))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(a, 2.0) > Math.Pow(b, 2.0) + Math.Pow(c, 2.0))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
using System;

class URI
{

    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(valores[0]);
        int n2 = Convert.ToInt32(valores[1]);
        int n3 = Convert.ToInt32(valores[2]);

        int[] numeros = new int[] { n1, n2, n3 };

        Array.Sort(numeros);

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine();
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
    }

}
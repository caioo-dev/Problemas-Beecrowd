using System;

class URI
{

    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine() ?? "0");
        int B = int.Parse(Console.ReadLine() ?? "0");

        int soma = A + B;

        Console.WriteLine("SOMA = {0}", soma);
    }

}
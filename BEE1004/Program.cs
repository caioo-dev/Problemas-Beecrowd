using System;

class URI
{

    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine() ?? "0");
        int B = int.Parse(Console.ReadLine() ?? "0");

        int PROD = A * B;

        Console.WriteLine("PROD = {0}", PROD);

    }

}
using System;

class URI
{

    static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(numeros[0]);
        int B = Convert.ToInt32(numeros[1]);
        int C = Convert.ToInt32(numeros[2]);

        int MaiorAB = (A + B + Math.Abs(A - B)) / 2;

        if (MaiorAB > C)
        {
            Console.WriteLine(MaiorAB + " eh o maior");
        }
        else
        {
            Console.WriteLine(C + " eh o maior");
        }
    }

}
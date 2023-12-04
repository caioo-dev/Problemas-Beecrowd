using System;

class URI
{

    static void Main(string[] args)
    {
        int distanciaKm = Convert.ToInt32(Console.ReadLine());
        double totalCombustivel = Convert.ToDouble(Console.ReadLine());

        double kmPorLitros = distanciaKm / totalCombustivel;

        Console.WriteLine(kmPorLitros.ToString("F3") + " km/l");
    }

}
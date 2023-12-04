using System;

class URI
{

    static void Main(string[] args)
    {
        int distanciaKm = Convert.ToInt32(Console.ReadLine());

        int tempoMinutos = distanciaKm * 2;

        Console.WriteLine(tempoMinutos + " minutos");
    }

}
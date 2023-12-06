using System;

class URI
{

    static void Main(string[] args)
    {
        int segundos = Convert.ToInt32(Console.ReadLine());

        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        segundos = segundos % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }

}
using System;

class URI
{

    static void Main(string[] args)
    {
        int idadeEmDias = Convert.ToInt32(Console.ReadLine());

        int ano = idadeEmDias / 365;
        int resto = idadeEmDias % 365;
        int mes = resto / 30;
        int dia = resto % 30;

        Console.WriteLine(ano + " ano(s)");
        Console.WriteLine(mes + " mes(es)");
        Console.WriteLine(dia + " dia(s)");
    }

}
using System;

class URI
{

    static void Main(string[] args)
    {
        int tempoDeViagem = Convert.ToInt32(Console.ReadLine());
        int velocidadeMedia = Convert.ToInt32(Console.ReadLine());

        double qntLitros = (double)tempoDeViagem * velocidadeMedia / 12;

        Console.WriteLine(qntLitros.ToString("F3"));
    }

}
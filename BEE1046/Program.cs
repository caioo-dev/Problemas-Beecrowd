using System;

class URI
{
    static void Main(string[] args)
    {

        string[] horas = Console.ReadLine().Split(' ');

        int horaInicio = Convert.ToInt32(horas[0]);
        int horaFinal = Convert.ToInt32(horas[1]);
        int duracao = 0;

        if (horaInicio >= horaFinal)
        {
            duracao = (24 + horaFinal) - horaInicio;
        }
        else
        {
            duracao = (horaFinal - horaInicio);
        }

        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }
}
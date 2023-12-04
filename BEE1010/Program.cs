using System;

class URI
{

    static void Main(string[] args)
    {
        string[] peca1 = Console.ReadLine().Split(' ');
        int codigo = Convert.ToInt32(peca1[0]);
        int qnt = Convert.ToInt32(peca1[1]);
        double valor = Convert.ToDouble(peca1[2]);

        string[] peca2 = Console.ReadLine().Split(' ');
        int codigo2 = Convert.ToInt32(peca2[0]);
        int qnt2 = Convert.ToInt32(peca2[1]);
        double valor2 = Convert.ToDouble(peca2[2]);

        double valorTotal = valor * qnt + valor2 * qnt2;

        Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2"));
    }

}
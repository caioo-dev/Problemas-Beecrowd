using System;

class URI
{

    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine());
        double totalVendas = Convert.ToDouble(Console.ReadLine());

        salario += totalVendas * 0.15;

        Console.WriteLine("TOTAL = R$ " + salario.ToString("F2"));
    }   

}
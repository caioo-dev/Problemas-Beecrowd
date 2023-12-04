using System;

class URI
{

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine() ?? "0");
        int workedHours = int.Parse(Console.ReadLine() ?? "0");
        double dolarPerHour = double.Parse(Console.ReadLine() ?? "0");

        double salary = workedHours * dolarPerHour;

        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));
    }

}
using System;

class URI
{

    static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');
        double n1 = Convert.ToDouble(numeros[0]);
        double n2 = Convert.ToDouble(numeros[1]);
        double n3 = Convert.ToDouble(numeros[2]);
        double n4 = Convert.ToDouble(numeros[3]);

        double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;


        if (media >= 7.0)
        {
            Console.WriteLine("Media: " + media.ToString("F1"));
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Media: {0:f1}", (media - 0.01).ToString("F1"));
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Media: {0:f1}", (media - 0.01).ToString("F1"));
            Console.WriteLine("Aluno em exame.");
            double notaExame = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));

            media = (media + notaExame) / 2.0;
            if (media >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + media.ToString("F1"));
        }
    }
}
using System;

class NumeroMaior
{
    static void Main (String [] args)
    {
        //Faça um programa que leia três numeros e informe qual deles é o maior.

        Console.WriteLine("Digite três numeros: ");

        int N1 = Convert.ToInt32(Console.ReadLine());
        int N2 = Convert.ToInt32(Console.ReadLine());
        int N3 = Convert.ToInt32(Console.ReadLine());

        if (N1 > N2 && N1 > N3)
        {
            Console.WriteLine("O numero Maior é: " + N1);
        }else if (N2 > N1 && N2 > N3)
        {
            Console.WriteLine("O numero maior é: " + N2);
        }
        else
        {
            Console.WriteLine("O numero Maior é: " + N3);
        }

        Console.ReadKey();
    }
    
}



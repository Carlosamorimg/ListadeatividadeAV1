using System;

class Tabuada
{
    static void Main (String [] args)
    {
        //Escreva um programa que leia um numero inteiro e inrome sua tabuada de 1 a 10.

        Console.WriteLine("Digite um numero , para saber sua tabuada: ");
        int num = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("A Tabuada de " + num + " é:");
        Console.WriteLine(num + " * 1 = " + (num * 1));
        Console.WriteLine(num + " * 2 = " + (num * 2));
        Console.WriteLine(num + " * 3 = " + (num * 3));
        Console.WriteLine(num + " * 4 = " + (num * 4));
        Console.WriteLine(num + " * 5 = " + (num * 5));
        Console.WriteLine(num + " * 6 = " + (num * 6));
        Console.WriteLine(num + " * 7 = " + (num * 7));
        Console.WriteLine(num + " * 8 = " + (num * 8));
        Console.WriteLine(num + " * 9 = " + (num * 9));
        Console.WriteLine(num + " * 10 = " + (num * 10));
        

        Console.ReadKey();
    }

}



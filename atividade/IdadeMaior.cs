using System;

class IdadeMaior
{
    static void Main (String [] args)
    {
        //Faça um programa que leia o nome e a idade de duas Pessoas e 
        //    informe qual a mais velha.

        Console.WriteLine("Digite Seu nome e sua Idade: ");
        String nome1 = Console.ReadLine ();
        int idade1 = Convert.ToInt16(Console.ReadLine());


        Console.WriteLine("Digite outro nome e outra Idade: ");
        String nome2 = Console.ReadLine();
        int idade2 = Convert.ToInt16(Console.ReadLine());


        if (idade1 > idade2)
        {
            Console.WriteLine(nome1 + " é mais velho(a) que " + nome2);
        }
        else
        {
            Console.WriteLine(nome2 + " é mais velho(a) que " + nome1);
        }
        Console.ReadKey();
    }
}



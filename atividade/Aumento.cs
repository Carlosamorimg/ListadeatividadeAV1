using System;

class Aumento
{
    static void Main(String[] args)
    {
        // Escreva um programa que pergunte o nome e o salário de um funcionário e calcule seu novo salário, com um aumento de 10 %.

        Console.WriteLine("Digite o seu Nome e o seu Salario: ");
        string nome = Console.ReadLine();
        Decimal salario = Convert.ToDecimal(Console.ReadLine());

        decimal aumento = salario * 1.1m;
        Console.WriteLine(aumento);
        Console.WriteLine("Olá " + nome +" Seu salario com o aumento de 10% será de: " + aumento.ToString("c"));


        Console.ReadKey();
    }

}



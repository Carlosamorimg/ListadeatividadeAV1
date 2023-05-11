using System;

class BaixoAlto
{
    static void Main(String[] args)
    {
        // Escreva um programa que pergunte o nome e a altura de uma pessoa e informe se ela é considerada alta ou não
        //(considerando que, no Brasil, a média de altura para homens é de 1,72m e para mulheres é de 1,60m)

        Console.WriteLine("Digite M para masculino e F para Feminino ");
        string sexo = Console.ReadLine();
        Console.WriteLine("Digite seu nome: ");
        String Nome = Console.ReadLine();
        Console.WriteLine("Digite sua altura");
        decimal altura = Convert.ToDecimal(Console.ReadLine());
       

        if (sexo == "M")
        {
            if (altura >= 1.72m )
            {
                Console.WriteLine(Nome + " você é Alto!!");
            }
            else
            {
                Console.WriteLine(Nome + " você é Baixo!!");
            }
        }
        else if (sexo == "F")
        {
            if (altura >= 1.60m)
            {
                Console.WriteLine(Nome + " você é Alta!!");
            }
            else
            {
                Console.WriteLine( Nome + " você é Baixa!!");
            }
        }


        Console.ReadKey();
    }

}



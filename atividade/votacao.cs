using System;

class votacao
{
    static void Main (String [] args)
    {
        // Escreva um programa que pergunte a idade do Usuario e informe se ele
        //já pode votar ou não.


        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 15 )
        {
            Console.WriteLine("Você não tem idade para votar!!");
        } 
        else if (idade >= 16 && idade <= 17)
        {
            Console.WriteLine ("Você tem idade para votar, mas não é Obrigado.");
        }
        else if (idade >= 18 && idade <= 65)
        {
            Console.WriteLine ("Você ja tem idade, seu voto é obrigatorio.");
        }
        else
        {
            Console.WriteLine ("seu voto é Opcional!! ");
        }
        Console.ReadKey();
    }

}



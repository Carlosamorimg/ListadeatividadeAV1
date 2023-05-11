using System;

class Horario
{
    static void Main (String [] args)
    {
        //  Faça um programa que leia o nome de um usuário e o cumprimente de forma personalizada de acordo com 
        //a hora atual. Por exemplo, se for de manhã, o programa deve exibir "Bom dia, Fulano!"

        Console.WriteLine("Olá, Qual o seu Nome: ");
        string nome = Console.ReadLine ();

       // Console.WriteLine ("Desculpe, você pode me informar a hora atual: ");
       DateTime hora = (DateTime.Now);

        if (hora.Hour >= 06  && hora.Hour <=12)
        {
            Console.WriteLine("Bom Dia " + nome);
        }
        else if (hora.Hour > 12  && hora.Hour <= 18 )
        {
            Console.WriteLine("Boa Tarde " + nome);
        }
        else
        {
            Console.WriteLine("Boa noite " + nome);
        }

        Console.ReadKey();
    }

}



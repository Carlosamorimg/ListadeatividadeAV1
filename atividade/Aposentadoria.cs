using System;

class Aposentadoria
{
    static void Main (String [] args)
    {
        //faça um programa que leia o nome, a idade e o sexo de uma pessoa e informe se ela pode se aposentar
        //ou não. No Brasil, as mulheres podem se aposentar com 35 anos de contribuição e 62 anos de idade,
        //enquanto os homens podem se aposentar com 35 anos de contribuição e 65 anos de idade.


        Console.WriteLine("Digite seu Nome: ");
        string nome = Console.ReadLine ();

        Console.WriteLine ("Digite sua Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Infome seu sexo, Use M para masculino e F para Feminino:");
        string sexo = Console.ReadLine ();

        Console.WriteLine("informe seu tempo total de contribuição, usando so os anos. ");
        int TempoTrab = Convert.ToInt32(Console.ReadLine());

        if (sexo == "M")
        {
            if (TempoTrab >= 35 && idade >= 62)
            {
                Console.WriteLine("Você tem idade e tempo de contribuição para se aposentar");
            }
            else if(TempoTrab <= 34 || idade <= 61)
            {
                Console.WriteLine("Desculpe, Você não tem idade ou tempo de contribuição suficientes para se aposentar.");
            }
        }
        else
        {
            if (TempoTrab >= 35 && idade >= 62)
            {
                Console.WriteLine("Você tem idade e tempo de contribuição para se aposentar");
            }
            else if (TempoTrab <= 34 || idade <= 61)
            {
                Console.WriteLine("Desculpe, Você não tem idade ou tempo de contribuição suficientes para se aposentar.");
            }
        }
        Console.ReadKey();
    }
}



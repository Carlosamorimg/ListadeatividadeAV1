using System;

class IMC
{
    static void Main (String [] args)
    {

        //Faça um programa que leia o peso e a altura de uma pessoa e informe seu índice de massa corporal(IMC).
        //    O IMC é calculado dividindo o peso(em kg) pela altura ao quadrado(em metros). Se o resultado for menor do que 18,5,
        //    a pessoa está abaixo do peso;
        //    se for entre 18, 5 e 24, 9, está dentro do peso ideal;
        //    se for entre 25 e 29, 9,  está com sobrepeso;
        //    se for entre 30 e 34, 9, está com obesidade grau I;
        //    se for entre 35 e 39, 9, está com obesidade grau II;
        //    e se for maior do que 40, está com obesidade grau III.

          Console.WriteLine("Digite seu peso e sua altura:");
        decimal peso = Convert.ToDecimal(Console.ReadLine());
        decimal altura = Convert.ToDecimal(Console.ReadLine());

        decimal IMC = peso / (altura * altura);

        Console.WriteLine(IMC.ToString("f2"));

        if (IMC <= 18.5m)
        {
            Console.WriteLine("Você esta abaixo do peso.");
        }
        else if (IMC > 18.5m && IMC <= 24.9m)
        {
            Console.WriteLine("Você esta dentro do peso ideal!!");
        }
        else if (IMC > 25 && IMC <= 29.9m)
        {
            Console.WriteLine("Você esta com sobrepeso!!");
        }
        else if(IMC > 30 && IMC <= 34.9m)
        {
            Console.WriteLine("Você esta com Obesidade Grau I ");
        }
        else if (IMC > 35 && IMC <= 39.9m)
        {
            Console.WriteLine("Você esta com Obesidade Grau II ");
        }
        else
        {
            Console.WriteLine("Você esta com Obesidade Grau III ");
        }

        Console.ReadKey();
    }

}



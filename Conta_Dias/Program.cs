using System;

namespace Conta_Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []ano = new int[2];
            int bisexto = 0, soma = 0;

            Console.WriteLine("Digite o Ano de início:");
                ano[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o Ano final: ");
                ano[1] = int.Parse(Console.ReadLine());

            
            soma = (ano[1] + 1 - ano[0]) * 365; //isso pre somar do começo do primeiro ano
                                                //até o final do segundo ano informado

            for (int i = 0; bisexto < ano[1]; i++)
            {
                bisexto = ano[0] + i;
                if (bisexto % 4 == 0)
                    soma++;
            }
            Console.WriteLine($"\nA quantidade de dias entre o primeiro dia do ano {ano[0]} e o último dia do ano {ano[1]} é de {soma} dias!");
        }
    }
}

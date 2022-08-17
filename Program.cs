using System;

namespace Finance_Account
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num1, num2,num3,num4,num5,num6;

            int resul = 0;



            Console.WriteLine("Digite a sua primeira renda");

            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda renda");

            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua terceira renda");

            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a fatura do Cartão Nubank");

            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua fatura Cartão Santander ");

            num5 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quanto você quer Poupar ");

            num6 = double.Parse(Console.ReadLine());


            Console.Clear();



            while (resul != 6)

            {

                Console.WriteLine("Digite 1 : Para saber o total adquirido no Mês");

                Console.WriteLine("Digite 2 : Para saber o total gasto no Mês");

                Console.WriteLine("Digite 3 : Para saber o total habilitado à ser gasto diário");

                Console.WriteLine("Digite 4 : Para saber o saldo");

                Console.WriteLine("Digite 5 : Para o Poupado e o Restante do Mês");

                Console.WriteLine("Digite 6 : Para sair");

                resul = int.Parse(Console.ReadLine());

                if (resul == 1)

                {

                    Console.WriteLine("Total Recebido no Mês = {0}", num1 + num2 + num3);

                }

                if (resul == 2)

                {

                    Console.WriteLine("Total Gasto = {0}", (num4 + num5) );

                }

                if (resul == 3)

                {

                    Console.WriteLine("Total Disponível por Dia = {0}", (num1 + num2 + num3 - num4 - num5 - num6 )  / 30);

                }

                if (resul == 4)

                {

                    Console.WriteLine("Saldo Restante no Mês = {0}", (num1 + num2 + num3) - (num4 + num5 + num6));

                }

                if (resul == 5)

                {

                    Console.WriteLine("Total Poupado = {0}", (((num1+num2+num3) - (num4+num5+num6)) + num6));

                }

                Console.ReadLine();

                Console.Clear();

            }
            

        }

    }
}

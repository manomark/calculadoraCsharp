using System;

namespace ConsoleApp2
{
    class Program
    {
        static double adicao(double adval1, double adval2)
        {
            double r;

            r = (adval1) + (adval2);

            return r;
        }

        static double subtracao(double subval1, double subval2)
        {
            double r;

            r = subval1 - subval2;

            return r;
        }

        static double multiplicacao(double mulval1, double mulval2)
        {
            double r;

            r = mulval1 * mulval2;

            return r;
        }

        static double divisao(double dival1, double dival2)
        {
            double r;

            r = dival1 / dival2;

            return r;
        }
       
        static void Main(string[] args)
        {
            double adval1 = 0, adval2 = 0, subval1 = 0, subval2 = 0, mulval1 = 0, mulval2 = 0, dival1 = 0, dival2 = 0, opcao = 6;

            while (opcao != 0)
            {
                    Console.WriteLine("-------------------------- \n" +
                    "Digite qual operação deseja fazer: \n " +
                    "01 - Adição \n " +
                    "02 - Subtração \n " +
                    "03 - Multiplicação \n" +
                    " 04 - Divisão \n" +
                    " 0 - Sair \n" +
                    "-----------------------------------" +
                    "\n");
                    opcao = double.Parse(Console.ReadLine());

                    switch (opcao)
                    {

                    case 1:
                        Console.WriteLine("Digite o valor para o calculo");
                        adval1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor para o calculo");
                        adval2 = double.Parse(Console.ReadLine());

                        Console.WriteLine(adicao(adval1, adval2));

                        break;

                    case 2:
                        Console.WriteLine("Digite o valor para o calculo");
                        subval1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor para o calculo");
                        subval2 = double.Parse(Console.ReadLine());

                        Console.WriteLine(subtracao(subval1, subval2));

                        break;

                    case 3:
                        Console.WriteLine("Digite o valor para o calculo");
                        mulval1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor para o calculo");
                        mulval2 = double.Parse(Console.ReadLine());

                        Console.WriteLine(multiplicacao(mulval1, mulval2));

                        break;

                    case 4:
                        Console.WriteLine("Digite o valor para o calculo");
                        dival1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor para o calculo");
                        dival2 = double.Parse(Console.ReadLine());

                        Console.WriteLine(divisao(dival1, dival2));

                        break;


                }
            }
            Console.ReadKey();

        }
    }
}

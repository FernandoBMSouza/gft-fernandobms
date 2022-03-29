using System;
using System.Globalization;
using Project03.Entities;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Dados do Produto");
            System.Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            System.Console.Write("Valor Real: ");
            double valorReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(descricao, valorReal);

            System.Console.WriteLine("Insira o Percentual: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Insira a Operação: ");
            System.Console.WriteLine("1 - Acrescimo");
            System.Console.WriteLine("2 - Desconto");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    System.Console.WriteLine(p.Operacao(percentual, "acrescimo"));
                    break;
                case 2:
                    System.Console.WriteLine(p.Operacao(percentual, "desconto"));
                    break;
                default:
                    System.Console.WriteLine("Operação Inválida!");
                    break;
            }

           
        }
    }
}
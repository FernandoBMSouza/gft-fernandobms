using System;
using Project01.Entities;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Insira a Bandeira do Cartão: ");
            System.Console.WriteLine("1 - Visa");
            System.Console.WriteLine("2 - MaterCard");
            int bandeiraCartao = int.Parse(Console.ReadLine());
            switch (bandeiraCartao)
            {
                case 1:
                    CartaoBandeiraVisa visa = new CartaoBandeiraVisa();
                    System.Console.WriteLine("Insira o Tipo de Pagamento: ");
                    System.Console.WriteLine("1 - Crédito");
                    System.Console.WriteLine("2 - Debito");
                    int tipoDePagamento = int.Parse(Console.ReadLine());
                    switch (tipoDePagamento)
                    {
                        case 1:
                            System.Console.WriteLine(visa);
                            visa.PagamentoCredito();
                            break;
                        case 2:
                            System.Console.WriteLine(visa);
                            visa.PagamentoDebito();
                            break;
                        default:
                            System.Console.WriteLine("Opção Inválida!");
                            break;
                    }
                    break;
                case 2:
                    CartaoBandeiraMaster master = new CartaoBandeiraMaster();
                    System.Console.WriteLine("Insira o Tipo de Pagamento: ");
                    System.Console.WriteLine("1 - Crédito");
                    System.Console.WriteLine("2 - Debito");
                    tipoDePagamento = int.Parse(Console.ReadLine());
                    switch (tipoDePagamento)
                    {
                        case 1:
                            System.Console.WriteLine(master);
                            master.PagamentoCredito();
                            break;
                        case 2:
                            System.Console.WriteLine(master);
                            master.PagamentoDebito();
                            break;
                        default:
                            System.Console.WriteLine("Opção Inválida!");
                            break;
                        }
                    break;
                default:
                    System.Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}
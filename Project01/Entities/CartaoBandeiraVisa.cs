using System;
using Project01.Interfaces;

namespace Project01.Entities
{
    class CartaoBandeiraVisa : IPagamentoCartao
    {
        public void PagamentoCredito()
        {
            System.Console.WriteLine("Tipo de Pagamento: Credito");
        }

        public void PagamentoDebito()
        {
            System.Console.WriteLine("Tipo de Pagamento: Debito");
        }

        public override string ToString()
        {
            return "Pago com Visa";
        }
    }
}
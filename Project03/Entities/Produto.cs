using System;
using System.Globalization;

namespace Project03.Entities
{
    class Produto
    {
        public string Descricao { get; set; }
        public double ValorReal { get; set; }
        public double ValorFinal { get; set; }

        public Produto(string descricao, double valorReal)
        {
            Descricao = descricao;
            ValorReal = valorReal;
        }
        public string Operacao(double percentual, string operacao)
        {
            if(operacao == "desconto")
            {
                double desconto = ValorReal * percentual / 100;
                ValorFinal = ValorReal - desconto;
                return $"Valor Final: R$ {ValorFinal.ToString("F2", CultureInfo.InvariantCulture)}";
            }
            else
            {
                double acrescimo = ValorReal * percentual / 100;
                ValorFinal = ValorReal + acrescimo;
                return $"Valor Final: R$ {ValorFinal.ToString("F2", CultureInfo.InvariantCulture)}";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BSolution.Financeiro.Entidades
{
    public class DadosComissao
    {
        public int CodigoPagamento { get; set; }
        public string NomeCliente { get; set; }
        public string ValorPagar { get; set; }
        public bool Pago { get; set; }
        public string Comissao { get; set; }
    }
}

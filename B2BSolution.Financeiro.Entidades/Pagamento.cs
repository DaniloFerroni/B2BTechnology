using System;
using System.Runtime.Serialization;

namespace B2BSolution.Financeiro.Entidades
{
    public class Pagamento
    {
        [Atributo("ID_PAGAMENTO")]
        [DataMember(Name = "ID_PAGAMENTO")]
        public int CodigoPagamento { get; set; }

        [Atributo("DT_PAGAMENTO")]
        [DataMember(Name = "DT_PAGAMENTO")]
        public DateTime DataPagamento { get; set; }

        [Atributo("VL_GASTO")]
        [DataMember(Name = "VL_GASTO")]
        public decimal ValorGasto { get; set; }

        [Atributo("VL_PAGO")]
        [DataMember(Name = "VL_PAGO")]
        public decimal ValorPago { get; set; }

        [Atributo("ID_CONTRATO")]
        [DataMember(Name = "ID_CONTRATO")]
        public Contrato Contrato { get; set; }

        [Atributo("FL_PAGO")]
        [DataMember(Name = "FL_PAGO")]
        public bool Pago { get; set; }
    }
}

using System;
using System.Runtime.Serialization;
//using PrazoContratual = B2BSolution.Financeiro.Entidades.Enum.Enumeradores.PrazoContratual;
//using B2BSolution.Financeiro.Entidades.Enum;

namespace B2BSolution.Financeiro.Entidades
{
    public class Contrato
    {
        [Atributo("id_contrato")]
        [DataMember(Name = "id_contrato")]
        public int IdContrato { get; set; }

        [Atributo("id_cliente")]
        [DataMember(Name = "id_cliente")]
        public Cliente Cliente { get; set; }

        [Atributo("id_equipamento")]
        [DataMember(Name = "id_equipamento")]
        public Equipamentos Equipamento { get; set; }

        [Atributo("VL_TARIFA_LOCAL")]
        [DataMember(Name = "VL_TARIFA_LOCAL")]
        public decimal ValorTarifaLocal { get; set; }

        [Atributo("VL_TARIFA_LDN")]
        [DataMember(Name = "VL_TARIFA_LDN")]
        public decimal ValorTarifaLdn { get; set; }

        [Atributo("VL_TARIFA_VC1")]
        [DataMember(Name = "VL_TARIFA_VC1")]
        public decimal ValorTarifaVc1 { get; set; }

        [Atributo("VL_TARIFA_VC2")]
        [DataMember(Name = "VL_TARIFA_VC2")]
        public decimal ValorTarifaVc2 { get; set; }

        [Atributo("VL_TARIFA_VC3")]
        [DataMember(Name = "VL_TARIFA_VC3")]
        public decimal ValorTarifaVc3 { get; set; }

        [Atributo("vl_consumo_minimo")]
        [DataMember(Name = "vl_consumo_minimo")]
        public decimal ValorConsumoMinimo { get; set; }

        [Atributo("dt_contrato")]
        [DataMember(Name = "dt_contrato")]
        public DateTime DataContrato { get; set; }

        [Atributo("DS_CADENCIA_FIXA")]
        [DataMember(Name = "DS_CADENCIA_FIXA")]
        public string CadenciaFixa { get; set; }

        [Atributo("DS_CADENCIA_MOVEL")]
        [DataMember(Name = "DS_CADENCIA_MOVEL")]
        public string CadenciaMovel { get; set; }

        [Atributo("dia_vencimento")]
        [DataMember(Name = "dia_vencimento")]
        public int DiaVencimento { get; set; }

        [Atributo("vl_instalacao")]
        [DataMember(Name = "vl_instalacao")]
        public decimal ValorInstalacao { get; set; }

        [Atributo("ID_PRAZO_CONTRATUAL")]
        [DataMember(Name = "ID_PRAZO_CONTRATUAL")]
        public int PrazoContratual { get; set; }

        [Atributo("ID_VENDEDOR")]
        [DataMember(Name = "ID_VENDEDOR")]
        public Vendedores Vendedor { get; set; }

        [Atributo("VL_MENSALIDADE")]
        [DataMember(Name = "VL_MENSALIDADE")]
        public decimal ValorMensalidade { get; set; }
    }
}

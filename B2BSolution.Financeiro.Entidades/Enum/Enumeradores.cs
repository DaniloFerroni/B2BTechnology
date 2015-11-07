using System.Runtime.Serialization;

namespace B2BSolution.Financeiro.Entidades.Enum
{
    //[DataContract(Name = "Enumeradores")]
    //public static class Enumeradores
    //{
        public struct Comissao
        {
            public static decimal Vendedor = (decimal)0.1;
            public static decimal Canal = (decimal)0.05;
        }

        public enum TipoVendedores
        {
            Vendedor = 1,
            Canal = 2
        }

        public enum TipoPdf
        {
            Pagamento = 1,
            Comissao = 2
        }

        [DataContract(Name = "PrazoContratual")]
        public enum PrazoContratual
        {
            [EnumMember]
            SeisMeses = 1,
            [EnumMember]
            DozeMeses = 2,
            [EnumMember]
            VinteQuatroMeses = 3,
            [EnumMember]
            Indeterminado = 4
        }

}
using System.Collections.Generic;
using System.Data.SqlClient;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.DataBase
{
    public class ContratoDataBase : IInserir<Contrato>, IAlterar<Contrato>, IListar<Contrato>
    {
        public int Incluir(Contrato entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_CLIENTE", Value = entidades.Cliente.IdCliente},
                new SqlParameter{ParameterName = "@ID_EQUIPAMENTO", Value = entidades.Equipamento == null ? (object) null : entidades.Equipamento.IdEquipamento},
                new SqlParameter{ParameterName = "@VL_TARIFA_LOCAL", Value = entidades.ValorTarifaLocal},
                new SqlParameter{ParameterName = "@VL_TARIFA_LDN", Value = entidades.ValorTarifaLdn},
                new SqlParameter{ParameterName = "@VL_TARIFA_VC1", Value = entidades.ValorTarifaVc1},
                new SqlParameter{ParameterName = "@VL_TARIFA_VC2", Value = entidades.ValorTarifaVc2},
                new SqlParameter{ParameterName = "@VL_TARIFA_VC3", Value = entidades.ValorTarifaVc3},
                new SqlParameter{ParameterName = "@VL_CONSUMO_MINIMO", Value = entidades.ValorConsumoMinimo},
                new SqlParameter{ParameterName = "@DS_CADENCIA_FIXA", Value = entidades.CadenciaFixa},
                new SqlParameter{ParameterName = "@DS_CADENCIA_MOVEL", Value = entidades.CadenciaMovel},
                new SqlParameter{ParameterName = "@DT_CONTRATO", Value = entidades.DataContrato},
                new SqlParameter{ParameterName = "@DIA_VENCIMENTO", Value = entidades.DiaVencimento},
                new SqlParameter{ParameterName = "@VL_INSTALACAO", Value = entidades.ValorInstalacao},
                new SqlParameter{ParameterName = "@ID_PRAZO_CONTRATUAL", Value = entidades.PrazoContratual},
                new SqlParameter{ParameterName = "@ID_VENDEDOR", Value = entidades.Vendedor.IdVendedor},
                new SqlParameter{ParameterName = "@VL_MENSALIDADE", Value = entidades.ValorMensalidade},
            };

            return ExecutarComando<Contrato>.ExecutarComandoInsert("SPR_CONTRATO_INSERIR", parametros);
        }

        //public Contrato Entidade(string codigo)
        //{
        //    var parametros = new List<SqlParameter>
        //    {
        //        new SqlParameter{ParameterName = "@ID_CLIENTE", Value = codigo}
        //    };

        //    return ExecutarComando<Contrato>.RetornarEntidade("SPR_CONTRATO_SELECIONAR", parametros);
        //}

        public void Alterar(Contrato entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_CONTRATO", Value = entidades.IdContrato},
                new SqlParameter{ParameterName = "@ID_CLIENTE", Value = entidades.Cliente.IdCliente},
                new SqlParameter{ParameterName = "@ID_EQUIPAMENTO", Value = entidades.Equipamento == null ? (object)null : entidades.Equipamento.IdEquipamento},
                new SqlParameter{ParameterName = "@VL_TARIFA_LOCAL", Value = entidades.ValorTarifaLocal},
                new SqlParameter{ParameterName = "@VL_TARIFA_LDN", Value = entidades.ValorTarifaLdn},
                new SqlParameter{ParameterName = "@VL_TARIFA_VC1", Value = entidades.ValorTarifaVc1},
                new SqlParameter{ParameterName = "@VL_TARIFA_VC2", Value = entidades.ValorTarifaVc2},
                new SqlParameter{ParameterName = "@VL_TARIFA_VC3", Value = entidades.ValorTarifaVc3},
                new SqlParameter{ParameterName = "@VL_CONSUMO_MINIMO", Value = entidades.ValorConsumoMinimo},
                new SqlParameter{ParameterName = "@DS_CADENCIA_FIXA", Value = entidades.CadenciaFixa},
                new SqlParameter{ParameterName = "@DS_CADENCIA_MOVEL", Value = entidades.CadenciaMovel},
                new SqlParameter{ParameterName = "@DT_CONTRATO", Value = entidades.DataContrato},
                new SqlParameter{ParameterName = "@DIA_VENCIMENTO", Value = entidades.DiaVencimento},
                new SqlParameter{ParameterName = "@VL_INSTALACAO", Value = entidades.ValorInstalacao},
                new SqlParameter{ParameterName = "@ID_PRAZO_CONTRATUAL", Value = entidades.PrazoContratual},
                new SqlParameter{ParameterName = "@ID_VENDEDOR", Value = entidades.Vendedor.IdVendedor},
                new SqlParameter{ParameterName = "@VL_MENSALIDADE", Value = entidades.ValorMensalidade},
            };

            ExecutarComando<Contrato>.ExecutarComandoSemRetorno("SPR_CONTRATO_ALTERAR", parametros);
        }

        public List<Contrato> Listar(string codigo)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_CLIENTE", Value = codigo}
            };

            return ExecutarComando<Contrato>.RetornarListaTipada("SPR_CONTRATO_SELECIONAR", parametros);
        }
    }
}

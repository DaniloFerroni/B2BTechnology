using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.DataBase
{
    public class PagamentosDataBase : IInserir<Pagamento>, IListarTodos<Pagamento>, IAlterar<Pagamento>, IDeletar
    {

        public int Incluir(Pagamento entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ Value = entidades.DataPagamento, ParameterName = "@DT_PAGAMENTO" },
                new SqlParameter{ Value = entidades.ValorGasto, ParameterName = "@VL_GASTO" },
                new SqlParameter{ Value = entidades.ValorPago, ParameterName = "@VL_PAGO" },
                new SqlParameter{ Value = entidades.Contrato.IdContrato, ParameterName = "@ID_CONTRATO" },
                new SqlParameter{ Value = entidades.Pago, ParameterName = "@FL_PAGO" },
            };

            return ExecutarComando<Pagamento>.ExecutarComandoInsert("SPR_PAGAMENTO_INSERIR", parametros);
        }

        public List<Pagamento> ListarTodos(Pagamento entidade)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ Value = entidade.DataPagamento.ToString("yyyy-MM-dd"),  ParameterName = "@DT_PAGAMENTO" },
                new SqlParameter{ Value = entidade.Contrato.Cliente.Documento, ParameterName = "@DOCUMENTO" },
            };

            return ExecutarComando<Pagamento>.RetornarListaTipada("SPR_PAGAMENTO_SELECIONAR", parametros);
        }

        public void Alterar(Pagamento entidade)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ Value = entidade.CodigoPagamento,  ParameterName = "@ID_PAGAMENTO" },
                new SqlParameter{ Value = entidade.Pago, ParameterName = "@FL_PAGO" },
            };

            ExecutarComando<Pagamento>.ExecutarComandoSemRetorno("SPR_PAGAMENTO_ALTERAR", parametros);
        }

        public void Deletar(string codigo)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ Value = codigo,  ParameterName = "@ID_PAGAMENTO" },
            };

            ExecutarComando<Pagamento>.ExecutarComandoSemRetorno("SPR_PAGAMENTO_DELETAR", parametros);
        }
    }
}

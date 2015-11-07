using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.DataBase
{
    public class ContatoDataBase : IInserir<Contato>, IAlterar<Contato>, IEntidade<Contato>
    {
        public int Incluir(Contato entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@NOME", Value = entidades.Nome},
                new SqlParameter{ParameterName = "@EMAIL", Value = entidades.Email},
                new SqlParameter{ParameterName = "@TELEFONE", Value = entidades.Telefone},
                new SqlParameter{ParameterName = "@CELULAR", Value = entidades.Celular},
            };

            return ExecutarComando<Contato>.ExecutarComandoInsert("SPR_CONTATO_INSERIR", parametros);
        }

        public void Alterar(Contato entidade)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_CONTATO", Value = entidade.IdContato},
                new SqlParameter{ParameterName = "@NOME", Value = entidade.Nome},
                new SqlParameter{ParameterName = "@EMAIL", Value = entidade.Email},
                new SqlParameter{ParameterName = "@TELEFONE", Value = entidade.Telefone},
                new SqlParameter{ParameterName = "@CELULAR", Value = entidade.Celular},
            };

            ExecutarComando<Contato>.ExecutarComandoSemRetorno("SPR_CONTATO_ALTERAR", parametros);
        }

        public Contato Entidade(string codigo)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_CONTATO", Value = codigo}
            };

            return ExecutarComando<Contato>.RetornarEntidade("SPR_CONTATO_SELECIONAR", parametros);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.DataBase
{
    public class ClienteDataBase : IInserir<Cliente>, IAlterar<Cliente>, IListar<Cliente>
    {
        public int Incluir(Cliente entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@NOME", Value = entidades.Nome},
                new SqlParameter{ParameterName = "@TP_PESSOA", Value = entidades.TipoPessoa},
                new SqlParameter{ParameterName = "@ID_ENDERECO", Value = entidades.Endereco.IdEndereco},
                new SqlParameter{ParameterName = "@ID_CONTATO", Value = entidades.Contato.IdContato},
                new SqlParameter{ParameterName = "@FL_ATIVO", Value = entidades.Ativo},
                new SqlParameter{ParameterName = "@DOCUMENTO", Value = entidades.Documento},
            };

            return ExecutarComando<Cliente>.ExecutarComandoInsert("SPR_CLIENTE_INSERIR", parametros);
        }

        public void Alterar(Cliente entidade)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_CLIENTE", Value = entidade.IdCliente},
                new SqlParameter{ParameterName = "@NOME", Value = entidade.Nome},
                new SqlParameter{ParameterName = "@TP_PESSOA", Value = entidade.TipoPessoa},
                new SqlParameter{ParameterName = "@ID_ENDERECO", Value = entidade.Endereco.IdEndereco},
                new SqlParameter{ParameterName = "@ID_CONTATO", Value = entidade.Contato.IdContato},
                new SqlParameter{ParameterName = "@FL_ATIVO", Value = entidade.Ativo},
            };

            ExecutarComando<Cliente>.ExecutarComandoSemRetorno("SPR_CLIENTE_ALTERAR", parametros);
        }

        //public Cliente Entidade(string codigo)
        //{
        //    var parametros = new List<SqlParameter>
        //    {
        //        new SqlParameter{ParameterName = "@DOCUMENTO", Value = codigo}
        //    };

        //    return ExecutarComando<Cliente>.RetornarEntidade("SPR_CLIENTE_SELECIONAR", parametros);
        //}

        public List<Cliente> Listar(string codigo)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@DOCUMENTO", Value = codigo}
            };

            return ExecutarComando<Cliente>.RetornarListaTipada("SPR_CLIENTE_SELECIONAR", parametros);
        }
    }
}

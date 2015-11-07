using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.DataBase
{
    public class VendedoresDataBase : IInserir<Vendedores>, IEntidade<Vendedores>, IListarTodos<Vendedores>, IAlterar<Vendedores>
    {
        public int Incluir(Vendedores entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_ENDERECO", Value = entidades.Endereco.IdEndereco},
                new SqlParameter{ParameterName = "@ID_CONTATO", Value = entidades.Contato.IdContato},
                new SqlParameter{ParameterName = "@DOCUMENTO", Value = entidades.Documento},
                new SqlParameter{ParameterName = "@COMISSAO", Value = entidades.Comissao},
                new SqlParameter{ParameterName = "@TP_VENDEDOR", Value = entidades.TipoVendedor},
                new SqlParameter{ParameterName = "@FL_ATIVO", Value = entidades.Ativo},
                new SqlParameter{ParameterName = "@NOME", Value = entidades.Nome},
                new SqlParameter{ParameterName = "@ID_SUPERIOR", Value = entidades.Superior}
            };

            return ExecutarComando<Vendedores>.ExecutarComandoInsert("SPR_VENDEDORES_INSERIR", parametros);
        }

        public Vendedores Entidade(string codigo)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@DOCUMENTO", Value = codigo}
            };

            return ExecutarComando<Vendedores>.RetornarEntidade("SPR_VENDEDORES_SELECIONAR", parametros);
        }

        public List<Vendedores> ListarTodos(Vendedores entidade)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@FL_ATIVO", Value = entidade.Ativo}
            };

            return ExecutarComando<Vendedores>.RetornarListaTipada("SPR_VENDEDORES_SELECIONAR", parametros);
        }

        public void Alterar(Vendedores entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_VENDEDOR", Value = entidades.IdVendedor},
                new SqlParameter{ParameterName = "@ID_ENDERECO", Value = entidades.Endereco.IdEndereco},
                new SqlParameter{ParameterName = "@ID_CONTATO", Value = entidades.Contato.IdContato},
                new SqlParameter{ParameterName = "@DOCUMENTO", Value = entidades.Documento},
                new SqlParameter{ParameterName = "@COMISSAO", Value = entidades.Comissao},
                new SqlParameter{ParameterName = "@TP_VENDEDOR", Value = entidades.TipoVendedor},
                new SqlParameter{ParameterName = "@FL_ATIVO", Value = entidades.Ativo},
                new SqlParameter{ParameterName = "@NOME", Value = entidades.Nome},
                new SqlParameter{ParameterName = "@ID_SUPERIOR", Value = entidades.Superior}
            };

            ExecutarComando<Vendedores>.ExecutarComandoSemRetorno("SPR_VENDEDORES_ALTERAR", parametros);
        }
    }
}

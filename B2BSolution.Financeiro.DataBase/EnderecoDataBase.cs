using System.Collections.Generic;
using System.Data.SqlClient;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.DataBase
{
    public class EnderecoDataBase : IInserir<Endereco>, IAlterar<Endereco>, IEntidade<Endereco>
    {
        public int Incluir(Endereco entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@RUA", Value = entidades.Rua},
                new SqlParameter{ParameterName = "@NUMERO", Value = entidades.Numero},
                new SqlParameter{ParameterName = "@COMPLEMENTO", Value = entidades.Complemento},
                new SqlParameter{ParameterName = "@CEP", Value = entidades.Cep},
                new SqlParameter{ParameterName = "@BAIRRO", Value = entidades.Bairro},
                new SqlParameter{ParameterName = "@CIDADE", Value = entidades.Cidade},
                new SqlParameter{ParameterName = "@ESTADO", Value = entidades.Estado},
            };

            return ExecutarComando<Endereco>.ExecutarComandoInsert("SPR_ENDERECO_INSERIR", parametros);
        }

        public void Alterar(Endereco entidade)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_ENDERECO", Value = entidade.IdEndereco},
                new SqlParameter{ParameterName = "@RUA", Value = entidade.Rua},
                new SqlParameter{ParameterName = "@NUMERO", Value = entidade.Numero},
                new SqlParameter{ParameterName = "@COMPLEMENTO", Value = entidade.Complemento},
                new SqlParameter{ParameterName = "@CEP", Value = entidade.Cep},
                new SqlParameter{ParameterName = "@BAIRRO", Value = entidade.Bairro},
                new SqlParameter{ParameterName = "@CIDADE", Value = entidade.Cidade},
                new SqlParameter{ParameterName = "@ESTADO", Value = entidade.Estado},
            };

            ExecutarComando<Endereco>.ExecutarComandoSemRetorno("SPR_ENDERECO_ALTERAR", parametros);
        }
        
        public Endereco Entidade(string codigo)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@ID_ENDERECO", Value = codigo}
            };

            return ExecutarComando<Endereco>.RetornarEntidade("SPR_ENDERECO_SELECIONAR", parametros);
        }
    }
}

using System.Collections.Generic;
using System.Data.SqlClient;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.DataBase
{
    public class EquipamentoDataBase : IInserir<Equipamentos>, IListarTodos<Equipamentos>
    {
        public int Incluir(Equipamentos entidades)
        {
            var parametros = new List<SqlParameter>
            {
                new SqlParameter{ParameterName = "@MARCA", Value = entidades.Marca},
                new SqlParameter{ParameterName = "@MODELO", Value = entidades.Modelo},
                new SqlParameter{ParameterName = "@NUMERO_SERIE", Value = entidades.NumeroSerie}
            };

            return ExecutarComando<Equipamentos>.ExecutarComandoInsert("SPR_EQUIPAMENTOS_INSERIR", parametros);
        }

        public List<Equipamentos> ListarTodos(Equipamentos entidade)
        {
            return ExecutarComando<Equipamentos>.RetornarListaTipada("SPR_EQUIPAMENTOS_SELECIONAR", null);
        }
    }
}

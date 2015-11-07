using System;
using System.Collections.Generic;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.Negocio
{
    public class EquipamentosNegocio
    {
        public int InserirEquipamento(Equipamentos equipamentos)
        {
            try
            {
                var equipamento = new InserirNegocio<Equipamentos>(new EquipamentoDataBase());
                return equipamento.InserirEntidade(equipamentos);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirEquipamento: ", ex.Message));
            }
        }

        public List<Equipamentos> SelecionarEquipamentos(Equipamentos equipamentos)
        {
            try
            {
                var equipamentosNegocio = new ListarNegocio<Equipamentos>(new EquipamentoDataBase());
                return equipamentosNegocio.ListarEntidade(equipamentos);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarEquipamentos: ", ex.Message));
            }
        }
    }
}

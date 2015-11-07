using System.Collections.Generic;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Negocio;

namespace B2BSolution.Financeiro.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EquipamentosService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EquipamentosService.svc or EquipamentosService.svc.cs at the Solution Explorer and start debugging.
    public class EquipamentosService : IInserir<Equipamentos>, IListarTodos<Equipamentos>
    {
        private readonly EquipamentosNegocio _equipamentosNegocio = new EquipamentosNegocio();

        public int Incluir(Equipamentos entidades)
        {
            return _equipamentosNegocio.InserirEquipamento(entidades);
        }

        public List<Equipamentos> ListarTodos(Equipamentos entidade)
        {
            return _equipamentosNegocio.SelecionarEquipamentos(entidade);
        }
    }
}

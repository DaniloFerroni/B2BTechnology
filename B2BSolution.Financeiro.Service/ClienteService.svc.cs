using System.Collections.Generic;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Negocio;

namespace B2BSolution.Financeiro.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteService.svc or ClienteService.svc.cs at the Solution Explorer and start debugging.
    public class ClienteService : IEntidade<Cliente>, IAlterar<Cliente>, IInserir<Cliente>, IListar<Cliente>
    {
        private readonly ClienteNegocio _cliente = new ClienteNegocio();

        public Cliente Entidade(string codigo)
        {
            return _cliente.SelecionarCliente(codigo);
        }

        public void Alterar(Cliente entidade)
        {
            _cliente.AlterarCliente(entidade);
        }

        public int Incluir(Cliente entidades)
        {
            return _cliente.InserirCliente(entidades);
        }

        public List<Cliente> Listar(string codigo)
        {
            return _cliente.SelecionarTodosCliente(codigo);
        }
    }
}

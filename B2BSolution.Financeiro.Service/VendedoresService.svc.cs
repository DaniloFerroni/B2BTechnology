using System.Collections.Generic;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Negocio;

namespace B2BSolution.Financeiro.Service
{
    public class VendedoresService : IInserir<Vendedores>, IEntidade<Vendedores>, IListarTodos<Vendedores>, IAlterar<Vendedores>
    {
        private readonly VendedoresNegocio _vendedores = new VendedoresNegocio();

        public int Incluir(Vendedores entidades)
        {
            return _vendedores.InserirVendedor(entidades);
        }

        public Vendedores Entidade(string codigo)
        {
            return _vendedores.SelecionarVendedore(codigo);
        }

        public List<Vendedores> ListarTodos(Vendedores entidade)
        {
            return _vendedores.ListarVendedores(entidade);
        }

        public void Alterar(Vendedores entidade)
        {
            _vendedores.AlterarVendedores(entidade);
        }
    }
}

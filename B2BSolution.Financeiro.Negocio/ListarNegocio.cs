using System.Collections.Generic;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    public class ListarNegocio<T> where T : class, new ()
    {
        private readonly IListarTodos<T> _listar;
        public ListarNegocio(IListarTodos<T> listar)
        {
            _listar = listar;
        }

        public List<T> ListarEntidade(T entidade)
        {
            return _listar.ListarTodos(entidade);
        }
    }
}

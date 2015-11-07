
using System.Collections.Generic;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    public class ListarCodigo<T> where T : class, new ()
    {
        private readonly IListar<T> _listar;
        public ListarCodigo(IListar<T> listar)
        {
            _listar = listar;
        }

        public List<T> ListarComCodigo(string codigo)
        {
            return _listar.Listar(codigo);
        }
    }
}

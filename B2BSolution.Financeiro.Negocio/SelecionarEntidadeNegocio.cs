
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    internal class SelecionarEntidadeNegocio<T> where T : class , new()
    {
        private readonly IEntidade<T> _entidade;
        public SelecionarEntidadeNegocio(IEntidade<T> entidade)
        {
            _entidade = entidade;
        }

        public T SelecionarEntidade(string codigo)
        {
            return _entidade.Entidade(codigo);
        }
    }
}

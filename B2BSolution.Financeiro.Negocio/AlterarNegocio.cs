using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    internal class AlterarNegocio<T> where T : class , new ()
    {
        private readonly IAlterar<T> _alterar;
        public AlterarNegocio(IAlterar<T> alterar)
        {
            _alterar = alterar;
        }

        public void AlterarEntidade(T entidade)
        {
            _alterar.Alterar(entidade);
        }

    }
}


using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    internal class InserirNegocio<T> where T : class , new()
    {
        private readonly IInserir<T> _inserir;
        public InserirNegocio(IInserir<T> inserir)
        {
            _inserir = inserir;
        }

        public int InserirEntidade(T entidade)
        {
            return _inserir.Incluir(entidade);
        }
    }
}

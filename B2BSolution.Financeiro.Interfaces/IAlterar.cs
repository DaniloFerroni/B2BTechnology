using System.ServiceModel;

namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IAlterar<T> where T : class , new()
    {
        [OperationContract]
        void Alterar(T entidade);
    }
}

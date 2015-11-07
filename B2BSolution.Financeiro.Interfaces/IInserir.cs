using System.ServiceModel;

namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IInserir<T> where T : class , new()
    {
        [OperationContract]
        int Incluir(T entidades);
    }
}

using System.Collections.Generic;
using System.ServiceModel;

namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IListarTodos<T> where T : class , new()
    {
        [OperationContract]
        List<T> ListarTodos(T entidade);
    }
}

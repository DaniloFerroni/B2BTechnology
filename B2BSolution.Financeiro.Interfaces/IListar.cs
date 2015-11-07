using System.Collections.Generic;
using System.ServiceModel;

namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IListar<T> where T : class , new()
    {
        [OperationContract]
        List<T> Listar(string codigo);
    }
}

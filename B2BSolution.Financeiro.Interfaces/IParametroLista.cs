using System.Collections.Generic;
using System.ServiceModel;

namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IParametroLista<T> where T : class , new()
    {
        [OperationContract]
        void EntidadeParametro(List<T> lista);
    }
}

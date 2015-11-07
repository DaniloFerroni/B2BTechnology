using System.ServiceModel;
using System.ServiceModel.Web;


namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IEntidade<T> where T : class , new()
    {
        [OperationContract]
        //[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "paises/{codigo}")]
        T Entidade(string codigo);
    }
}

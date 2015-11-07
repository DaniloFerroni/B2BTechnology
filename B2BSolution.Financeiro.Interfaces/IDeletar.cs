using System.ServiceModel;

namespace B2BSolution.Financeiro.Interfaces
{
    [ServiceContract]
    public interface IDeletar
    {
        [OperationContract]
        void Deletar(string codigo);
    }
}

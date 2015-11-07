using System.Collections.Generic;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Negocio;

namespace B2BSolution.Financeiro.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PagamentoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PagamentoService.svc or PagamentoService.svc.cs at the Solution Explorer and start debugging.
    public class PagamentoService :  IInserir<Pagamento>, IListarTodos<Pagamento>, IEntidade<Pagamento>, IParametroLista<Pagamento>, IDeletar
    {
        private readonly PagamentosNegocio _pagamentosNegocio = new PagamentosNegocio();

        public int Incluir(Pagamento entidades)
        {
            return _pagamentosNegocio.InserirPagamento(entidades);
        }

        public List<Pagamento> ListarTodos(Pagamento entidade)
        {
            return _pagamentosNegocio.SelecionarPagamentos(entidade);
        }

        public Pagamento Entidade(string codigo)
        {
            var cliente = new Cliente {Documento = codigo};
            var contrato = new Contrato {Cliente = cliente};
            var pagamento = new Pagamento {Contrato = contrato};
            return _pagamentosNegocio.SelecionarPagamentoCliente(pagamento);
        }

        public void EntidadeParametro(List<Pagamento> lista)
        {
            _pagamentosNegocio.AlterarPagamento(lista);
        }

        public void Deletar(string codigo)
        {
            _pagamentosNegocio.DeletarPagamento(codigo);
        }
    }
}

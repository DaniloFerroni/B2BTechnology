using System;
using System.CodeDom;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Teste.ArquivoService;
using B2BSolution.Financeiro.Teste.PagamentoService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B2BSolution.Financeiro.Teste
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void InserirPagamento()
        {
            var contrato = new Contrato
            {
                IdContrato = 3
            };

            var pagamento = new Pagamento
            {
                DataPagamento = DateTime.Now,
                Pago = true,
                ValorGasto = 100m,
                ValorPago = 200m,
                Contrato = contrato
            };

            var pagamentoService = new InserirOf_PagamentoClient("BasicHttpBinding_IInserirOf_Pagamento");
            pagamento.CodigoPagamento = pagamentoService.Incluir(pagamento);

        }

        [TestMethod]
        public void Arquivo()
        {

            var arquivoService = new ParametroListaOf_PagamentoClient("BasicHttpBinding_IParametroListaOf_Pagamento");

        }
    }
}

using System;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B2BSolution.Financeiro.TesteNegocio
{
    [TestClass]
    public class ClienteTeste
    {
        [TestMethod]
        public void SelecionarCliente()
        {
            var cliente = new ClienteNegocio();
            var c = cliente.SelecionarCliente("1234567892");
        }

        [TestMethod]
        public void Contrato()
        {
            var cliente = new ContratoNegocio();
            var c = cliente.SelecionarContrato("1234567892");
        }

        [TestMethod]
        public void Pagamento()
        {
            var cliente = new PagamentosNegocio();
            var contrato = new Contrato
            {
                Cliente = new Cliente
                {
                    Documento = null
                }
            };
            var p = new Pagamento {DataPagamento = Convert.ToDateTime("01-08-2015"), Contrato = contrato};
            var c = cliente.SelecionarPagamentoCliente(p);
        }
    }
}

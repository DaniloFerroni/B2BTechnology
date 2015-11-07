using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Teste.ClienteService;
using B2BSolution.Financeiro.Teste.ContratoService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B2BSolution.Financeiro.Teste
{
    [TestClass]
    public class UnitTest2
    {
        private static List<Contrato> _listaContratos = new List<Contrato>();

        [TestMethod]
        public void Teste2()
        {
            var clienteService = new ListarOf_ContratoClient("BasicHttpBinding_IListarOf_Contrato");
             _listaContratos = clienteService.Listar(null).ToList();
        }

        [TestMethod]
        public void SeleciomarContrato()
        {
            var contratoService = new EntidadeOf_ContratoClient("BasicHttpBinding_IEntidadeOf_Contrato");
            var contrato = contratoService.Entidade("1234567891");
            //var contrato = contratoService.Entidade("1234567891");
        }

        [TestMethod]
        public void SeleciomarCliente()
        {
            var contratoService = new EntidadeOf_ClienteClient("BasicHttpBinding_IEntidadeOf_Cliente");

            var contrato = contratoService.Entidade("1234567891");
        }

        [TestMethod]
        public void Teste()
        {
            var caminhoXml = @"http://localhost:49407/ContratoTesteService.svc/paises/1234567891";
            var xml = XDocument.Load(caminhoXml);
            var xmlSerializer = new XmlSerializer(typeof(Contrato));
            var teste = (Contrato)xmlSerializer.Deserialize(xml.CreateReader());
        }
    }
}

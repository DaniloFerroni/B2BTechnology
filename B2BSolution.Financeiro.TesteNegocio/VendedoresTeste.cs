using System;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using B2BSolution.Financeiro.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TipoVendedores = B2BSolution.Financeiro.Entidades.Enum.Enumeradores.TipoVendedores;

namespace B2BSolution.Financeiro.TesteNegocio
{
    [TestClass]
    public class VendedoresTeste
    {
        //var arquivoService = new ParametroListaOf_PagamentoClient("BasicHttpBinding_IParametroListaOf_Pagamento1");
        [TestMethod]
        public void Inserir()
        {
            var inserir = new VendedoresNegocio();
            var id = inserir.InserirVendedor(CarregarVendedores());
        }
        
        [TestMethod]
        public void SelecionarVendedor()
        {
            var vendedoreNegocio = new VendedoresNegocio();
            var entidade = vendedoreNegocio.SelecionarVendedore("99999999");

            var teste = vendedoreNegocio.ListarVendedores(null);

        }

        [TestMethod]
        public void AlterarVendedor()
        {
            var alterarNegocio = new VendedoresNegocio();

            var vendedor = CarregarVendedores();

            vendedor.IdVendedor = 3;
            vendedor.Contato.IdContato = 17;
            vendedor.Endereco.IdEndereco = 17;

            alterarNegocio.AlterarVendedores(vendedor);
        }

        private Vendedores CarregarVendedores()
        {
            return new Vendedores
            {
                Nome = "Vendedor Nome",
                Ativo = false,
                TipoVendedor = (int)TipoVendedores.Vendedor,
                Comissao = 0.7m,
                Documento = "1234567890",
                Contato = CarregarContato(),
                Endereco = CarregarEndereco(),

            };
        }

        private Contato CarregarContato()
        {
            return new Contato
            {
                Celular = "98765456",
                Email = "TESTE@g.com.br456",
                Nome = "Teste456",
                Telefone = "234561456"
            };
        }

        private Endereco CarregarEndereco()
        {
            return new Endereco
            {
                Bairro = "Bairro456",
                Cep = "09876456",
                Cidade = "Cidade456",
                Estado = "KJ",
                Numero = "123456",
                Rua = "Rua456",

            };
        }
    }
}

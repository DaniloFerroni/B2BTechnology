using System;
using System.Collections.Generic;
//using B2BSolution.Financeiro.DataBase;
//using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Teste.ClienteService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;

namespace B2BSolution.Financeiro.Teste
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{

        //    //var teste = ExecutarComando<Cliente>.RetornarListaTipada("SPR_CLIENTE_SELECIONAR", null);
        //    var teste = ExecutarComando<Equipamentos>.RetornarListaTipada("SPR_EQUIPAMENTOS_SELECIONAR", null);

        //}

        //[TestMethod]
        //public void InserirCliente()
        //{
            
        //    var contato = new Contato
        //    {
        //        Celular = "9999999",
        //        Email = "@t.com",
        //        Nome = "Teste",
        //        Telefone = "44444444"
        //    };
        //    var teste = new ContatoDataBase();
        //    contato.IdContato = teste.Incluir(contato);

        //    var endereco = new Endereco
        //    {
        //        Bairro = "Bairro",
        //        Cep = "Cep",
        //        Cidade = "Cidade",
        //        Complemento = "C",
        //        Estado = "SP",
        //        Numero = "133",
        //        Rua = "Rua"
        //    };
            
        //    var testee = new EnderecoDataBase();
        //    endereco.IdEndereco = testee.Incluir(endereco);

        //    var cliente = new Cliente
        //    {
        //        Nome = "Eu",
        //        TipoPessoa = "F",
        //        Ativo = true,
        //        Endereco = endereco,
        //        Contato = contato
               
        //    };
        //    var t = new ClienteDataBase();
        //    cliente.IdCliente = t.Incluir(cliente);
        //}

        //[TestMethod]
        //public void AlterarCliente()
        //{
        //    var cliente = new ClienteDataBase();
        //    var endereco = new EnderecoDataBase();
        //    var contato = new ContatoDataBase();
        //    var result = cliente.Entidade("2");
        //    result.Ativo = false;
        //    result.Endereco.Numero = "122";
        //    result.Contato.Nome = "Teste Alterar";

        //    endereco.Alterar(result.Endereco);
        //    contato.Alterar(result.Contato);
        //    cliente.Alterar(result);
        //}
        [TestMethod]
        public void ExecutandoServicoCliente()
        {
            //var proxy = new ClienteService(new Uri("http://localhost:53161/NorthwindCustomers.svc"));
            var teste = new EntidadeOf_ClienteClient("BasicHttpBinding_IEntidadeOf_Cliente");
            var t = teste.Entidade("41120348811");

            var clienteService = new AlterarOf_ClienteClient("BasicHttpBinding_IAlterarOf_Cliente");
            clienteService.Alterar(CarregarPropriedadesCliente());
        }

        private Cliente CarregarPropriedadesCliente()
        {
            return new Cliente
            {
                IdCliente = 2,
                Nome = "Danilo r",
                Ativo = true,
                TipoPessoa = true ? "F" : "J",
                Documento = "41120348811",
                Endereco = CarregarPropriedadesEndereco(),
                Contato = CarregarPropriedadesContato()
            };
        }

        private Endereco CarregarPropriedadesEndereco()
        {
            return new Endereco
            {
                IdEndereco = 3,
                Rua = "RUa",
                Numero = "133",
                Complemento = "",
                Bairro = "Baeta",
                Cep = "09751450",
                Cidade = "SBC",
                Estado = "SP"
            };
        }

        private Contato CarregarPropriedadesContato()
        {
            return new Contato
            {
                IdContato = 3,
                Nome = "Eu",
                Email = "da",
                Celular = "1212121",
                Telefone = "434343434"
            };
        }

    }
}

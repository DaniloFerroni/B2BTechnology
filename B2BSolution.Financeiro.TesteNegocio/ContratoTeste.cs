using System;
using System.Runtime.InteropServices;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using B2BSolution.Financeiro.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B2BSolution.Financeiro.TesteNegocio
{
    [TestClass]
    public class ContratoTeste
    {
        [TestMethod]
        public void InserirContrato()
        {


            var inserirContrato = new ContratoNegocio();
            var numero = inserirContrato.InserirContrato(CarregarContrato());
        }

        [TestMethod]
        public void SelecionarContrato()
        {
            
            var selecionarContrato = new ContratoNegocio();
            //var contrato = selecionarContrato.SelecionarContrato("1234567893");
            
            //Assert.AreEqual(contrato.IdContrato, 3);
        }

        [TestMethod]
        public void AlterarContrato()
        {
            var alterarContrato = new ContratoNegocio();
            var c = CarregarContrato();
            c.IdContrato = 5;
            c.Cliente.IdCliente = 14;
            c.Cliente.Endereco.IdEndereco = 16;
            c.Cliente.Contato.IdContato = 16;
            c.Equipamento.IdEquipamento = 3;
            alterarContrato.AlterarContrato(c);
        }

        private Contrato CarregarContrato()
        {
            return new Contrato
            {
                CadenciaMovel = "2",
                CadenciaFixa = "3",
                DataContrato = DateTime.Now,
                DiaVencimento = 2,
                ValorConsumoMinimo = 2.0m,
                ValorInstalacao = 3m,
                //ValorTarifa = 4m,
                Equipamento = CarregarEquipamento(),
                Cliente = CarregarCliente(),
                //PrazoContratual = PrazoContratual.Indeterminado
            };
        }

        private Cliente CarregarCliente()
        {
            return new Cliente
            {
                Ativo = true,
                Documento = "1234567893",
                Nome = "Teste1",
                TipoPessoa = "F",
                Endereco = CarregarEndereco(),
                Contato = CarregarContato()
            };
        }

        private Contato CarregarContato()
        {
            return new Contato
            {
                Celular = "98765123",
                Email = "TESTE@g.com.br123",
                Nome = "Teste123",
                Telefone = "234561237"
            };
        }

        private Equipamentos CarregarEquipamento()
        {
            return new Equipamentos
            {
                Marca = "Marca",
                Modelo = "Modelo",
                NumeroSerie = "1234554",
            };
        }

        private Endereco CarregarEndereco()
        {
            return new Endereco
            {
                Bairro = "Bairro123",
                Cep = "09876123",
                Cidade = "Cidade123",
                Estado = "KJ",
                Numero = "123123",
                Rua = "Rua123",
                
            };
        }
    }
}

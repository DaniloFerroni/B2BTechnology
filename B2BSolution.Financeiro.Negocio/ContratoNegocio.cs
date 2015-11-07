using System;
using System.Collections.Generic;
using System.Linq;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.Negocio
{
    public class ContratoNegocio
    {
        private readonly ClienteNegocio _clienteNegocio;
        //private readonly EquipamentosNegocio _equipamentosNegocio;

        public ContratoNegocio()
        {
            _clienteNegocio = new ClienteNegocio();
            //_equipamentosNegocio = new EquipamentosNegocio();
        }

        private List<Contrato> SelecionarContratos(string codigo)
        {
            try
            {
                var contrato = new ListarCodigo<Contrato>(new ContratoDataBase());
                return contrato.ListarComCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarContratos: ", ex.Message));
            }
        }

        public Contrato SelecionarContrato(string codigo)
        {
            try
            {
                return SelecionarContratos(codigo).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarContrato: ", ex.Message));
            }
        }

        public List<Contrato> SelecionarTodosContrato(string codigo)
        {
            try
            {
                return SelecionarContratos(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarTodosContrato: ", ex.Message));
            }
        }

        public int InserirContrato(Contrato contrato)
        {
            try
            {
                var inserirContrato = new InserirNegocio<Contrato>(new ContratoDataBase());

                var clienteNegocio = new ListarCodigo<Cliente>(new ClienteDataBase());
                var cliente = clienteNegocio.ListarComCodigo(contrato.Cliente.Documento);
                contrato.Cliente.IdCliente = !cliente.Any() ? _clienteNegocio.InserirCliente(contrato.Cliente) : cliente.First().IdCliente;
                //contrato.Equipamento.IdEquipamento = _equipamentosNegocio.InserirEquipamento(contrato.Equipamento);

                return inserirContrato.InserirEntidade(contrato);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirContrato: ", ex.Message));
            }
        }

        public void AlterarContrato(Contrato contrato)
        {
            try
            {
                var alterarContrato = new AlterarNegocio<Contrato>(new ContratoDataBase());
                _clienteNegocio.AlterarCliente(contrato.Cliente);
                alterarContrato.AlterarEntidade(contrato);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("AlterarContrato: ", ex.Message));
            }
        }
    }
}

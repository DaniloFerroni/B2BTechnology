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

        private List<Contrato> SelecionarContratos(Contrato contrato)
        {
            try
            {
                if (contrato == null)
                    contrato = new Contrato
                    {
                        Cliente = new Cliente
                        {
                            Documento = null,
                            Nome = null
                        }
                    };

                var contratoNegocio = new ListarNegocio<Contrato>(new ContratoDataBase());
                return contratoNegocio.ListarEntidade(contrato);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarContratos: ", ex.Message));
            }
        }

        public Contrato SelecionarContrato(Contrato contrato)
        {
            try
            {

                return SelecionarContratos(contrato).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarContrato: ", ex.Message));
            }
        }

        public List<Contrato> SelecionarTodosContrato(Contrato contrato)
        {
            try
            {
                return SelecionarContratos(contrato);
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
                contrato.Cliente.IdCliente = _clienteNegocio.InserirCliente(contrato.Cliente);

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

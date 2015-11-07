using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    public class ClienteNegocio
    {
        private readonly EnderecoNegocio _enderecoNegocio;
        private readonly ContatoNegocio _contatoNegocio;

        public ClienteNegocio()
        {
            _enderecoNegocio = new EnderecoNegocio();
            _contatoNegocio = new ContatoNegocio();
        }

        public List<Cliente> ConsultarCliente(string codigo)
        {
            try
            {
                var clienteNegocio = new ListarCodigo<Cliente>(new ClienteDataBase());
                return clienteNegocio.ListarComCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("ConsultarCliente: ", ex.Message));
            }
        }

        public Cliente SelecionarCliente(string codigo)
        {
            try
            {
                return ConsultarCliente(codigo).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarCliente: ", ex.Message));
            }
        }

        public List<Cliente> SelecionarTodosCliente(string codigo)
        {
            try
            {
                return ConsultarCliente(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarTodosCliente: ", ex.Message));
            }
        }

        public int InserirCliente(Cliente cliente)
        {
            try
            {
                var inserir = new InserirNegocio<Cliente>(new ClienteDataBase());

                cliente.Endereco.IdEndereco = _enderecoNegocio.InserirEndereco(cliente.Endereco);
                cliente.Contato.IdContato = _contatoNegocio.InserirContato(cliente.Contato);

                return inserir.InserirEntidade(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirCliente: ", ex.Message));
            }
        }

        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                var alterar = new AlterarNegocio<Cliente>(new ClienteDataBase());
                _enderecoNegocio.AlterarEndereco(cliente.Endereco);
                _contatoNegocio.AlterarContato(cliente.Contato);
                alterar.AlterarEntidade(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("AlterarCliente: ", ex.Message));
            }
        }
    }
}

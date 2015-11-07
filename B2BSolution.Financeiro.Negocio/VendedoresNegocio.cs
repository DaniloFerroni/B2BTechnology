using System;
using System.Collections.Generic;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.Negocio
{
    public class VendedoresNegocio
    {
        private readonly EnderecoNegocio _enderecoNegocio;
        private readonly ContatoNegocio _contatoNegocio;

        public VendedoresNegocio()
        {
            _enderecoNegocio = new EnderecoNegocio();
            _contatoNegocio = new ContatoNegocio();
        }

        public int InserirVendedor(Vendedores vendedor)
        {
            try
            {
                var inserirVendedor = new InserirNegocio<Vendedores>(new VendedoresDataBase());

                vendedor.Endereco.IdEndereco = _enderecoNegocio.InserirEndereco(vendedor.Endereco);
                vendedor.Contato.IdContato = _contatoNegocio.InserirContato(vendedor.Contato);

                return inserirVendedor.InserirEntidade(vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirVendedor: ", ex.Message));
            }
        }

        public List<Vendedores> ListarVendedores(Vendedores vendedor)
        {
            try
            {
                var vendedores = new ListarNegocio<Vendedores>(new VendedoresDataBase());
                return vendedores.ListarEntidade(vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("ListarVendedores: ", ex.Message));
            }
        }

        public Vendedores SelecionarVendedore(string codigo)
        {
            try
            {
                var vendedores = new SelecionarEntidadeNegocio<Vendedores>(new VendedoresDataBase());
                return vendedores.SelecionarEntidade(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarVendedore: ", ex.Message));
            }
        }

        public void AlterarVendedores(Vendedores vendedores)
        {
            try
            {
                var alterarVendedor = new AlterarNegocio<Vendedores>(new VendedoresDataBase());

                _enderecoNegocio.AlterarEndereco(vendedores.Endereco);
                _contatoNegocio.AlterarContato(vendedores.Contato);

                alterarVendedor.AlterarEntidade(vendedores);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("AlterarVendedores: ", ex.Message));
            }
        }
    }
}

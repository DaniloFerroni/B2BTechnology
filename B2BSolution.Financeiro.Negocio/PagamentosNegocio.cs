using System;
using System.Collections.Generic;
using System.Linq;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.Negocio
{
    public class PagamentosNegocio
    {
        public int InserirPagamento(Pagamento pagamento)
        {
            try
            {
                var inserir = new InserirNegocio<Pagamento>(new PagamentosDataBase());
                return inserir.InserirEntidade(pagamento);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirPagamento: ", ex.Message));
            }
        }

        public Pagamento SelecionarPagamentoCliente(Pagamento pagamento)
        {
            try
            {
                var selecionar = new ListarNegocio<Pagamento>(new PagamentosDataBase());
                return selecionar.ListarEntidade(pagamento).First();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarPagamentoCliente: ", ex.Message));
            }
        }

        public List<Pagamento> SelecionarPagamentos(Pagamento pagamento)
        {
            try
            {
                var selecionar = new ListarNegocio<Pagamento>(new PagamentosDataBase());
                return selecionar.ListarEntidade(pagamento);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarPagamentos: ", ex.Message));
            }
        }

        public void AlterarPagamento(List<Pagamento> listaPagamento)
        {
            try
            {
                var alterarPagamento = new AlterarNegocio<Pagamento>(new PagamentosDataBase());
                listaPagamento.ForEach(alterarPagamento.AlterarEntidade);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("AlterarPagamento: ", ex.Message));
            }
        }

        public void DeletarPagamento(string codigo)
        {
            try
            {
                var deletarPagamento = new DeletarNegocio(new PagamentosDataBase());
                deletarPagamento.Deletar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("DeletarPagamento: ", ex.Message));
            }
        }
    }
}

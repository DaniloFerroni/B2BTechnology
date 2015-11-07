using System;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.Negocio
{
    public class EnderecoNegocio
    {
        public Endereco SelecionarEndereco(string codigo)
        {
            try
            {
                var endereco = new SelecionarEntidadeNegocio<Endereco>(new EnderecoDataBase());
                return endereco.SelecionarEntidade(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarEndereco: ", ex.Message));
            }
        }

        public int InserirEndereco(Endereco endereco)
        {
            try
            {
                var inserir = new InserirNegocio<Endereco>(new EnderecoDataBase());
                return inserir.InserirEntidade(endereco);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirEndereco: ", ex.Message));
            }
        }

        public void AlterarEndereco(Endereco endereco)
        {
            try
            {
                var alterar = new AlterarNegocio<Endereco>(new EnderecoDataBase());
                alterar.AlterarEntidade(endereco);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("AlterarEndereco: ", ex.Message));
            }
        }
    }
}

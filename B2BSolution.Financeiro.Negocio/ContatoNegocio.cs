using System;
using B2BSolution.Financeiro.DataBase;
using B2BSolution.Financeiro.Entidades;

namespace B2BSolution.Financeiro.Negocio
{
    public class ContatoNegocio
    {
        public Contato SelecionarContato(string codigo)
        {
            try
            {
                var contato = new SelecionarEntidadeNegocio<Contato>(new ContatoDataBase());
                return contato.SelecionarEntidade(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("SelecionarContato: ", ex.Message));
            }
        }

        public int InserirContato(Contato contato)
        {
            try
            {
                var inserir = new InserirNegocio<Contato>(new ContatoDataBase());
                return inserir.InserirEntidade(contato);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("InserirContato: ", ex.Message));
            }
        }

        public void AlterarContato(Contato contato)
        {
            try
            {
                var alterar = new AlterarNegocio<Contato>(new ContatoDataBase());
                alterar.AlterarEntidade(contato);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Concat("AlterarContato: ", ex.Message));
            }
        }
    }
}


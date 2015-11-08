using System;
using System.Collections.Generic;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Negocio;

namespace B2BSolution.Financeiro.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ContratoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ContratoService.svc or ContratoService.svc.cs at the Solution Explorer and start debugging.
    public class ContratoService : IEntidade<Contrato>, IInserir<Contrato>, IAlterar<Contrato>, IListarTodos<Contrato>
    {
        private readonly ContratoNegocio _contratoNegocio = new ContratoNegocio();

        public Contrato Entidade(string codigo)
        {
            var contrato = new Contrato
            {
                Cliente = new Cliente
                {
                    Documento = codigo,
                    Nome = null
                }
            };
            return _contratoNegocio.SelecionarContrato(contrato);
        }

        public int Incluir(Contrato entidades)
        {
            return _contratoNegocio.InserirContrato(entidades);
        }

        public void Alterar(Contrato entidade)
        {
            _contratoNegocio.AlterarContrato(entidade);
        }

        public List<Contrato> ListarTodos(Contrato entidade)
        {
            return _contratoNegocio.SelecionarTodosContrato(entidade);
        }
    }
}

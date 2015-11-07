using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2BSolution.Financeiro.Interfaces;

namespace B2BSolution.Financeiro.Negocio
{
    public class DeletarNegocio
    {
        private readonly IDeletar _deletarNegocio;

        public DeletarNegocio(IDeletar deletar)
        {
            _deletarNegocio = deletar;
        }

        public void Deletar(string codigo)
        {
            _deletarNegocio.Deletar(codigo);
        }
    }
}

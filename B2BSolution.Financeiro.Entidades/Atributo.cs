using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BSolution.Financeiro.Entidades
{
    public class Atributo : Attribute
    {
        public string NomeAtributo { get; private set; }

        public Atributo(string nomeColuna)
        {
            NomeAtributo = nomeColuna;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BSolution.Financeiro.Entidades
{
    public class Equipes
    {
        [Atributo("id_equipe")]
        public int id_equipe { get; set; }

        [Atributo("id_vendedor")]
        public Vendedores Vendedores { get; set; }

        [Atributo("id_canal")]
        public List<Vendedores> Canal { get; set; }
    }
}

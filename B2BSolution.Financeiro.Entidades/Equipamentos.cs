using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace B2BSolution.Financeiro.Entidades
{
    public class Equipamentos
    {
        [Atributo("id_equipamento")]
        [DataMember(Name = "id_equipamento")]
        public int IdEquipamento { get; set; }

        [Atributo("marca")]
        [DataMember(Name = "marca")]
        public string Marca { get; set; }

        [Atributo("modelo")]
        [DataMember(Name = "modelo")]
        public string Modelo { get; set; }

        [Atributo("numero_serie")]
        [DataMember(Name = "numero_serie")]
        public string NumeroSerie { get; set; }

    }
}

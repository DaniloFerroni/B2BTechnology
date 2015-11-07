using System;
using System.CodeDom;
using B2BSolution.Financeiro.Interfaces;
using B2BSolution.Financeiro.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B2BSolution.Financeiro.TesteNegocio
{
    [TestClass]
    public class EquipamentosTeste
    {
        [TestMethod]
        public void SelecionarEquipamento()
        {
            var equip = new EquipamentosNegocio();
            var teste = equip.SelecionarEquipamentos(null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Formulario.EquipamentosService;

namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormEquipamentos : Form
    {
        public FormEquipamentos()
        {
            try
            {
                InitializeComponent();
                CarregarGridEquipamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("FormEquipamentos: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Equipamentos CarregarPropriedadesEquipamentos()
        {
            return new Equipamentos
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                NumeroSerie = txtNumeroSerie.Text
            };
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var mensagem = new StringBuilder();
                if (!ValidarDados(mensagem))
                {
                    MessageBox.Show(mensagem.ToString(), "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var equipamentoService = new InserirOf_EquipamentosClient("BasicHttpBinding_IInserirOf_Equipamentos");
                equipamentoService.Incluir(CarregarPropriedadesEquipamentos());
                CarregarGridEquipamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Salvar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Equipamentos> ListarEquipamentos()
        {
            var equipamentoService = new ListarTodosOf_EquipamentosClient("BasicHttpBinding_IListarTodosOf_Equipamentos");
            return equipamentoService.ListarTodos(null).ToList();
        }

        private void CarregarGridEquipamentos()
        {
            try
            {
                dgvEquipamentos.DataSource = ListarEquipamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("CarregarGridEquipamentos: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDados(StringBuilder mensagem)
        {
            if (txtMarca.Text.Equals("")) mensagem.AppendLine("Informe Marca");
            if (txtModelo.Text.Equals("")) mensagem.AppendLine("Informe Modelo");
            if (txtNumeroSerie.Text.Equals("")) mensagem.AppendLine("Informe Numero de Série");

            return mensagem.ToString().Equals("");
        }
    }
}

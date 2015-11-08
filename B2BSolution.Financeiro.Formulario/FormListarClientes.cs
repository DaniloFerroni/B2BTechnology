using System;
using System.Linq;
using System.Windows.Forms;
using B2BSolution.Financeiro.Formulario.ClienteService;
using B2BSolution.Financeiro.Formulario.ContratoService;
using B2BSolution.Financeiro.Formulario.Util;

namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormListarClientes : Form
    {
        public FormListarClientes()
        {
            try
            {
                InitializeComponent();
                var clienteService = new ListarTodosOf_ContratoClient("BasicHttpBinding_IListarTodosOf_Contrato");
                var listaContratos = clienteService.ListarTodos(null).ToList();

                dgvListaCliente.DataSource = (from contrato in listaContratos
                                              select new
                                              {
                                                  Codigo = contrato.Cliente.IdCliente,
                                                  contrato.Cliente.Nome,
                                                  CNPJ_CPF = contrato.Cliente.TipoPessoa.Equals("J") ? contrato.Cliente.Documento.MascaraCnpj() : contrato.Cliente.Documento.MascaraCpf(),
                                                  NomeVendedor = contrato.Vendedor.Nome
                                              })
                                              .OrderBy(c => c.Nome).ToList();
                dgvListaCliente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("FormListarClientes: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var numeroDocumento = dgvListaCliente.Rows[e.RowIndex].Cells["CNPJ_CPF"].Value.ToString().RemoverMascara();
            var nome = dgvListaCliente.Rows[e.RowIndex].Cells["Nome"].Value.ToString().RemoverMascara();
            Close();
            var formCadastro = new FormCadastro(numeroDocumento, nome)
            {
                MdiParent = FormPrincipal.ActiveForm,
            };

            formCadastro.Show();
            formCadastro.WindowState = FormWindowState.Maximized;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using B2BSolution.Financeiro.Formulario.ContratoService;
using B2BSolution.Financeiro.Formulario.PagamentoService;
using B2BSolution.Financeiro.Formulario.Util;

namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormPagamentos : Form
    {
        private static readonly List<Button> ListaBotoesMeses = new List<Button>();
        private static List<Contrato> _listaContratos = new List<Contrato>();
        private static List<Cliente> _listaCliente = new List<Cliente>();
        private static List<Pagamento> _listaPagamento = new List<Pagamento>();

        public FormPagamentos()
        {
            try
            {
                InitializeComponent();
                ListaBotoesMeses.Add(btnMesBase);
                btnMesBase.Text = DateTime.Now.AddMonths(-2).ToString("MM-yyyy");
                var button = CarregarButton(btnMesBase, DateTime.Now.AddMonths(-1).ToString("MM-yyyy"), "button2");
                button = CarregarButton(button, DateTime.Now.ToString("MM-yyyy"), "button3");
                button.BackColor = Color.RoyalBlue;
                button = CarregarButton(button, DateTime.Now.AddMonths(1).ToString("MM-yyyy"), "button4");
                CarregarButton(button, DateTime.Now.AddMonths(2).ToString("MM-yyyy"), "button5");

                var clienteService = new ListarTodosOf_ContratoClient("BasicHttpBinding_IListarTodosOf_Contrato");
                _listaContratos = clienteService.ListarTodos(null).ToList();
                _listaCliente = _listaContratos.Select(c => new Cliente
                {
                    Ativo = c.Cliente.Ativo,
                    Contato = c.Cliente.Contato,
                    Documento = c.Cliente.Documento,
                    Endereco = c.Cliente.Endereco,
                    IdCliente = c.Cliente.IdCliente,
                    Nome = c.Cliente.Nome,
                    TipoPessoa = c.Cliente.TipoPessoa
                }).ToList();

                var listaCliente = new List<Cliente>
                {
                    new Cliente {Documento = null, Nome = "Todos"}
                };
                listaCliente.AddRange(_listaCliente);
                cmbCliente.DataSource = listaCliente;
                cmbCliente.DisplayMember = "Nome";
                cmbCliente.ValueMember = "Documento";

                CarregarPagamentosService();
                CarregarGrid(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("FormPagamentos: ", ex.Message), "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CarregarPagamentosService()
        {
            var pagamentoCliente = new ListarTodosOf_PagamentoClient("BasicHttpBinding_IListarTodosOf_Pagamento");
            var contrato = new Contrato
            {
                Cliente = new Cliente
                {
                    Documento = null,
                }
            };
            _listaPagamento = pagamentoCliente.ListarTodos(new Pagamento
            {
                DataPagamento = btnMesBase.Text.PrimeiroDiaMes(),
                Contrato = contrato
            }).ToList();
        }

        private Button CarregarButton(Button buttonAnterior, string texto, string idName)
        {
            Controls.Add(new Button
            {
                //Location =  Location.(Location.X ,Location.Y),
                Location = new Point(buttonAnterior.Location.X + buttonAnterior.Size.Width, buttonAnterior.Location.Y),
                Name = idName,
                Text = texto,
                Size = buttonAnterior.Size,
                FlatStyle = buttonAnterior.FlatStyle,
                UseVisualStyleBackColor = true,
                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
            });
            var button = (Button) Controls.Find(idName, false).First();
            button.Click += btnMesBase_Click;
            ListaBotoesMeses.Add(button);
            return button;
        }

        private void btnMesBase_Click(object sender, EventArgs e)
        {
            ListaBotoesMeses.ForEach(b => b.BackColor = SystemColors.Control);

            var button = (Button) sender;
            button.BackColor = button.BackColor == Color.RoyalBlue ? SystemColors.Control : Color.RoyalBlue;
            var documento =  cmbCliente.SelectedValue == null? null : cmbCliente.SelectedValue.ToString();
            CarregarGrid(documento);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDocumento())
                    return;

                var pagamentoService = new InserirOf_PagamentoClient("BasicHttpBinding_IInserirOf_Pagamento");
                var pagamento = CarregarPropriedade();
                pagamentoService.Incluir(pagamento);
                CarregarPagamentosService();
                CarregarGrid(cmbCliente.SelectedValue.ToString());
                MessageBox.Show("Pagamento cadastrado com sucesso", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Salvar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidarDocumento()
        {
            if (cmbCliente.SelectedValue.ToString().Length > 14)
            {
                MessageBox.Show("Selecione um Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public Pagamento CarregarPropriedade()
        {
            return new Pagamento
            {
                CodigoPagamento = Convert.ToInt32(lblIdPagamento.Text),
                DataPagamento = ListaBotoesMeses.First(b => b.BackColor == Color.RoyalBlue).Text.PrimeiroDiaMes(),
                Pago = ckbPago.Checked,
                ValorGasto = Convert.ToDecimal(txtValorGasto.Text),
                ValorPago = Convert.ToDecimal(lblValorPagar.Text),
                Contrato = _listaContratos.First(c => c.Cliente.Documento == cmbCliente.SelectedValue.ToString())
            };
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString().Length > 14)
            {
                CarregarGrid(null);
                txtValorGasto.Text = string.Empty;
                lblConsumoMinimo.Text = "0";
                lblValorPagar.Text = "0";
                return;
            }

            var documentoCliente = cmbCliente.SelectedValue.ToString();
            var contrato = _listaContratos.First(c => c.Cliente.Documento == documentoCliente);

            lblConsumoMinimo.Text = contrato.ValorConsumoMinimo.ToString();
            lblMensalidade.Text = contrato.ValorMensalidade.ToString();

            CarregarGrid(documentoCliente);
        }

        private void txtValorGasto_TextChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um Cliente", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var documentoCliente = cmbCliente.SelectedValue.ToString();
            var contrato = _listaContratos.First(c => c.Cliente.Documento == documentoCliente);

            decimal valorGasto;
            decimal.TryParse(txtValorGasto.Text, out valorGasto);

            lblValorPagar.Text = (Convert.ToDecimal(valorGasto > contrato.ValorConsumoMinimo ? txtValorGasto.Text : lblConsumoMinimo.Text) + contrato.ValorMensalidade).ToString();
        }

        private void ckbManterValorGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbManterValorGasto.Checked)
                lblValorPagar.Text = txtValorGasto.Text;
            else
                lblValorPagar.Text = Convert.ToDecimal(txtValorGasto.Text) > Convert.ToDecimal(lblConsumoMinimo.Text)
                    ? txtValorGasto.Text
                    : lblConsumoMinimo.Text;

            lblValorPagar.Text = (Convert.ToDecimal(lblValorPagar.Text) + Convert.ToDecimal(lblMensalidade.Text)).ToString();
        }

        private void CarregarGrid(string documentoCliente)
        {
            var listaComissao = ListaPagamentos(documentoCliente);

            dgvListaPagamento.DataSource = listaComissao;
            dgvListaPagamento.Refresh();

        }

        private IEnumerable ListaPagamentos(string documentoCliente)
        {
            var pagamentos = _listaPagamento.Where(p => (documentoCliente == null || p.Contrato.Cliente.Documento == documentoCliente) &&
                                                        p.DataPagamento == RetornarDataSelecionada()).ToList();

            return (from pagamento in pagamentos
                select new
                {
                    pagamento.CodigoPagamento,
                    pagamento.Contrato.IdContrato,
                    pagamento.Contrato.Cliente.Nome,
                    DataPagamento = pagamento.DataPagamento.ToString("Y"),
                    pagamento.ValorPago,
                    pagamento.Pago
                }).ToList();
        }

        public DateTime RetornarDataSelecionada()
        {
            return ListaBotoesMeses.First(b => b.BackColor == Color.RoyalBlue).Text.PrimeiroDiaMes();
        }

        private void dgvListaPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex != 0) return;

                var deletarService = new DeletarClient("BasicHttpBinding_IDeletar");
                var codigoPagamento = dgvListaPagamento.Rows[e.RowIndex].Cells["CodigoPagamento"].Value.ToString();
                deletarService.Deletar(codigoPagamento);
                CarregarPagamentosService();
                CarregarGrid(cmbCliente.SelectedValue == null ? null : cmbCliente.SelectedValue.ToString());
                MessageBox.Show("Pagamento Exluido Com Sucesso!", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Deletar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                var pagamentosGrid = (from linhaGrid in dgvListaPagamento.Rows.Cast<DataGridViewRow>()
                                      select new Pagamento
                                      {
                                          Contrato = new Contrato
                                          {
                                              Cliente = new Cliente
                                              {
                                                  Nome = linhaGrid.Cells["Nome"].Value.ToString()
                                              }
                                          },
                                          DataPagamento = Convert.ToDateTime(linhaGrid.Cells["DataPagamento"].Value),
                                          ValorPago = Convert.ToDecimal(linhaGrid.Cells["ValorPago"].Value),
                                          Pago = Convert.ToBoolean(linhaGrid.Cells["Pago"].Value),
                                      }).ToList();

                var arquivo = new Arquivo();
                arquivo.GerarPdf(pagamentosGrid, cmbCliente.Text, RetornarDataSelecionada(), TipoPdf.Pagamento);
                MessageBox.Show("Arquivo Gerado com Sucesso!", "Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
} 
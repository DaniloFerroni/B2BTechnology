using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using B2BSolution.Financeiro.Formulario.PagamentoService;
using B2BSolution.Financeiro.Formulario.Util;
using B2BSolution.Financeiro.Formulario.VendedoresService;

namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormComissao : Form
    {
        private static List<Vendedores> _listaVendedores = new List<Vendedores>();
        private static readonly List<Button> ListaBotoesMeses = new List<Button>();
        private static List<Pagamento> _listaPagamento = new List<Pagamento>();

        public FormComissao()
        {
            try
            {
                InitializeComponent();
                ListaBotoesMeses.Add(btnMesBase);
                btnMesBase.Text = DateTime.Now.AddMonths(-2).ToString("MM-yyyy");

                var pagamentoCliente = new ListarTodosOf_PagamentoClient("BasicHttpBinding_IListarTodosOf_Pagamento");
                var contrato = new Contrato
                {
                    Cliente = new Cliente
                    {
                        Documento = null
                    }
                };

                _listaPagamento = pagamentoCliente.ListarTodos(new Pagamento { DataPagamento = btnMesBase.Text.PrimeiroDiaMes(), Contrato = contrato }).ToList();

                var button = CarregarButton(btnMesBase, DateTime.Now.AddMonths(-1).ToString("MM-yyyy"), "button2");
                button = CarregarButton(button, DateTime.Now.ToString("MM-yyyy"), "button3");
                button.BackColor = Color.RoyalBlue;
                button = CarregarButton(button, DateTime.Now.AddMonths(1).ToString("MM-yyyy"), "button4");
                CarregarButton(button, DateTime.Now.AddMonths(2).ToString("MM-yyyy"), "button5");
            
                CarregarComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("FormComissao: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarComboBox()
        {
            try
            {
                var listaVendedores = new ListarTodosOf_VendedoresClient("BasicHttpBinding_IListarTodosOf_Vendedores");
                _listaVendedores = listaVendedores.ListarTodos(new Vendedores{Documento = null, Ativo = true}).ToList();
                var listaCambo = new List<Vendedores>
                {
                    new Vendedores{IdVendedor = 0, Nome = "Selecione..."}
                };
                listaCambo.AddRange(_listaVendedores.Where(v => v.TipoVendedor == (int)TipoVendedores.Vendedor).ToList());

                cmbVendedores.DataSource = listaCambo;
                cmbVendedores.DisplayMember = "Nome";
                cmbVendedores.ValueMember = "IdVendedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("CarregarComboBox: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            var button = (Button)Controls.Find(idName, false).First();
            button.Click += btnMesBase_Click;
            ListaBotoesMeses.Add(button);
            return button;
        }

        private void btnMesBase_Click(object sender, EventArgs e)
        {
            ListaBotoesMeses.ForEach(b => b.BackColor = SystemColors.Control);

            var button = (Button)sender;
            button.BackColor = button.BackColor == Color.RoyalBlue ? SystemColors.Control : Color.RoyalBlue;
            CarregarGrid(cmbVendedores.SelectedValue.ToString());
        }

        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVendedores.Text.Equals("Selecione..."))
            {
                CarregarCombos(cmbCanal, new List<Vendedores>(), "Nome", "IdVendedor");
                return;
            }
            //var listaCambo = new List<Vendedores>
            //{
            //    new Vendedores{IdVendedor = 0, Nome = "Selecione..."}
            //};
            var listaCanal = _listaVendedores.Where(v => v.TipoVendedor == (int) TipoVendedores.Canal && v.Superior.ToString() == cmbVendedores.SelectedValue.ToString()).ToList();

            //listaCambo.AddRange(listaCanal);
            //cmbCanal.DataSource = listaCambo;
            //cmbCanal.DisplayMember = "Nome";
            //cmbCanal.ValueMember = "IdVendedor";
            CarregarCombos(cmbCanal, listaCanal, "Nome", "IdVendedor");
            CarregarGrid(cmbVendedores.SelectedValue.ToString());
        }

        private static void CarregarCombos(ComboBox comboBox, IEnumerable<Vendedores> lista, string displayMember, string valor)
        {
            var listaCambo = new List<Vendedores>
            {
                new Vendedores{IdVendedor = 0, Nome = "Selecione..."}
            };

            listaCambo.AddRange(lista);
            comboBox.DataSource = listaCambo;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valor;
        }

        private void CarregarGrid(string canal)
        {
            var listaComissao = ListaDadosComissao(canal);

            dgvComissao.DataSource = listaComissao.ToList();
            dgvComissao.Refresh();

        }

        private List<DadosComissao> ListaDadosComissao(string canal)
        {
            int idCanal;
            int.TryParse(canal, out idCanal);

            var codigo = idCanal == 0 ? (int?) null : Convert.ToInt32(canal);
            var mesSelecionado = RetornarDataSelecionada();

            var listaComissao = _listaPagamento.Where(p => (codigo == null ||
                                                            p.Contrato.Vendedor.IdVendedor == codigo ||
                                                            p.Contrato.Vendedor.Superior == codigo) &&
                                                           p.DataPagamento == mesSelecionado)
                .Select(c => new DadosComissao
                {
                    CodigoPagamento = c.CodigoPagamento,
                    NomeCliente = c.Contrato.Cliente.Nome,
                    ValorPagar = ValorPago(c.Contrato.Vendedor.IdVendedor),
                    Pago = c.Pago,
                    Comissao = Comissao(c.Contrato, idCanal),
                });
            return listaComissao.ToList();
        }

        private string ValorPago(int codgioVendedor)
        {
            var mesSelecionado = RetornarDataSelecionada();
            var pagamento = _listaPagamento.FirstOrDefault(p => p.Contrato.Vendedor.IdVendedor == codgioVendedor && p.DataPagamento == mesSelecionado);

            return pagamento == null ? "" : pagamento.ValorPago.ToString("C");
        }

        private string Comissao(Contrato contrato, int idVendedor)
        {
            var mesSelecionado = RetornarDataSelecionada();
            var pagamento = _listaPagamento.FirstOrDefault(p => p.Contrato.IdContrato == contrato.IdContrato && p.DataPagamento == mesSelecionado);
            var vendedor = _listaVendedores.FirstOrDefault(v => v.IdVendedor == idVendedor);

            if (pagamento == null) return "";
            var percentualComissao = contrato.Vendedor.Comissao;
            if (vendedor == null) return "";

            return vendedor.TipoVendedor == (int)TipoVendedores.Vendedor && contrato.Vendedor.TipoVendedor == (int)TipoVendedores.Canal ?
                (((pagamento.ValorPago - pagamento.ValorPago * (decimal)0.06) * 5) / 100).ToString("C") :
                (((pagamento.ValorPago - pagamento.ValorPago * (decimal)0.06) * percentualComissao) / 100).ToString("C");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var efetuadoPagamento = ListaPagamentosEfetuados();

                if (!efetuadoPagamento.Any()) return;

                var alterarPagamento = new ParametroListaOf_PagamentoClient("BasicHttpBinding_IParametroListaOf_Pagamento");
                alterarPagamento.EntidadeParametro(efetuadoPagamento.ToArray());

                MessageBox.Show("Pagamento alterado com sucesso!", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Salvar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Pagamento> ListaPagamentosEfetuados()
        {
            var mesSelecionado = RetornarDataSelecionada();
            var pagamentosGrid = (from linhaGrid in dgvComissao.Rows.Cast<DataGridViewRow>()
                select new Pagamento
                {
                    CodigoPagamento = Convert.ToInt32(linhaGrid.Cells["CodigoPagamento"].Value),
                    Pago = Convert.ToBoolean(linhaGrid.Cells["Pago"].Value),
                }).ToList();

            var efetuadoPagamento = (from linhaGrid in pagamentosGrid
                join pagamento in _listaPagamento
                    on linhaGrid.CodigoPagamento equals pagamento.CodigoPagamento
                where !pagamento.Pago &&
                      linhaGrid.Pago
                select new Pagamento
                {
                    CodigoPagamento = linhaGrid.CodigoPagamento,
                    Contrato = pagamento.Contrato,
                    DataPagamento = mesSelecionado,
                    Pago = linhaGrid.Pago,
                    ValorGasto = pagamento.ValorGasto,
                    ValorPago = pagamento.ValorPago
                }).ToList();
            return efetuadoPagamento;
        }

        public DateTime RetornarDataSelecionada()
        {
            return ListaBotoesMeses.First(b => b.BackColor == Color.RoyalBlue).Text.PrimeiroDiaMes();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                var codigoVendedor = !cmbCanal.SelectedValue.ToString().Equals("0") ? cmbCanal.SelectedValue.ToString() : cmbVendedores.SelectedValue.ToString();
                var nomeVendedor = !cmbCanal.SelectedValue.ToString().Equals("0") ? cmbCanal.Text : cmbVendedores.Text;
                var listaDadosComissao = ListaDadosComissao(codigoVendedor);
                var arquivo = new Arquivo();
                arquivo.GerarPdf(listaDadosComissao, nomeVendedor, RetornarDataSelecionada(), TipoPdf.Comissao);
                MessageBox.Show("Arquivo Gerado com Sucesso!", "Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Gerar PDF: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vendedor = !cmbCanal.SelectedValue.ToString().Equals("0") ? cmbCanal.SelectedValue.ToString() : cmbVendedores.SelectedValue.ToString();
            CarregarGrid(vendedor);
        }

    }
}
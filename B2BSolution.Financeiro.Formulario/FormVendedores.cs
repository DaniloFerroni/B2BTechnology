using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using B2BSolution.Financeiro.Formulario.Util;
using B2BSolution.Financeiro.Formulario.VendedoresService;
//using TipoVendedores = B2BSolution.Financeiro.Entidades.Enum.Enumeradores.TipoVendedores;


namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormVendedores : Form
    {
        public FormVendedores()
        {
            try
            {
                InitializeComponent();
                var listavendedores = new List<Vendedores>
                {
                    new Vendedores {IdVendedor = 0, Nome = "Selecione"}
                };
                var vendedoresService = new ListarTodosOf_VendedoresClient("BasicHttpBinding_IListarTodosOf_Vendedores");
                var vendedor = vendedoresService.ListarTodos(new Vendedores{Ativo = true}).Where(v => v.TipoVendedor == (int)TipoVendedores.Vendedor).ToList();

                listavendedores.AddRange(vendedor);

                cmbVendedores.DataSource = listavendedores;
                cmbVendedores.DisplayMember = "Nome";
                cmbVendedores.ValueMember = "IdVendedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("FormCadastro: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var mensagem = new StringBuilder();
                var valido = ValidarDados(mensagem);
                if (!valido)
                {
                    MessageBox.Show(mensagem.ToString(), "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ("0".Equals(lblIdVendedor.Text))
                    InserirVendedores();
                else
                    AlterarVendedores();

                MessageBox.Show(@"Cadastro Efetuado Com Sucesso!", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Salvar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterarVendedores()
        {
            var clienteService = new AlterarOf_VendedoresClient("BasicHttpBinding_IAlterarOf_Vendedores");
            var vendedores = CarregarPropriedadesVendedores();
            clienteService.Alterar(vendedores);
        }

        private void InserirVendedores()
        {
            var clienteService = new InserirOf_VendedoresClient("BasicHttpBinding_IInserirOf_Vendedores");
            var codigoVendedor = clienteService.Incluir(CarregarPropriedadesVendedores());
            lblIdVendedor.Text = codigoVendedor.ToString();
        }

        private Vendedores CarregarPropriedadesVendedores()
        {
            return new Vendedores
            {
                Endereco = CarregarPropriedadesEndereco(),
                Contato = CarregarPropriedadesContato(),
                Documento = txtDocumento.Text.RemoverMascara(),
                Nome = txtRazaoSocial.Text,
                Comissao = Convert.ToDecimal(txtComissao.Text),
                TipoVendedor = rbCanal.Checked ? (int)TipoVendedores.Canal : (int)TipoVendedores.Vendedor,
                Ativo = true,
                IdVendedor = Convert.ToInt32(lblIdVendedor.Text),
                Superior = Convert.ToInt32(cmbVendedores.SelectedValue)
            };
        }

        private Endereco CarregarPropriedadesEndereco()
        {
            return new Endereco
            {
                IdEndereco = Convert.ToInt32(lblIdEndereco.Text),
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cep = txtCep.Text,
                Cidade = txtCidade.Text,
                Estado = txtUf.Text
            };
        }

        private Contato CarregarPropriedadesContato()
        {
            return new Contato
            {
                IdContato = Convert.ToInt32(lblIdContato.Text),
                Nome = txtContato.Text,
                Email = txtEmail.Text,
                Celular = txtCelular.Text.RemoverMascara().Replace(" ", ""),
                Telefone = txtTelefone.Text.Replace(" ", "")
            };
        }

        private void MostrarPropriedadesVendedores(Vendedores vendedores)
        {
            txtDocumento.Text = vendedores.Documento;
            txtRazaoSocial.Text = vendedores.Nome;
            txtComissao.Text = vendedores.Comissao.ToString();
            rbCanal.Checked = vendedores.TipoVendedor == (int) TipoVendedores.Canal;
            rbVendedor.Checked = vendedores.TipoVendedor == (int) TipoVendedores.Vendedor;
            vendedores.Ativo = true;
            lblIdVendedor.Text = vendedores.IdVendedor.ToString();
            cmbVendedores.SelectedValue = vendedores.Superior;
            MostrarPropriedadeEndereco(vendedores.Endereco);
            MostrarPropriedadeContato(vendedores.Contato);
        }

        private void MostrarPropriedadeEndereco(Endereco endereco)
        {
            txtRua.Text = endereco.Rua;
            txtNumero.Text = endereco.Numero;
            txtComplemento.Text = endereco.Complemento;
            txtCidade.Text = endereco.Cidade;
            txtCep.Text = endereco.Cep;
            txtBairro.Text = endereco.Bairro;
            txtUf.Text = endereco.Estado;
            lblIdEndereco.Text = endereco.IdEndereco.ToString();
        }

        private void MostrarPropriedadeContato(Contato contato)
        {
            txtContato.Text = contato.Nome;
            txtEmail.Text = contato.Email;
            txtTelefone.Text = contato.Telefone;
            txtCelular.Text = contato.Celular;
            lblIdContato.Text = contato.IdContato.ToString(CultureInfo.InvariantCulture);
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {
                var endereco = new Endereco().BuscarCep(txtCep.Text);
                
                if (string.IsNullOrEmpty(endereco.Rua.Trim()))
                {
                    MostrarPropriedadeEndereco(endereco);
                    MessageBox.Show("CEP não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                endereco.IdEndereco = Convert.ToInt32(lblIdEndereco.Text);
                MostrarPropriedadeEndereco(endereco);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Pesquisar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                var vendedoresService = new EntidadeOf_VendedoresClient("BasicHttpBinding_IEntidadeOf_Vendedores");
                var vendedor = vendedoresService.Entidade(txtDocumento.Text.RemoverMascara());
                
                if (vendedor.Documento == null)
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarPropriedadesVendedores(vendedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Pesquisar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarDados(StringBuilder mensagem)
        {
            if (txtDocumento.Text.RemoverMascara().Equals("")) mensagem.AppendLine("Informe o CNPJ/CPF");
            if (txtRazaoSocial.Text.Equals("")) mensagem.AppendLine("Informe o Nome");

            var listaCamposEndereco = new List<string>
            {
                txtRua.Name, txtNumero.Name, txtBairro.Name, txtCidade.Name, txtUf.Name, txtCep.Name
            };

            listaCamposEndereco.ForEach(c => ValidarCamposGroupBox(c, mensagem, grbEndereco));

            var listaCamposContato = new List<string>
            {
                txtContato.Name, txtEmail.Name
            };

            listaCamposContato.ForEach(c => ValidarCamposGroupBox(c, mensagem, grbContato));
            if (rbCanal.Checked && cmbVendedores.SelectedValue.Equals(0)) mensagem.AppendLine("Informe o nome do Vendedor");

            var valido = mensagem.ToString().Equals("");
            return valido;
        }

        private void ValidarCamposGroupBox(string campo, StringBuilder mensagem, GroupBox groupBox)
        {
            var controle = groupBox.Controls.Find(campo, true).FirstOrDefault();
            if (controle == null) return;
            if ((controle).Text.Equals("")) mensagem.AppendLine(string.Concat("Informe o ", controle.Name.Replace("txt", "")));

        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            txtComissao.Text = rbVendedor.Checked ? "10,00" : "5,00";
            cmbVendedores.Enabled = rbCanal.Checked;
            cmbVendedores.SelectedIndex = 0;
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumento.Mask = rbPessoaFisica.Checked ? "000.000.000-00" : "00.000.000/0000-00";
        }
    }
}

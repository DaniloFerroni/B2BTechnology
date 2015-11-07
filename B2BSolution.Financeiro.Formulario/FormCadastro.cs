using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using B2BSolution.Financeiro.Entidades;
using B2BSolution.Financeiro.Entidades.Enum;
using B2BSolution.Financeiro.Formulario.ContratoService;
using B2BSolution.Financeiro.Formulario.EquipamentosService;
using B2BSolution.Financeiro.Formulario.Util;
using B2BSolution.Financeiro.Formulario.VendedoresService;
//using PrazoContratual = B2BSolution.Financeiro.Entidades.Enum.Enumeradores.PrazoContratual;

namespace B2BSolution.Financeiro.Formulario
{
    public partial class FormCadastro : Form
    {
        public FormCadastro(string documento)
        {
            InitializeComponent();
            CarregarCombos();
            SelecionarCliente(documento);
        }

        public FormCadastro()
        {
            try
            {
                InitializeComponent();
                CarregarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("FormCadastro: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarPropriedadeCliente(Cliente cliente)
        {
            txtNomePessoa.Text = cliente.Nome;
            txtDocumento.Text = cliente.Documento;
            rbPessoaFisica.Checked = "F".Equals(cliente.TipoPessoa);
            rbPessoaJuridica.Checked = "J".Equals(cliente.TipoPessoa);
            lblIdCliente.Text = cliente.IdCliente.ToString();

            MostrarPropriedadeEndereco(cliente.Endereco);
            MostrarPropriedadeContato(cliente.Contato);
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

        private void MostrarPropriedadesContrato(Contrato contrato)
        {
            lblIdContrato.Text = contrato.IdContrato.ToString();
            dtpDataContrato.Value = contrato.DataContrato;
            MostrarPropriedadeCliente(contrato.Cliente);
            txtCadenciaFixa.Text = contrato.CadenciaFixa;
            txtCadenciaMovel.Text = contrato.CadenciaMovel;
            txtConsumoMinimo.Text = contrato.ValorConsumoMinimo.ToString();
            txtValorTarifaLdn.Text = contrato.ValorTarifaLdn.ToString();
            txtValorTarifaLocal.Text = contrato.ValorTarifaLocal.ToString();
            txtValorTarifaVc1.Text = contrato.ValorTarifaVc1.ToString();
            txtValorTarifaVc2.Text = contrato.ValorTarifaVc2.ToString();
            txtValorTarifaVc3.Text = contrato.ValorTarifaVc3.ToString();
            txtValorInstalacao.Text = contrato.ValorInstalacao.ToString();
            txtMensalidade.Text = contrato.ValorMensalidade.ToString();
            if (contrato.Equipamento != null) cmbEquipamento.SelectedValue = contrato.Equipamento.IdEquipamento;
            if (contrato.Vendedor != null) cmbVendedores.SelectedValue = contrato.Vendedor.IdVendedor;

            rbt5.Checked = "5".Equals(contrato.DiaVencimento.ToString());
            rbt10.Checked = "10".Equals(contrato.DiaVencimento.ToString());
            rbt15.Checked = "15".Equals(contrato.DiaVencimento.ToString());

            rbtSeisMeses.Checked = ((int)PrazoContratual.SeisMeses).Equals(contrato.PrazoContratual);
            rbtDozeMeses.Checked = ((int)PrazoContratual.DozeMeses).Equals(contrato.PrazoContratual);
            rbtVinteQuatroMeses.Checked = ((int)PrazoContratual.VinteQuatroMeses).Equals(contrato.PrazoContratual);
            rbtIndeterminado.Checked = ((int)PrazoContratual.Indeterminado).Equals(contrato.PrazoContratual);
        }

        private Cliente CarregarPropriedadesCliente()
        {
            return new Cliente
            {
                IdCliente = Convert.ToInt32(lblIdCliente.Text),
                Nome = txtNomePessoa.Text,
                Ativo = true,
                TipoPessoa = rbPessoaFisica.Checked ? "F" : "J",
                Documento = txtDocumento.Text.RemoverMascara(),
                Endereco = CarregarPropriedadesEndereco(),
                Contato = CarregarPropriedadesContato()
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
                Telefone = txtTelefone.Text.RemoverMascara().Replace(" ", "")
            };
        }

        private Contrato CarregarPropriedadesContrato()
        {
            return new Contrato
            {
                IdContrato = Convert.ToInt32(lblIdContrato.Text),
                DataContrato = dtpDataContrato.Value,
                Cliente = CarregarPropriedadesCliente(),
                CadenciaFixa = txtCadenciaFixa.Text,
                CadenciaMovel = txtCadenciaMovel.Text,
                ValorConsumoMinimo = decimal.Parse(txtConsumoMinimo.Text.Replace(".", "")),
                ValorTarifaLocal = Convert.ToDecimal(txtValorTarifaLocal.Text.Replace(".", ",")),
                ValorTarifaLdn = Convert.ToDecimal(txtValorTarifaLdn.Text.Replace(".", ",")),
                ValorTarifaVc1 = Convert.ToDecimal(txtValorTarifaVc1.Text.Replace(".", ",")),
                ValorTarifaVc2 = Convert.ToDecimal(txtValorTarifaVc2.Text.Replace(".", ",")),
                ValorTarifaVc3 = Convert.ToDecimal(txtValorTarifaVc3.Text.Replace(".", ",")),
                ValorMensalidade = Convert.ToDecimal(txtMensalidade.Text.Replace(".", ",")),
                ValorInstalacao = !string.IsNullOrEmpty(txtValorInstalacao.Text) ? Convert.ToDecimal(txtValorInstalacao.Text) : 0,
                Equipamento = CarregarPropriedadesEquipamentos(),
                DiaVencimento = Convert.ToInt32(SelecionarDiaVencimento().Text),
                PrazoContratual = SelecionarPrazoContratual(SelecionarRadioButtonPrazoContratual()),
                Vendedor = new Vendedores
                {
                    IdVendedor = Convert.ToInt32(cmbVendedores.SelectedValue.ToString()),
                    Nome = cmbVendedores.Text
                }
            };
        }

        private Equipamentos CarregarPropriedadesEquipamentos()
        {
            return cmbEquipamento.SelectedValue.Equals(0) ? null : new Equipamentos
                                                                    {
                                                                        IdEquipamento = int.Parse(cmbEquipamento.SelectedValue.ToString()),
                                                                        Modelo = cmbEquipamento.SelectedText
                                                                    };
        }

        private void AlterarCadastro()
        {
            var contratoService = new AlterarOf_ContratoClient("BasicHttpBinding_IAlterarOf_Contrato");
            contratoService.Alterar(CarregarPropriedadesContrato());
        }

        private void InserirCadastro()
        {
            var contratoService = new InserirOf_ContratoClient("BasicHttpBinding_IInserirOf_Contrato");
            contratoService.Incluir(CarregarPropriedadesContrato());
        }

        private List<Equipamentos> CarregarEquipamentos()
        {
            var equipamentosService = new ListarTodosOf_EquipamentosClient("BasicHttpBinding_IListarTodosOf_Equipamentos");
            return equipamentosService.ListarTodos(null).ToList();
        }

        private void CarregarCombos()
        {
            var listEquipamenos = new List<Equipamentos>
            {
                new Equipamentos{IdEquipamento = 0, Marca = "Selecione"},
            };
            listEquipamenos.AddRange(CarregarEquipamentos());
            cmbEquipamento.DataSource = listEquipamenos;
            cmbEquipamento.DisplayMember = "marca";
            cmbEquipamento.ValueMember = "idequipamento";

            var listaVendedores = new List<Vendedores>
            {
                new Vendedores{IdVendedor = 0, Nome = "Selecione"}
            };
            listaVendedores.AddRange(SelecionarVendedores());

            cmbVendedores.DataSource = listaVendedores;
            cmbVendedores.DisplayMember = "nome";
            cmbVendedores.ValueMember = "IdVendedor";

        }

        private RadioButton SelecionarDiaVencimento()
        {
            var listDiaVencimento = new List<RadioButton>
            {
                rbt5,
                rbt10,
                rbt15
            };

            return listDiaVencimento.FirstOrDefault(r => r.Checked);
        }

        private int SelecionarPrazoContratual(RadioButton radioButton)
        {
            if (radioButton.Text.Equals(rbtSeisMeses.Text))
                return ((int) PrazoContratual.SeisMeses);

            if (radioButton.Text.Equals(rbtDozeMeses.Text))
                return ((int)PrazoContratual.DozeMeses);

            if (radioButton.Text.Equals(rbtVinteQuatroMeses.Text))
                return ((int)PrazoContratual.VinteQuatroMeses);

            if (radioButton.Text.Equals(rbtIndeterminado.Text))
                return ((int)PrazoContratual.Indeterminado);

            return 0;
        }

        private RadioButton SelecionarRadioButtonPrazoContratual()
        {
            var listPrazoContratual = new List<RadioButton>
            {
                rbtSeisMeses,
                rbtDozeMeses,
                rbtVinteQuatroMeses,
                rbtIndeterminado
            };

            return listPrazoContratual.FirstOrDefault(r => r.Checked);
        }

        private List<Vendedores> SelecionarVendedores()
        {
            var vendedoresService = new ListarTodosOf_VendedoresClient("BasicHttpBinding_IListarTodosOf_Vendedores");
            return vendedoresService.ListarTodos(new Vendedores {Ativo = true}).ToList();
        }

        public bool ValidarDados(StringBuilder mensagem)
        {
            if (txtDocumento.Text.RemoverMascara().Equals("")) mensagem.AppendLine("Informe o CNPJ/CPF");
            if (txtNomePessoa.Text.Equals("")) mensagem.AppendLine("Informe o Nome");

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

            var listaCamposValorTarifa = new List<string>
            {
                txtValorTarifaLdn.Name, txtValorTarifaLocal.Name, txtValorTarifaVc1.Name, txtValorTarifaVc2.Name, txtValorTarifaVc3.Name
            };
            listaCamposValorTarifa.ForEach(c => ValidarCamposGroupBox(c, mensagem, gpbValorTarifa));


            if (txtCadenciaMovel.Text.Equals("")) mensagem.AppendLine("Informe Cadência Movel");
            if (txtCadenciaFixa.Text.Equals("")) mensagem.AppendLine("Informe Cadência Fixa");
            if (txtConsumoMinimo.Text.Equals("")) mensagem.AppendLine("Informe Consumo Mínimo");
            if (txtMensalidade.Text.Equals("")) mensagem.AppendLine("Informe Mensalidade");

            if(SelecionarDiaVencimento() == null) mensagem.AppendLine("Informe Dia de Vencimento");
            if (SelecionarRadioButtonPrazoContratual() == null) mensagem.AppendLine("Informe Prazo Contratual");
            if (cmbVendedores.SelectedValue.Equals(0)) mensagem.AppendLine("Informe Vendedor");

            var valido = mensagem.ToString().Equals("");
            return valido;
        }

        private void ValidarCamposGroupBox(string campo, StringBuilder mensagem, GroupBox groupBox)
        {
            var controle = groupBox.Controls.Find(campo, true).FirstOrDefault();
            if(controle == null) return;
            if ((controle).Text.Equals("")) mensagem.AppendLine(string.Concat("Informe o ", controle.Name.Replace("txt", "")));

        }

        #region Eventos

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SelecionarCliente(txtDocumento.Text.RemoverMascara());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Pesquisar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelecionarCliente(string documento)
        {
            try
            {
                var contratoService = new EntidadeOf_ContratoClient("BasicHttpBinding_IEntidadeOf_Contrato");
                var contrato = contratoService.Entidade(documento);

                if (contrato == null)
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MostrarPropriedadesContrato(contrato);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("SelecionarCliente: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (!"0".Equals(lblIdContrato.Text))
                    AlterarCadastro();
                else
                    InserirCadastro();

                MessageBox.Show(@"Cadastro Efetuado Com Sucesso!", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Salvar: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(string.Concat("Buscar CEP: ", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumento.Mask = rbPessoaFisica.Checked ? "000.000.000-00" : "00.000.000/0000-00";
        }

        #endregion
    }
}
namespace B2BSolution.Financeiro.Formulario
{
    partial class FormVendedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedores));
            this.grbContato = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblIdContato = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.lblIdEndereco = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCanal = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.btnPesquisarVendedor = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.grbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.grbContato.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbTipoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbContato
            // 
            this.grbContato.Controls.Add(this.txtCelular);
            this.grbContato.Controls.Add(this.lblIdContato);
            this.grbContato.Controls.Add(this.txtTelefone);
            this.grbContato.Controls.Add(this.txtEmail);
            this.grbContato.Controls.Add(this.txtContato);
            this.grbContato.Controls.Add(this.lblEmail);
            this.grbContato.Controls.Add(this.lblTelefone);
            this.grbContato.Controls.Add(this.lblCelular);
            this.grbContato.Controls.Add(this.lblContato);
            this.grbContato.Location = new System.Drawing.Point(13, 210);
            this.grbContato.Name = "grbContato";
            this.grbContato.Size = new System.Drawing.Size(804, 101);
            this.grbContato.TabIndex = 9;
            this.grbContato.TabStop = false;
            this.grbContato.Text = "Contato";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(240, 71);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(95, 20);
            this.txtCelular.TabIndex = 70;
            // 
            // lblIdContato
            // 
            this.lblIdContato.AutoSize = true;
            this.lblIdContato.Location = new System.Drawing.Point(785, 16);
            this.lblIdContato.Name = "lblIdContato";
            this.lblIdContato.Size = new System.Drawing.Size(13, 13);
            this.lblIdContato.TabIndex = 8;
            this.lblIdContato.Text = "0";
            this.lblIdContato.Visible = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(67, 71);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 69;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(56, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(56, 19);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(263, 20);
            this.txtContato.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 74);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(190, 74);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(45, 13);
            this.lblCelular.TabIndex = 1;
            this.lblCelular.Text = "Celular: ";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(6, 22);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(41, 13);
            this.lblContato.TabIndex = 0;
            this.lblContato.Text = "Nome: ";
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.btnBuscarCep);
            this.grbEndereco.Controls.Add(this.lblIdEndereco);
            this.grbEndereco.Controls.Add(this.lblComplemento);
            this.grbEndereco.Controls.Add(this.txtComplemento);
            this.grbEndereco.Controls.Add(this.txtUf);
            this.grbEndereco.Controls.Add(this.txtCep);
            this.grbEndereco.Controls.Add(this.txtNumero);
            this.grbEndereco.Controls.Add(this.lblUf);
            this.grbEndereco.Controls.Add(this.lblCep);
            this.grbEndereco.Controls.Add(this.lblNumero);
            this.grbEndereco.Controls.Add(this.lblCidade);
            this.grbEndereco.Controls.Add(this.lblBairro);
            this.grbEndereco.Controls.Add(this.txtCidade);
            this.grbEndereco.Controls.Add(this.txtBairro);
            this.grbEndereco.Controls.Add(this.txtRua);
            this.grbEndereco.Controls.Add(this.lblRua);
            this.grbEndereco.Location = new System.Drawing.Point(13, 91);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(804, 113);
            this.grbEndereco.TabIndex = 8;
            this.grbEndereco.TabStop = false;
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Location = new System.Drawing.Point(498, 46);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarCep.TabIndex = 16;
            this.btnBuscarCep.Text = "...";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // lblIdEndereco
            // 
            this.lblIdEndereco.AutoSize = true;
            this.lblIdEndereco.Location = new System.Drawing.Point(785, 16);
            this.lblIdEndereco.Name = "lblIdEndereco";
            this.lblIdEndereco.Size = new System.Drawing.Size(13, 13);
            this.lblIdEndereco.TabIndex = 14;
            this.lblIdEndereco.Text = "0";
            this.lblIdEndereco.Visible = false;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(498, 25);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento.TabIndex = 13;
            this.lblComplemento.Text = "Complemento: ";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(581, 22);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 20);
            this.txtComplemento.TabIndex = 12;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(392, 73);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(58, 20);
            this.txtUf.TabIndex = 11;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(392, 48);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 10;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(392, 22);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(337, 77);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(27, 13);
            this.lblUf.TabIndex = 8;
            this.lblUf.Text = "UF: ";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(337, 51);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 13);
            this.lblCep.TabIndex = 7;
            this.lblCep.Text = "CEP: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(336, 25);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero: ";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 77);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 51);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 13);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro: ";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(67, 74);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(263, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(67, 48);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(263, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(67, 22);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(263, 20);
            this.txtRua.TabIndex = 1;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(6, 25);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(59, 13);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Endereço: ";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(696, 12);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedores.TabIndex = 27;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(80, 64);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(48, 20);
            this.txtComissao.TabIndex = 26;
            this.txtComissao.Text = "5,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Comissão(%): ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCanal);
            this.groupBox3.Controls.Add(this.rbVendedor);
            this.groupBox3.Location = new System.Drawing.Point(648, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 49);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Pessoa";
            // 
            // rbCanal
            // 
            this.rbCanal.AutoSize = true;
            this.rbCanal.Checked = true;
            this.rbCanal.Location = new System.Drawing.Point(109, 19);
            this.rbCanal.Name = "rbCanal";
            this.rbCanal.Size = new System.Drawing.Size(52, 17);
            this.rbCanal.TabIndex = 1;
            this.rbCanal.TabStop = true;
            this.rbCanal.Text = "Canal";
            this.rbCanal.UseVisualStyleBackColor = true;
            this.rbCanal.CheckedChanged += new System.EventHandler(this.rbVendedor_CheckedChanged);
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(8, 19);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 0;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            this.rbVendedor.CheckedChanged += new System.EventHandler(this.rbVendedor_CheckedChanged);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(80, 38);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(268, 20);
            this.txtRazaoSocial.TabIndex = 23;
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(12, 42);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(41, 13);
            this.lblNomeVendedor.TabIndex = 22;
            this.lblNomeVendedor.Text = "Nome: ";
            // 
            // btnPesquisarVendedor
            // 
            this.btnPesquisarVendedor.Location = new System.Drawing.Point(258, 10);
            this.btnPesquisarVendedor.Name = "btnPesquisarVendedor";
            this.btnPesquisarVendedor.Size = new System.Drawing.Size(28, 23);
            this.btnPesquisarVendedor.TabIndex = 21;
            this.btnPesquisarVendedor.Text = "...";
            this.btnPesquisarVendedor.UseVisualStyleBackColor = true;
            this.btnPesquisarVendedor.Click += new System.EventHandler(this.btnPesquisarVendedor_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "CNPJ/CPF: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 332);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Location = new System.Drawing.Point(319, 12);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(13, 13);
            this.lblIdVendedor.TabIndex = 29;
            this.lblIdVendedor.Text = "0";
            this.lblIdVendedor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Gestor de Vendas: ";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(80, 12);
            this.txtDocumento.Mask = "00.000.000/0000-00";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(172, 20);
            this.txtDocumento.TabIndex = 67;
            // 
            // grbTipoPessoa
            // 
            this.grbTipoPessoa.Controls.Add(this.rbPessoaJuridica);
            this.grbTipoPessoa.Controls.Add(this.rbPessoaFisica);
            this.grbTipoPessoa.Location = new System.Drawing.Point(370, 12);
            this.grbTipoPessoa.Name = "grbTipoPessoa";
            this.grbTipoPessoa.Size = new System.Drawing.Size(216, 49);
            this.grbTipoPessoa.TabIndex = 69;
            this.grbTipoPessoa.TabStop = false;
            this.grbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Checked = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(109, 19);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(11, 19);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // FormVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 685);
            this.Controls.Add(this.grbTipoPessoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblIdVendedor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbVendedores);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.lblNomeVendedor);
            this.Controls.Add(this.btnPesquisarVendedor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grbContato);
            this.Controls.Add(this.grbEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVendedores";
            this.Text = "FormVendedores";
            this.grbContato.ResumeLayout(false);
            this.grbContato.PerformLayout();
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbTipoPessoa.ResumeLayout(false);
            this.grbTipoPessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContato;
        private System.Windows.Forms.Label lblIdContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.Button btnBuscarCep;
        private System.Windows.Forms.Label lblIdEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCanal;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblNomeVendedor;
        private System.Windows.Forms.Button btnPesquisarVendedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblIdVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.GroupBox grbTipoPessoa;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
    }
}
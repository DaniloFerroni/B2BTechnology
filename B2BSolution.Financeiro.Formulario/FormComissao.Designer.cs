namespace B2BSolution.Financeiro.Formulario
{
    partial class FormComissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComissao));
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.cmbCanal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComissao = new System.Windows.Forms.DataGridView();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            this.btnMesBase = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.CodigoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._Comissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissao)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(77, 85);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(242, 21);
            this.cmbVendedores.TabIndex = 0;
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // cmbCanal
            // 
            this.cmbCanal.FormattingEnabled = true;
            this.cmbCanal.Location = new System.Drawing.Point(483, 85);
            this.cmbCanal.Name = "cmbCanal";
            this.cmbCanal.Size = new System.Drawing.Size(242, 21);
            this.cmbCanal.TabIndex = 1;
            this.cmbCanal.SelectedIndexChanged += new System.EventHandler(this.cmbCanal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendedor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Canal: ";
            // 
            // dgvComissao
            // 
            this.dgvComissao.AllowUserToOrderColumns = true;
            this.dgvComissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComissao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPagamento,
            this.NomeCliente,
            this.ValorPagar,
            this.Pago,
            this._Comissao});
            this.dgvComissao.Location = new System.Drawing.Point(12, 112);
            this.dgvComissao.Name = "dgvComissao";
            this.dgvComissao.Size = new System.Drawing.Size(818, 285);
            this.dgvComissao.TabIndex = 4;
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.Location = new System.Drawing.Point(12, 403);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(75, 23);
            this.btnGerarPdf.TabIndex = 5;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = true;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // btnMesBase
            // 
            this.btnMesBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesBase.Location = new System.Drawing.Point(12, 12);
            this.btnMesBase.Name = "btnMesBase";
            this.btnMesBase.Size = new System.Drawing.Size(75, 40);
            this.btnMesBase.TabIndex = 12;
            this.btnMesBase.Text = "button1";
            this.btnMesBase.UseVisualStyleBackColor = true;
            this.btnMesBase.Click += new System.EventHandler(this.btnMesBase_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(755, 403);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CodigoPagamento
            // 
            this.CodigoPagamento.DataPropertyName = "CodigoPagamento";
            this.CodigoPagamento.HeaderText = "Codigo Pagamento";
            this.CodigoPagamento.Name = "CodigoPagamento";
            this.CodigoPagamento.ReadOnly = true;
            this.CodigoPagamento.Visible = false;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Nome Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 250;
            // 
            // ValorPagar
            // 
            this.ValorPagar.DataPropertyName = "ValorPagar";
            this.ValorPagar.HeaderText = "Valor à Pagar";
            this.ValorPagar.Name = "ValorPagar";
            this.ValorPagar.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            this.Pago.HeaderText = "Pago ";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // _Comissao
            // 
            this._Comissao.DataPropertyName = "Comissao";
            this._Comissao.HeaderText = "Comissão";
            this._Comissao.Name = "_Comissao";
            this._Comissao.ReadOnly = true;
            // 
            // FormComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 685);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnMesBase);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.dgvComissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCanal);
            this.Controls.Add(this.cmbVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComissao";
            this.Text = "FormComissao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComissao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.ComboBox cmbCanal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvComissao;
        private System.Windows.Forms.Button btnGerarPdf;
        private System.Windows.Forms.Button btnMesBase;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPagar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Comissao;
    }
}
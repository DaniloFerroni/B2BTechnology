namespace B2BSolution.Financeiro.Formulario
{
    partial class FormPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtValorGasto = new System.Windows.Forms.TextBox();
            this.ckbPago = new System.Windows.Forms.CheckBox();
            this.lblConsumoMinimo = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.btnMesBase = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblIdPagamento = new System.Windows.Forms.Label();
            this.ckbManterValorGasto = new System.Windows.Forms.CheckBox();
            this.dgvListaPagamento = new System.Windows.Forms.DataGridView();
            this.IdContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodigoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensalidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Gasto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Consumo Mínimo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor a Pagar: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente: ";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(140, 85);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(304, 21);
            this.cmbCliente.TabIndex = 4;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.Location = new System.Drawing.Point(140, 112);
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(100, 20);
            this.txtValorGasto.TabIndex = 5;
            this.txtValorGasto.TextChanged += new System.EventHandler(this.txtValorGasto_TextChanged);
            // 
            // ckbPago
            // 
            this.ckbPago.AutoSize = true;
            this.ckbPago.Location = new System.Drawing.Point(15, 224);
            this.ckbPago.Name = "ckbPago";
            this.ckbPago.Size = new System.Drawing.Size(51, 17);
            this.ckbPago.TabIndex = 8;
            this.ckbPago.Text = "Pago";
            this.ckbPago.UseVisualStyleBackColor = true;
            // 
            // lblConsumoMinimo
            // 
            this.lblConsumoMinimo.AutoSize = true;
            this.lblConsumoMinimo.Location = new System.Drawing.Point(140, 141);
            this.lblConsumoMinimo.Name = "lblConsumoMinimo";
            this.lblConsumoMinimo.Size = new System.Drawing.Size(13, 13);
            this.lblConsumoMinimo.TabIndex = 9;
            this.lblConsumoMinimo.Text = "0";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(140, 189);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(13, 13);
            this.lblValorPagar.TabIndex = 10;
            this.lblValorPagar.Text = "0";
            // 
            // btnMesBase
            // 
            this.btnMesBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesBase.Location = new System.Drawing.Point(15, 12);
            this.btnMesBase.Name = "btnMesBase";
            this.btnMesBase.Size = new System.Drawing.Size(75, 40);
            this.btnMesBase.TabIndex = 11;
            this.btnMesBase.Text = "button1";
            this.btnMesBase.UseVisualStyleBackColor = true;
            this.btnMesBase.Click += new System.EventHandler(this.btnMesBase_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 265);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblIdPagamento
            // 
            this.lblIdPagamento.AutoSize = true;
            this.lblIdPagamento.Location = new System.Drawing.Point(817, 12);
            this.lblIdPagamento.Name = "lblIdPagamento";
            this.lblIdPagamento.Size = new System.Drawing.Size(13, 13);
            this.lblIdPagamento.TabIndex = 13;
            this.lblIdPagamento.Text = "0";
            this.lblIdPagamento.Visible = false;
            // 
            // ckbManterValorGasto
            // 
            this.ckbManterValorGasto.AutoSize = true;
            this.ckbManterValorGasto.Location = new System.Drawing.Point(239, 189);
            this.ckbManterValorGasto.Name = "ckbManterValorGasto";
            this.ckbManterValorGasto.Size = new System.Drawing.Size(123, 17);
            this.ckbManterValorGasto.TabIndex = 14;
            this.ckbManterValorGasto.Text = "Manter Valor Gasto?";
            this.ckbManterValorGasto.UseVisualStyleBackColor = true;
            this.ckbManterValorGasto.CheckedChanged += new System.EventHandler(this.ckbManterValorGasto_CheckedChanged);
            // 
            // dgvListaPagamento
            // 
            this.dgvListaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdContrato,
            this.Nome,
            this.DataPagamento,
            this.ValorPago,
            this.Pago,
            this.Excluir,
            this.CodigoPagamento});
            this.dgvListaPagamento.Location = new System.Drawing.Point(12, 294);
            this.dgvListaPagamento.Name = "dgvListaPagamento";
            this.dgvListaPagamento.Size = new System.Drawing.Size(818, 379);
            this.dgvListaPagamento.TabIndex = 15;
            this.dgvListaPagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPagamento_CellContentClick);
            // 
            // IdContrato
            // 
            this.IdContrato.DataPropertyName = "IdContrato";
            this.IdContrato.HeaderText = "Código Contrato";
            this.IdContrato.Name = "IdContrato";
            this.IdContrato.Width = 106;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // DataPagamento
            // 
            this.DataPagamento.DataPropertyName = "DataPagamento";
            this.DataPagamento.HeaderText = "Data Pagamento";
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
            this.DataPagamento.Width = 120;
            // 
            // ValorPago
            // 
            this.ValorPago.DataPropertyName = "ValorPago";
            this.ValorPago.HeaderText = "Valor Pago";
            this.ValorPago.Name = "ValorPago";
            this.ValorPago.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.DataPropertyName = "Pago";
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 20;
            // 
            // CodigoPagamento
            // 
            this.CodigoPagamento.DataPropertyName = "CodigoPagamento";
            this.CodigoPagamento.HeaderText = "CodigoPagamento";
            this.CodigoPagamento.Name = "CodigoPagamento";
            this.CodigoPagamento.ReadOnly = true;
            this.CodigoPagamento.Visible = false;
            // 
            // lblMensalidade
            // 
            this.lblMensalidade.AutoSize = true;
            this.lblMensalidade.Location = new System.Drawing.Point(140, 164);
            this.lblMensalidade.Name = "lblMensalidade";
            this.lblMensalidade.Size = new System.Drawing.Size(13, 13);
            this.lblMensalidade.TabIndex = 17;
            this.lblMensalidade.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor Mensalidade: ";
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.Location = new System.Drawing.Point(755, 265);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(75, 23);
            this.btnGerarPdf.TabIndex = 18;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = true;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // FormPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 685);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.lblMensalidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvListaPagamento);
            this.Controls.Add(this.ckbManterValorGasto);
            this.Controls.Add(this.lblIdPagamento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnMesBase);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblConsumoMinimo);
            this.Controls.Add(this.ckbPago);
            this.Controls.Add(this.txtValorGasto);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPagamentos";
            this.Text = "FormPagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtValorGasto;
        private System.Windows.Forms.CheckBox ckbPago;
        private System.Windows.Forms.Label lblConsumoMinimo;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Button btnMesBase;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblIdPagamento;
        private System.Windows.Forms.CheckBox ckbManterValorGasto;
        private System.Windows.Forms.DataGridView dgvListaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pago;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPagamento;
        private System.Windows.Forms.Label lblMensalidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGerarPdf;
    }
}
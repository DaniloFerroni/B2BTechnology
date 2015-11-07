namespace B2BSolution.Financeiro.Formulario
{
    partial class FormListarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarClientes));
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.CNPJ_CPF,
            this.NomeVendedor});
            this.dgvListaCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.Size = new System.Drawing.Size(802, 579);
            this.dgvListaCliente.TabIndex = 0;
            this.dgvListaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCliente_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo Cliente";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // CNPJ_CPF
            // 
            this.CNPJ_CPF.DataPropertyName = "CNPJ_CPF";
            this.CNPJ_CPF.HeaderText = "CNPJ/CPF";
            this.CNPJ_CPF.Name = "CNPJ_CPF";
            this.CNPJ_CPF.ReadOnly = true;
            this.CNPJ_CPF.Width = 150;
            // 
            // NomeVendedor
            // 
            this.NomeVendedor.DataPropertyName = "NomeVendedor";
            this.NomeVendedor.HeaderText = "Nome Vendedor";
            this.NomeVendedor.Name = "NomeVendedor";
            this.NomeVendedor.ReadOnly = true;
            this.NomeVendedor.Width = 250;
            // 
            // FormListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 603);
            this.Controls.Add(this.dgvListaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVendedor;
    }
}
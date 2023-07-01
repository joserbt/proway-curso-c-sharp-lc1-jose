namespace WindowsFormsExemplos.Forms.Pedidos
{
    partial class CadastroPedidoForm
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.buttonCriarOrcamento = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCodigoValor = new System.Windows.Forms.Label();
            this.comboBoxProdutos = new System.Windows.Forms.ComboBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelPrecoUnitarioValor = new System.Windows.Forms.Label();
            this.labelPrecoUnitario = new System.Windows.Forms.Label();
            this.labelTotalValor = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridViewCarrinho = new System.Windows.Forms.DataGridView();
            this.labelCarrinho = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelTotalPedido = new System.Windows.Forms.Label();
            this.labelTotalPedidoValor = new System.Windows.Forms.Label();
            this.buttonFecharPedido = new System.Windows.Forms.Button();
            this.buttonCancelarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 36);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(55, 20);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.DisplayMember = "nome";
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(12, 59);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(344, 28);
            this.comboBoxClientes.TabIndex = 1;
            // 
            // buttonCriarOrcamento
            // 
            this.buttonCriarOrcamento.Location = new System.Drawing.Point(192, 109);
            this.buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            this.buttonCriarOrcamento.Size = new System.Drawing.Size(164, 29);
            this.buttonCriarOrcamento.TabIndex = 2;
            this.buttonCriarOrcamento.Text = "Criar Orçamento";
            this.buttonCriarOrcamento.UseVisualStyleBackColor = true;
            this.buttonCriarOrcamento.Click += new System.EventHandler(this.buttonCriarOrcamento_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(58, 20);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "Código";
            // 
            // labelCodigoValor
            // 
            this.labelCodigoValor.AutoSize = true;
            this.labelCodigoValor.Location = new System.Drawing.Point(76, 9);
            this.labelCodigoValor.Name = "labelCodigoValor";
            this.labelCodigoValor.Size = new System.Drawing.Size(17, 20);
            this.labelCodigoValor.TabIndex = 4;
            this.labelCodigoValor.Text = "0";
            // 
            // comboBoxProdutos
            // 
            this.comboBoxProdutos.DisplayMember = "Nome";
            this.comboBoxProdutos.FormattingEnabled = true;
            this.comboBoxProdutos.Location = new System.Drawing.Point(435, 53);
            this.comboBoxProdutos.Name = "comboBoxProdutos";
            this.comboBoxProdutos.Size = new System.Drawing.Size(514, 28);
            this.comboBoxProdutos.TabIndex = 5;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Location = new System.Drawing.Point(435, 30);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(62, 20);
            this.labelProduto.TabIndex = 6;
            this.labelProduto.Text = "Produto";
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(567, 110);
            this.numericUpDownQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownQuantidade.TabIndex = 7;
            this.numericUpDownQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(567, 84);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(87, 20);
            this.labelQuantidade.TabIndex = 8;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // labelPrecoUnitarioValor
            // 
            this.labelPrecoUnitarioValor.AutoSize = true;
            this.labelPrecoUnitarioValor.Location = new System.Drawing.Point(435, 112);
            this.labelPrecoUnitarioValor.Name = "labelPrecoUnitarioValor";
            this.labelPrecoUnitarioValor.Size = new System.Drawing.Size(17, 20);
            this.labelPrecoUnitarioValor.TabIndex = 10;
            this.labelPrecoUnitarioValor.Text = "0";
            // 
            // labelPrecoUnitario
            // 
            this.labelPrecoUnitario.AutoSize = true;
            this.labelPrecoUnitario.Location = new System.Drawing.Point(435, 84);
            this.labelPrecoUnitario.Name = "labelPrecoUnitario";
            this.labelPrecoUnitario.Size = new System.Drawing.Size(101, 20);
            this.labelPrecoUnitario.TabIndex = 9;
            this.labelPrecoUnitario.Text = "Preço unitário";
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Location = new System.Drawing.Point(751, 112);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(17, 20);
            this.labelTotalValor.TabIndex = 12;
            this.labelTotalValor.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(751, 84);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // dataGridViewCarrinho
            // 
            this.dataGridViewCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrinho.Location = new System.Drawing.Point(435, 215);
            this.dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            this.dataGridViewCarrinho.RowHeadersWidth = 51;
            this.dataGridViewCarrinho.RowTemplate.Height = 29;
            this.dataGridViewCarrinho.Size = new System.Drawing.Size(686, 439);
            this.dataGridViewCarrinho.TabIndex = 13;
            // 
            // labelCarrinho
            // 
            this.labelCarrinho.AutoSize = true;
            this.labelCarrinho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCarrinho.Location = new System.Drawing.Point(738, 184);
            this.labelCarrinho.Name = "labelCarrinho";
            this.labelCarrinho.Size = new System.Drawing.Size(93, 28);
            this.labelCarrinho.TabIndex = 14;
            this.labelCarrinho.Text = "Carrinho";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(955, 30);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(166, 102);
            this.buttonAdicionar.TabIndex = 15;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // labelTotalPedido
            // 
            this.labelTotalPedido.AutoSize = true;
            this.labelTotalPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPedido.Location = new System.Drawing.Point(857, 674);
            this.labelTotalPedido.Name = "labelTotalPedido";
            this.labelTotalPedido.Size = new System.Drawing.Size(129, 28);
            this.labelTotalPedido.TabIndex = 16;
            this.labelTotalPedido.Text = "Total Pedido";
            // 
            // labelTotalPedidoValor
            // 
            this.labelTotalPedidoValor.AutoSize = true;
            this.labelTotalPedidoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPedidoValor.Location = new System.Drawing.Point(992, 674);
            this.labelTotalPedidoValor.Name = "labelTotalPedidoValor";
            this.labelTotalPedidoValor.Size = new System.Drawing.Size(24, 28);
            this.labelTotalPedidoValor.TabIndex = 17;
            this.labelTotalPedidoValor.Text = "0";
            // 
            // buttonFecharPedido
            // 
            this.buttonFecharPedido.Location = new System.Drawing.Point(1143, 215);
            this.buttonFecharPedido.Name = "buttonFecharPedido";
            this.buttonFecharPedido.Size = new System.Drawing.Size(192, 89);
            this.buttonFecharPedido.TabIndex = 18;
            this.buttonFecharPedido.Text = "Fechar Pedido";
            this.buttonFecharPedido.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarPedido
            // 
            this.buttonCancelarPedido.Location = new System.Drawing.Point(1143, 310);
            this.buttonCancelarPedido.Name = "buttonCancelarPedido";
            this.buttonCancelarPedido.Size = new System.Drawing.Size(192, 89);
            this.buttonCancelarPedido.TabIndex = 19;
            this.buttonCancelarPedido.Text = "Cancelar Orçamento";
            this.buttonCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // CadastroPedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 717);
            this.Controls.Add(this.buttonCancelarPedido);
            this.Controls.Add(this.buttonFecharPedido);
            this.Controls.Add(this.labelTotalPedidoValor);
            this.Controls.Add(this.labelTotalPedido);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelCarrinho);
            this.Controls.Add(this.dataGridViewCarrinho);
            this.Controls.Add(this.labelTotalValor);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPrecoUnitarioValor);
            this.Controls.Add(this.labelPrecoUnitario);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.comboBoxProdutos);
            this.Controls.Add(this.labelCodigoValor);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonCriarOrcamento);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.labelCliente);
            this.Name = "CadastroPedidoForm";
            this.Text = "CadastroPedidoForm";
            this.Load += new System.EventHandler(this.CadastroPedidoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCliente;
        private ComboBox comboBoxClientes;
        private Button buttonCriarOrcamento;
        private Label labelCodigo;
        private Label labelCodigoValor;
        private ComboBox comboBoxProdutos;
        private Label labelProduto;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelQuantidade;
        private Label labelPrecoUnitarioValor;
        private Label labelPrecoUnitario;
        private Label labelTotalValor;
        private Label labelTotal;
        private DataGridView dataGridViewCarrinho;
        private Label labelCarrinho;
        private Button buttonAdicionar;
        private Label labelTotalPedido;
        private Label labelTotalPedidoValor;
        private Button buttonFecharPedido;
        private Button buttonCancelarPedido;
    }
}
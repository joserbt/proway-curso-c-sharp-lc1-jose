namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadatroSimplificadoForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelPrecoUnitario = new System.Windows.Forms.Label();
            this.labelListaProdutos = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxPrecoUnitario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(441, 63);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(441, 140);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(87, 20);
            this.labelQuantidade.TabIndex = 1;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // labelPrecoUnitario
            // 
            this.labelPrecoUnitario.AutoSize = true;
            this.labelPrecoUnitario.Location = new System.Drawing.Point(441, 213);
            this.labelPrecoUnitario.Name = "labelPrecoUnitario";
            this.labelPrecoUnitario.Size = new System.Drawing.Size(103, 20);
            this.labelPrecoUnitario.TabIndex = 2;
            this.labelPrecoUnitario.Text = "Preço Unitário";
            this.labelPrecoUnitario.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelListaProdutos
            // 
            this.labelListaProdutos.AutoSize = true;
            this.labelListaProdutos.Location = new System.Drawing.Point(41, 28);
            this.labelListaProdutos.Name = "labelListaProdutos";
            this.labelListaProdutos.Size = new System.Drawing.Size(124, 20);
            this.labelListaProdutos.TabIndex = 3;
            this.labelListaProdutos.Text = "Lista de produtos";
            this.labelListaProdutos.Click += new System.EventHandler(this.labelListaProdutos_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(677, 298);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(441, 96);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(330, 27);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(441, 174);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(330, 27);
            this.textBoxQuantidade.TabIndex = 6;
            // 
            // textBoxPrecoUnitario
            // 
            this.textBoxPrecoUnitario.Location = new System.Drawing.Point(441, 248);
            this.textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            this.textBoxPrecoUnitario.Size = new System.Drawing.Size(330, 27);
            this.textBoxPrecoUnitario.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnQuantidade,
            this.Quantidade,
            this.ColumnPreco});
            this.dataGridView1.Location = new System.Drawing.Point(41, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(369, 477);
            this.dataGridView1.TabIndex = 8;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Preço Unitário";
            this.ColumnQuantidade.MinimumWidth = 6;
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            this.ColumnQuantidade.Width = 125;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 125;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.MinimumWidth = 6;
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            this.ColumnPreco.Width = 125;
            // 
            // ProdutoCadatroSimplificadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxPrecoUnitario);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelListaProdutos);
            this.Controls.Add(this.labelPrecoUnitario);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelNome);
            this.Name = "ProdutoCadatroSimplificadoForm";
            this.Text = "ProdutoCadatroSimplificadoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private Label labelQuantidade;
        private Label labelPrecoUnitario;
        private Label labelListaProdutos;
        private Button buttonSalvar;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ColumnPreco;
    }
}
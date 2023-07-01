namespace WindowsFormsExemplos.Forms
{
    partial class MenuPrincipal
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
            this.buttonFolhaPagamento = new System.Windows.Forms.Button();
            this.buttonCadastroSimplificadoProduto = new System.Windows.Forms.Button();
            this.buttonCadastroFilmes = new System.Windows.Forms.Button();
            this.buttonCadastroSimplificadoBancoDados = new System.Windows.Forms.Button();
            this.buttonListaDeProdutos = new System.Windows.Forms.Button();
            this.buttonListaClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            this.buttonFolhaPagamento.Location = new System.Drawing.Point(287, 233);
            this.buttonFolhaPagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            this.buttonFolhaPagamento.Size = new System.Drawing.Size(297, 45);
            this.buttonFolhaPagamento.TabIndex = 0;
            this.buttonFolhaPagamento.Text = "Folha Pagamento";
            this.buttonFolhaPagamento.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            this.buttonCadastroSimplificadoProduto.Location = new System.Drawing.Point(287, 287);
            this.buttonCadastroSimplificadoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            this.buttonCadastroSimplificadoProduto.Size = new System.Drawing.Size(297, 52);
            this.buttonCadastroSimplificadoProduto.TabIndex = 1;
            this.buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            this.buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroFilmes
            // 
            this.buttonCadastroFilmes.Location = new System.Drawing.Point(287, 180);
            this.buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            this.buttonCadastroFilmes.Size = new System.Drawing.Size(297, 45);
            this.buttonCadastroFilmes.TabIndex = 2;
            this.buttonCadastroFilmes.Text = "Cadastro de filmes";
            this.buttonCadastroFilmes.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroSimplificadoBancoDados
            // 
            this.buttonCadastroSimplificadoBancoDados.Location = new System.Drawing.Point(287, 347);
            this.buttonCadastroSimplificadoBancoDados.Name = "buttonCadastroSimplificadoBancoDados";
            this.buttonCadastroSimplificadoBancoDados.Size = new System.Drawing.Size(297, 49);
            this.buttonCadastroSimplificadoBancoDados.TabIndex = 3;
            this.buttonCadastroSimplificadoBancoDados.Text = "Cadastro Simplifcado produtos banco dados";
            this.buttonCadastroSimplificadoBancoDados.UseVisualStyleBackColor = true;
            // 
            // buttonListaDeProdutos
            // 
            this.buttonListaDeProdutos.Location = new System.Drawing.Point(287, 401);
            this.buttonListaDeProdutos.Name = "buttonListaDeProdutos";
            this.buttonListaDeProdutos.Size = new System.Drawing.Size(297, 49);
            this.buttonListaDeProdutos.TabIndex = 4;
            this.buttonListaDeProdutos.Text = "Lista de Produtos";
            this.buttonListaDeProdutos.UseVisualStyleBackColor = true;
            // 
            // buttonListaClientes
            // 
            this.buttonListaClientes.Location = new System.Drawing.Point(287, 129);
            this.buttonListaClientes.Name = "buttonListaClientes";
            this.buttonListaClientes.Size = new System.Drawing.Size(297, 45);
            this.buttonListaClientes.TabIndex = 5;
            this.buttonListaClientes.Text = "Lista de clientes";
            this.buttonListaClientes.UseVisualStyleBackColor = true;
            this.buttonListaClientes.Click += new System.EventHandler(this.buttonListaClientes_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.buttonListaClientes);
            this.Controls.Add(this.buttonListaDeProdutos);
            this.Controls.Add(this.buttonCadastroSimplificadoBancoDados);
            this.Controls.Add(this.buttonCadastroFilmes);
            this.Controls.Add(this.buttonCadastroSimplificadoProduto);
            this.Controls.Add(this.buttonFolhaPagamento);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Windows Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFolhaPagamento;
        private Button buttonCadastroSimplificadoProduto;
        private Button buttonCadastroFilmes;
        private Button buttonCadastroSimplificadoBancoDados;
        private Button buttonListaDeProdutos;
        private Button buttonListaClientes;
    }
}
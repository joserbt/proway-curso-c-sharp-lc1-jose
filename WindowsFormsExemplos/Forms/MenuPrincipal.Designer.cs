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
            buttonFolhaPagamento = new Button();
            buttonCadastroSimplificadoProduto = new Button();
            buttonCadastroFilmes = new Button();
            buttonCadastroSimplificadoBancoDados = new Button();
            buttonListaDeProdutos = new Button();
            SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            buttonFolhaPagamento.Location = new Point(287, 233);
            buttonFolhaPagamento.Margin = new Padding(3, 4, 3, 4);
            buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            buttonFolhaPagamento.Size = new Size(297, 46);
            buttonFolhaPagamento.TabIndex = 0;
            buttonFolhaPagamento.Text = "Folha Pagamento";
            buttonFolhaPagamento.UseVisualStyleBackColor = true;
            buttonFolhaPagamento.Click += buttonFolhaPagamento_Click;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            buttonCadastroSimplificadoProduto.Location = new Point(287, 287);
            buttonCadastroSimplificadoProduto.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            buttonCadastroSimplificadoProduto.Size = new Size(297, 52);
            buttonCadastroSimplificadoProduto.TabIndex = 1;
            buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProduto.Click += buttonCadastroSimplificadoProduto_Click;
            // 
            // buttonCadastroFilmes
            // 
            buttonCadastroFilmes.Location = new Point(287, 180);
            buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            buttonCadastroFilmes.Size = new Size(297, 46);
            buttonCadastroFilmes.TabIndex = 2;
            buttonCadastroFilmes.Text = "Cadastro de filmes";
            buttonCadastroFilmes.UseVisualStyleBackColor = true;
            buttonCadastroFilmes.Click += buttonCadastroFilmes_Click;
            // 
            // buttonCadastroSimplificadoBancoDados
            // 
            buttonCadastroSimplificadoBancoDados.Location = new Point(287, 346);
            buttonCadastroSimplificadoBancoDados.Name = "buttonCadastroSimplificadoBancoDados";
            buttonCadastroSimplificadoBancoDados.Size = new Size(297, 49);
            buttonCadastroSimplificadoBancoDados.TabIndex = 3;
            buttonCadastroSimplificadoBancoDados.Text = "Cadastro Simplifcado produtos banco dados";
            buttonCadastroSimplificadoBancoDados.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoBancoDados.Click += buttonCadastroSimplificadoBancoDados_Click;
            // 
            // buttonListaDeProdutos
            // 
            buttonListaDeProdutos.Location = new Point(287, 401);
            buttonListaDeProdutos.Name = "buttonListaDeProdutos";
            buttonListaDeProdutos.Size = new Size(297, 49);
            buttonListaDeProdutos.TabIndex = 4;
            buttonListaDeProdutos.Text = "Lista de Produtos";
            buttonListaDeProdutos.UseVisualStyleBackColor = true;
            buttonListaDeProdutos.Click += buttonListaDeProdutos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonListaDeProdutos);
            Controls.Add(buttonCadastroSimplificadoBancoDados);
            Controls.Add(buttonCadastroFilmes);
            Controls.Add(buttonCadastroSimplificadoProduto);
            Controls.Add(buttonFolhaPagamento);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Windows Forms";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFolhaPagamento;
        private Button buttonCadastroSimplificadoProduto;
        private Button buttonCadastroFilmes;
        private Button buttonCadastroSimplificadoBancoDados;
        private Button buttonListaDeProdutos;
    }
}
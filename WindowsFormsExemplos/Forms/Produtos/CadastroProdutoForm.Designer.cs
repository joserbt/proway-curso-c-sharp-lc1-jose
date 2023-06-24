namespace WindowsFormsExemplos.Forms.Produtos
{
    partial class CadastroProdutoForm
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
            textBoxNome = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            buttonSalvar = new Button();
            labelPrecoUnitario = new Label();
            labelQuantidade = new Label();
            labelNome = new Label();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(10, 30);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(341, 23);
            textBoxNome.TabIndex = 20;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(10, 74);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(341, 23);
            textBoxQuantidade.TabIndex = 22;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(10, 118);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(341, 23);
            textBoxPrecoUnitario.TabIndex = 24;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(276, 147);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 25;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(10, 100);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(82, 15);
            labelPrecoUnitario.TabIndex = 23;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(10, 56);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 21;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(10, 12);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 19;
            labelNome.Text = "Nome";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(196, 147);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 26;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 178);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(buttonSalvar);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelQuantidade);
            Controls.Add(labelNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroProdutoForm";
            Text = "CadastroProdutoForm";
            Load += CadastroProdutoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private Button buttonSalvar;
        private Label labelPrecoUnitario;
        private Label labelQuantidade;
        private Label labelNome;
        private Button buttonCancelar;
    }
}
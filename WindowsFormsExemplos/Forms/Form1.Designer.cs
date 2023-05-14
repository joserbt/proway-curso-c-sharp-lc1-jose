namespace WindowsFormsExemplos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelQuantidadeHoras = new Label();
            textBoxQuantidadeHoras = new TextBox();
            labelValorHora = new Label();
            textBoxValorHora = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(38, 19);
            labelNome.Margin = new Padding(2, 0, 2, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(91, 19);
            textBoxNome.Margin = new Padding(2, 3, 2, 3);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(357, 27);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // labelQuantidadeHoras
            // 
            labelQuantidadeHoras.AutoSize = true;
            labelQuantidadeHoras.Location = new Point(38, 68);
            labelQuantidadeHoras.Margin = new Padding(2, 0, 2, 0);
            labelQuantidadeHoras.Name = "labelQuantidadeHoras";
            labelQuantidadeHoras.Size = new Size(151, 20);
            labelQuantidadeHoras.TabIndex = 2;
            labelQuantidadeHoras.Text = "Quantidade de Horas";
            // 
            // textBoxQuantidadeHoras
            // 
            textBoxQuantidadeHoras.Location = new Point(228, 65);
            textBoxQuantidadeHoras.Margin = new Padding(2, 3, 2, 3);
            textBoxQuantidadeHoras.Name = "textBoxQuantidadeHoras";
            textBoxQuantidadeHoras.Size = new Size(220, 27);
            textBoxQuantidadeHoras.TabIndex = 3;
            // 
            // labelValorHora
            // 
            labelValorHora.AutoSize = true;
            labelValorHora.Location = new Point(38, 109);
            labelValorHora.Margin = new Padding(2, 0, 2, 0);
            labelValorHora.Name = "labelValorHora";
            labelValorHora.Size = new Size(80, 20);
            labelValorHora.TabIndex = 4;
            labelValorHora.Text = "Valor Hora";
            // 
            // textBoxValorHora
            // 
            textBoxValorHora.Location = new Point(149, 109);
            textBoxValorHora.Margin = new Padding(2, 3, 2, 3);
            textBoxValorHora.Name = "textBoxValorHora";
            textBoxValorHora.Size = new Size(299, 27);
            textBoxValorHora.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(76, 160);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(306, 35);
            button1.TabIndex = 6;
            button1.Text = "Calcular Salário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 68);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 7;
            label1.Text = "H:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 110);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 8;
            label2.Text = "R$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 213);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxValorHora);
            Controls.Add(labelValorHora);
            Controls.Add(textBoxQuantidadeHoras);
            Controls.Add(labelQuantidadeHoras);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelQuantidadeHoras;
        private TextBox textBoxQuantidadeHoras;
        private Label labelValorHora;
        private TextBox textBoxValorHora;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
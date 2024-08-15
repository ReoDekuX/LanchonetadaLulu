namespace LanchonetadaLulu.View
{
    partial class TelaCadastroProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_Produto = new TextBox();
            tbx_qtd = new TextBox();
            tbx_Preco = new TextBox();
            btn_Salvar = new Button();
            label5 = new Label();
            cbx_Tipo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 31);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Lanches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(67, 106);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(67, 152);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(67, 194);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 3;
            label4.Text = "Preço:";
            // 
            // tbx_Produto
            // 
            tbx_Produto.Font = new Font("Segoe UI", 14.25F);
            tbx_Produto.Location = new Point(184, 101);
            tbx_Produto.Name = "tbx_Produto";
            tbx_Produto.Size = new Size(218, 33);
            tbx_Produto.TabIndex = 4;
            // 
            // tbx_qtd
            // 
            tbx_qtd.Font = new Font("Segoe UI", 14.25F);
            tbx_qtd.Location = new Point(188, 149);
            tbx_qtd.Name = "tbx_qtd";
            tbx_qtd.Size = new Size(100, 33);
            tbx_qtd.TabIndex = 5;
            // 
            // tbx_Preco
            // 
            tbx_Preco.Font = new Font("Segoe UI", 14.25F);
            tbx_Preco.Location = new Point(184, 194);
            tbx_Preco.Name = "tbx_Preco";
            tbx_Preco.Size = new Size(149, 33);
            tbx_Preco.TabIndex = 6;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(67, 334);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(314, 59);
            btn_Salvar.TabIndex = 7;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 244);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 8;
            label5.Text = "Tipos:";
            // 
            // cbx_Tipo
            // 
            cbx_Tipo.Font = new Font("Segoe UI", 14.25F);
            cbx_Tipo.FormattingEnabled = true;
            cbx_Tipo.Items.AddRange(new object[] { "Lanche", "Bebida" });
            cbx_Tipo.Location = new Point(184, 244);
            cbx_Tipo.Name = "cbx_Tipo";
            cbx_Tipo.Size = new Size(121, 33);
            cbx_Tipo.TabIndex = 9;
            // 
            // TelaCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(451, 413);
            Controls.Add(cbx_Tipo);
            Controls.Add(label5);
            Controls.Add(btn_Salvar);
            Controls.Add(tbx_Preco);
            Controls.Add(tbx_qtd);
            Controls.Add(tbx_Produto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastroProduto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimentício - SGPA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_Produto;
        private TextBox tbx_qtd;
        private TextBox tbx_Preco;
        private Button btn_Salvar;
        private Label label5;
        private ComboBox cbx_Tipo;
    }
}
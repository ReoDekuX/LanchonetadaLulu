namespace LanchonetadaLulu.View
{
    partial class TelaGerenciaProduto
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
            tabPageProduto = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewProdutos = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btn_BuscarProduto = new Button();
            tbx_NomeProduto = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btn_ExcluirProduto = new Button();
            btn_AlterarProduto = new Button();
            tbx_CodigoProdutoVer = new TextBox();
            cbx_TipoProdutoVer = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            tbx_qtdProdutoVer = new TextBox();
            label6 = new Label();
            tbx_PrecoProdutoVer = new TextBox();
            label7 = new Label();
            tbx_ProdutoProdutoVer = new TextBox();
            btn_BuscarProdutoCodigo = new Button();
            tbx_CodigoProduto = new TextBox();
            label3 = new Label();
            tabPageProduto.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 27);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 1;
            label1.Text = "Manipulando os Produtos";
            // 
            // tabPageProduto
            // 
            tabPageProduto.Controls.Add(tabPage1);
            tabPageProduto.Controls.Add(tabPage2);
            tabPageProduto.Location = new Point(94, 109);
            tabPageProduto.Name = "tabPageProduto";
            tabPageProduto.SelectedIndex = 0;
            tabPageProduto.Size = new Size(571, 292);
            tabPageProduto.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewProdutos);
            tabPage1.Controls.Add(btn_BuscarProduto);
            tabPage1.Controls.Add(tbx_NomeProduto);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(563, 264);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Columns.AddRange(new DataGridViewColumn[] { Código, Produto, Valor, Tipo, Quantidade });
            dataGridViewProdutos.Location = new Point(15, 105);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(529, 131);
            dataGridViewProdutos.TabIndex = 3;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // btn_BuscarProduto
            // 
            btn_BuscarProduto.Location = new Point(28, 76);
            btn_BuscarProduto.Name = "btn_BuscarProduto";
            btn_BuscarProduto.Size = new Size(75, 23);
            btn_BuscarProduto.TabIndex = 2;
            btn_BuscarProduto.Text = "Buscar";
            btn_BuscarProduto.UseVisualStyleBackColor = true;
            btn_BuscarProduto.Click += btn_BuscarProduto_Click;
            // 
            // tbx_NomeProduto
            // 
            tbx_NomeProduto.Location = new Point(28, 47);
            tbx_NomeProduto.Name = "tbx_NomeProduto";
            tbx_NomeProduto.Size = new Size(464, 23);
            tbx_NomeProduto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 20);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome do Produto";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btn_BuscarProdutoCodigo);
            tabPage2.Controls.Add(tbx_CodigoProduto);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(563, 264);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alterar & Excluir";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ExcluirProduto);
            groupBox1.Controls.Add(btn_AlterarProduto);
            groupBox1.Controls.Add(tbx_CodigoProdutoVer);
            groupBox1.Controls.Add(cbx_TipoProdutoVer);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_qtdProdutoVer);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbx_PrecoProdutoVer);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbx_ProdutoProdutoVer);
            groupBox1.Location = new Point(6, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 206);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado da Pesquisa:";
            // 
            // btn_ExcluirProduto
            // 
            btn_ExcluirProduto.Location = new Point(436, 177);
            btn_ExcluirProduto.Name = "btn_ExcluirProduto";
            btn_ExcluirProduto.Size = new Size(75, 23);
            btn_ExcluirProduto.TabIndex = 17;
            btn_ExcluirProduto.Text = "Excluir";
            btn_ExcluirProduto.UseVisualStyleBackColor = true;
            btn_ExcluirProduto.Click += btn_ExcluirProduto_Click;
            // 
            // btn_AlterarProduto
            // 
            btn_AlterarProduto.Location = new Point(355, 177);
            btn_AlterarProduto.Name = "btn_AlterarProduto";
            btn_AlterarProduto.Size = new Size(75, 23);
            btn_AlterarProduto.TabIndex = 16;
            btn_AlterarProduto.Text = "Alterar";
            btn_AlterarProduto.UseVisualStyleBackColor = true;
            btn_AlterarProduto.Click += btn_AlterarProduto_Click;
            // 
            // tbx_CodigoProdutoVer
            // 
            tbx_CodigoProdutoVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_CodigoProdutoVer.Location = new Point(114, 31);
            tbx_CodigoProdutoVer.Name = "tbx_CodigoProdutoVer";
            tbx_CodigoProdutoVer.Size = new Size(101, 33);
            tbx_CodigoProdutoVer.TabIndex = 10;
            // 
            // cbx_TipoProdutoVer
            // 
            cbx_TipoProdutoVer.FormattingEnabled = true;
            cbx_TipoProdutoVer.Items.AddRange(new object[] { "Lanche", "Bebida" });
            cbx_TipoProdutoVer.Location = new Point(370, 75);
            cbx_TipoProdutoVer.Name = "cbx_TipoProdutoVer";
            cbx_TipoProdutoVer.Size = new Size(121, 23);
            cbx_TipoProdutoVer.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(16, 34);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 6;
            label4.Text = "Código:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(307, 73);
            label8.Name = "label8";
            label8.Size = new Size(57, 25);
            label8.TabIndex = 14;
            label8.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(16, 70);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 7;
            label5.Text = "Produto:";
            // 
            // tbx_qtdProdutoVer
            // 
            tbx_qtdProdutoVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_qtdProdutoVer.Location = new Point(279, 123);
            tbx_qtdProdutoVer.Name = "tbx_qtdProdutoVer";
            tbx_qtdProdutoVer.Size = new Size(78, 33);
            tbx_qtdProdutoVer.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(16, 126);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 8;
            label6.Text = "Preço:";
            // 
            // tbx_PrecoProdutoVer
            // 
            tbx_PrecoProdutoVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_PrecoProdutoVer.Location = new Point(104, 123);
            tbx_PrecoProdutoVer.Name = "tbx_PrecoProdutoVer";
            tbx_PrecoProdutoVer.Size = new Size(108, 33);
            tbx_PrecoProdutoVer.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(223, 126);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 9;
            label7.Text = "Qtd:";
            // 
            // tbx_ProdutoProdutoVer
            // 
            tbx_ProdutoProdutoVer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            tbx_ProdutoProdutoVer.Location = new Point(114, 70);
            tbx_ProdutoProdutoVer.Name = "tbx_ProdutoProdutoVer";
            tbx_ProdutoProdutoVer.Size = new Size(192, 33);
            tbx_ProdutoProdutoVer.TabIndex = 11;
            // 
            // btn_BuscarProdutoCodigo
            // 
            btn_BuscarProdutoCodigo.Location = new Point(313, 23);
            btn_BuscarProdutoCodigo.Name = "btn_BuscarProdutoCodigo";
            btn_BuscarProdutoCodigo.Size = new Size(75, 23);
            btn_BuscarProdutoCodigo.TabIndex = 5;
            btn_BuscarProdutoCodigo.Text = "Buscar";
            btn_BuscarProdutoCodigo.UseVisualStyleBackColor = true;
            btn_BuscarProdutoCodigo.Click += btn_BuscarProdutoCodigo_Click;
            // 
            // tbx_CodigoProduto
            // 
            tbx_CodigoProduto.Location = new Point(180, 23);
            tbx_CodigoProduto.Name = "tbx_CodigoProduto";
            tbx_CodigoProduto.Size = new Size(114, 23);
            tbx_CodigoProduto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 26);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 3;
            label3.Text = "Digite o Código do Produto";
            // 
            // TelaGerenciaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(765, 450);
            Controls.Add(tabPageProduto);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaGerenciaProduto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimentício - SGPA";
            tabPageProduto.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabPageProduto;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridViewProdutos;
        private Button btn_BuscarProduto;
        private TextBox tbx_NomeProduto;
        private Label label2;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Quantidade;
        private TextBox tbx_CodigoProdutoVer;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_BuscarProdutoCodigo;
        private TextBox tbx_CodigoProduto;
        private Label label3;
        private TextBox tbx_qtdProdutoVer;
        private TextBox tbx_PrecoProdutoVer;
        private TextBox tbx_ProdutoProdutoVer;
        private GroupBox groupBox1;
        private ComboBox cbx_TipoProdutoVer;
        private Label label8;
        private Button btn_ExcluirProduto;
        private Button btn_AlterarProduto;
    }
}
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(94, 109);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(571, 292);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(563, 264);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(563, 264);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alterar & Excluir";
            tabPage2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(28, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(28, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Produto, Valor, Tipo, Quantidade });
            dataGridView1.Location = new Point(28, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(516, 131);
            dataGridView1.TabIndex = 3;
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
            // button2
            // 
            button2.Location = new Point(312, 23);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox3.Location = new Point(104, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 33);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox4.Location = new Point(114, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 33);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox5.Location = new Point(104, 123);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 33);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            textBox6.Location = new Point(279, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(78, 33);
            textBox6.TabIndex = 13;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lanche", "Bebida" });
            comboBox1.Location = new Point(370, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(6, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 206);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado da Pesquisa:";
            // 
            // button3
            // 
            button3.Location = new Point(355, 177);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(436, 177);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            // 
            // TelaGerenciaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(765, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaGerenciaProduto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Produtos Alimentício - SGPA";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Quantidade;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label8;
        private Button button4;
        private Button button3;
    }
}
namespace LanchonetadaLulu.View
{
    partial class TelaCadastroFuncionario
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
            tbx_nomeFun = new TextBox();
            tbx_foneFun = new TextBox();
            tbx_emailFun = new TextBox();
            btn_Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 48);
            label1.Name = "label1";
            label1.Size = new Size(302, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastro do Funcionario ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(52, 148);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(51, 203);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 2;
            label3.Text = "Fone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(61, 251);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // tbx_nomeFun
            // 
            tbx_nomeFun.Font = new Font("Segoe UI", 14.25F);
            tbx_nomeFun.Location = new Point(140, 149);
            tbx_nomeFun.Name = "tbx_nomeFun";
            tbx_nomeFun.Size = new Size(255, 33);
            tbx_nomeFun.TabIndex = 4;
            // 
            // tbx_foneFun
            // 
            tbx_foneFun.Font = new Font("Segoe UI", 14.25F);
            tbx_foneFun.Location = new Point(153, 200);
            tbx_foneFun.Name = "tbx_foneFun";
            tbx_foneFun.Size = new Size(154, 33);
            tbx_foneFun.TabIndex = 5;
            // 
            // tbx_emailFun
            // 
            tbx_emailFun.Font = new Font("Segoe UI", 14.25F);
            tbx_emailFun.Location = new Point(153, 251);
            tbx_emailFun.Name = "tbx_emailFun";
            tbx_emailFun.Size = new Size(295, 33);
            tbx_emailFun.TabIndex = 6;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(140, 365);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(226, 54);
            btn_Salvar.TabIndex = 7;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // TelaCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(515, 462);
            Controls.Add(btn_Salvar);
            Controls.Add(tbx_emailFun);
            Controls.Add(tbx_foneFun);
            Controls.Add(tbx_nomeFun);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastroFuncionario";
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
        private TextBox tbx_nomeFun;
        private TextBox tbx_foneFun;
        private TextBox tbx_emailFun;
        private Button btn_Salvar;
    }
}
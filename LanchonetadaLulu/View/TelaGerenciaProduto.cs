using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanchonetadaLulu.Contoller;
using LanchonetadaLulu.Model;

namespace LanchonetadaLulu.View
{
    public partial class TelaGerenciaProduto : Form
    {
        public TelaGerenciaProduto()
        {
            InitializeComponent();
        }

        private void btn_BuscarProdutoCodigo_Click(object sender, EventArgs e)
        {
            Produtos.Id_Produto = Convert.ToInt32(tbx_CodigoProduto.Text);
            ControllerProdutos controllerProdutos = new ControllerProdutos();
            controllerProdutos.VisualizarCodigoProdutos();

            tbx_CodigoProdutoVer.Text = Convert.ToString(Produtos.Id_Produto);
            tbx_ProdutoProdutoVer.Text = Produtos.Nome_Prod;
            tbx_PrecoProdutoVer.Text = Convert.ToString(Produtos.Preco_Prod);
            tbx_qtdProdutoVer.Text = Convert.ToString(Produtos.Qtd_Prod);
            cbx_TipoProdutoVer.Text = Produtos.Tipo_Prod;


        }

        private void btn_AlterarProduto_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoProduto.Text == "")
            {
                MessageBox.Show("Digite o do Produto ");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do Produtos: " + tbx_ProdutoProdutoVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Produtos.Id_Produto = Convert.ToInt32(tbx_CodigoProduto.Text);
                    Produtos.Nome_Prod = tbx_ProdutoProdutoVer.Text;
                    Produtos.Preco_Prod = Convert.ToInt32(tbx_PrecoProdutoVer.Text);
                    Produtos.Qtd_Prod = Convert.ToInt32(tbx_qtdProdutoVer.Text);
                    Produtos.Tipo_Prod = cbx_TipoProdutoVer.Text;

                    ControllerProdutos controllerProdutos = new ControllerProdutos();
                    controllerProdutos.AlterarProdutos();

                    tbx_CodigoProdutoVer.Text = "";
                    tbx_ProdutoProdutoVer.Text = "";
                    tbx_PrecoProdutoVer.Text = "";
                    tbx_qtdProdutoVer.Text = "";
                    cbx_TipoProdutoVer.Text = "";
                }
                else
                {

                    tbx_CodigoProdutoVer.Text = "";
                    tbx_ProdutoProdutoVer.Text = "";
                    tbx_PrecoProdutoVer.Text = "";
                    tbx_qtdProdutoVer.Text = "";
                    cbx_TipoProdutoVer.Text = "";
                    tbx_CodigoProduto.Focus();
                }
            }
        }

        private void btn_ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoProduto.Text == "")
            {
                MessageBox.Show("Digite o Código do Produtos");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja exluir as informações do Produtos: " + tbx_PrecoProdutoVer.Text + " ? ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);


                if (resposta == DialogResult.Yes)
                {
                    Produtos.Id_Produto = Convert.ToInt32(tbx_CodigoProduto.Text);

                    ControllerProdutos controllerProdutos = new ControllerProdutos();
                    controllerProdutos.DeletarProdutos();

                    tbx_CodigoProdutoVer.Text = "";
                    tbx_ProdutoProdutoVer.Text = "";
                    tbx_PrecoProdutoVer.Text = "";
                    tbx_qtdProdutoVer.Text = "";
                    cbx_TipoProdutoVer.Text = "";
                }
                else
                {

                    tbx_CodigoProdutoVer.Text = "";
                    tbx_ProdutoProdutoVer.Text = "";
                    tbx_PrecoProdutoVer.Text = "";
                    tbx_qtdProdutoVer.Text = "";
                    cbx_TipoProdutoVer.Text = "";
                    tbx_CodigoProduto.Focus();
                }
            }
        }

        private void btn_BuscarProduto_Click(object sender, EventArgs e)
        {
            Produtos.Nome_Prod = tbx_NomeProduto.Text;
            dataGridViewProdutos.DataSource = ControllerProdutos.VisualizarNomeProduto();
            dataGridViewProdutos.Columns[0].Visible = false;
            dataGridViewProdutos.Columns[1].Visible = false;
            dataGridViewProdutos.Columns[2].Visible = false;
            dataGridViewProdutos.Columns[3].Visible = false;
            dataGridViewProdutos.Columns[4].Visible = false;
            dataGridViewProdutos.Columns[5].HeaderCell.Value = "Código";
            dataGridViewProdutos.Columns[6].HeaderCell.Value = "Produto";
            dataGridViewProdutos.Columns[7].HeaderCell.Value = "Valor";
            dataGridViewProdutos.Columns[8].HeaderCell.Value = "Tipo";
            dataGridViewProdutos.Columns[9].HeaderCell.Value = "Quantidade";

        }
    }
}


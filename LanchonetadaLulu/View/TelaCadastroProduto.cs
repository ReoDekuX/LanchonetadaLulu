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
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //Pegar as informações e enviar para a Model
            Produtos.Nome_Prod = tbx_Produto.Text;
            Produtos.Qtd_Prod = Convert.ToInt32( tbx_qtd.Text);
            Produtos.Preco_Prod = Convert.ToInt32(tbx_Preco.Text);
            Produtos.Tipo_Prod = cbx_Tipo.Text;

            ControllerProdutos controllerProdutos = new ControllerProdutos();
            controllerProdutos.CadastrarProdutos();
            
        }
    }
}

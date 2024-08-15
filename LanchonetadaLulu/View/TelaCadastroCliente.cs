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
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Clientes.Nome_Cli = tbx_nome.Text;
            Clientes.Fone_Cli = tbx_fone.Text;
            Clientes.Cpf_Cli = tbx_cpf.Text;  

            ControllerClientes controllerClientes = new ControllerClientes();
            controllerClientes.CadastrarClientes();
        }
    }
}

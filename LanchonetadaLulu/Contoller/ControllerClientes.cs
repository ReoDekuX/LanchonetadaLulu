using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using LanchonetadaLulu.Model;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace LanchonetadaLulu.Contoller
{
    internal class ControllerClientes
    {
        public void CadastrarClientes()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastrarClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Clientes.Id_Cli);
                cmd.Parameters.AddWithValue("@nome", Clientes.Nome_Cli);
                cmd.Parameters.AddWithValue("@fone", Clientes.Fone_Cli);
                cmd.Parameters.AddWithValue("@cpf", Clientes.Cpf_Cli);


                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Cadastrados com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletarClientes()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PExcluirClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Clientes.Id_Cli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Deletados com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VisualizarCodigoClientes()
        {

            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PVisualizarCodigoCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Codigo", Clientes.Id_Cli);
                cn.Open();
                cmd.ExecuteNonQuery();


                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Clientes.Id_Cli = Convert.ToInt32(dr["Id_Cli"]);
                    Clientes.Nome_Cli = (String)dr["nome_Cli"];
                    Clientes.Fone_Cli = dr["fone_Cli"].ToString();
                    Clientes.Cpf_Cli = dr["cpf_Cli"].ToString();
                }
                else
                {
                    Clientes.Id_Cli = 0;
                    Clientes.Nome_Cli = "";
                    Clientes.Fone_Cli = "";
                    Clientes.Cpf_Cli = "";

                    MessageBox.Show("Código não localizado");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarClientes()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PAlterarClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Clientes.Id_Cli);
                cmd.Parameters.AddWithValue("@nome", Clientes.Nome_Cli);
                cmd.Parameters.AddWithValue("@fone", Clientes.Fone_Cli);
                cmd.Parameters.AddWithValue("@cpf", Clientes.Cpf_Cli);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static BindingSource VisualizarNomeCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PVisualizarTudoClientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeCliente", Clientes.Nome_Cli);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }

 }

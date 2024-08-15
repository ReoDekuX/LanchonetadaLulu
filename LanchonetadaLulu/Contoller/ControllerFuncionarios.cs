using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using LanchonetadaLulu.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LanchonetadaLulu.Contoller
{
    internal class ControllerFuncionarios
    {
        public void CadastrarFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastrarFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cmd.Parameters.AddWithValue("@nome", Funcionarios.Nome_Fun);
                cmd.Parameters.AddWithValue("@fone", Funcionarios.Fone_Fun);
                cmd.Parameters.AddWithValue("@email", Funcionarios.Email_Fun);


                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Cadastrados com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletarFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PExcluirFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Deletados com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void VisualizarCodigoFuncionarios()
        {

            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PVisualizarCodigoFuncionario", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Codigo", Funcionarios.Id_Fun);
                cn.Open();
                cmd.ExecuteNonQuery();


                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Funcionarios.Id_Fun = Convert.ToInt32(dr["Id_Fun"]);
                    Funcionarios.Nome_Fun = (String)dr["nome_Fun"];
                    Funcionarios.Fone_Fun = dr["fone_fun"].ToString();
                    Funcionarios.Email_Fun= dr["email_fun"].ToString();
                }
                else
                {
                    Funcionarios.Id_Fun = 0;
                    Funcionarios.Nome_Fun= "";
                    Funcionarios.Fone_Fun = "";
                    Funcionarios.Email_Fun = "";

                    MessageBox.Show("Código não localizado");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarFuncionarios()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PAlterarFuncionarios", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigo", Funcionarios.Id_Fun);
                cmd.Parameters.AddWithValue("@nome", Funcionarios.Nome_Fun);
                cmd.Parameters.AddWithValue("@fone", Funcionarios.Fone_Fun);
                cmd.Parameters.AddWithValue("@email", Funcionarios.Email_Fun);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros Alterados com Sucesso.");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static BindingSource VisualizarNomeFuncionario()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PVisualizarTudoFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeFuncionario", Funcionarios.Nome_Fun);
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

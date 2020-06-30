using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices;
using TRANSPORTADORA.CAMADAS.MODEL;

namespace TRANSPORTADORA.CAMADAS.DAL
{
    public class Motorista
    {
        private string strCon = Conexao.getConexao();

        //SELECT
        public List<MODEL.Motorista> Select()
        {
            List<MODEL.Motorista> listMotorista = new List<MODEL.Motorista>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Motorista";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Motorista motorista = new MODEL.Motorista();
                    motorista.id = Convert.ToInt32(dados["id"].ToString());
                    motorista.nome = dados["nome"].ToString();
                    motorista.telefone = dados["telefone"].ToString();
                    motorista.validadeCnh = Convert.ToDateTime(dados["validadeCnh"].ToString());
                    motorista.salario = Convert.ToSingle(dados["salario"].ToString());
                    

                    listMotorista.Add(motorista);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }
            finally
            {

            }

            return listMotorista;
        }

        public List<MODEL.Motorista> SelectByID(int id)
        {
            List<MODEL.Motorista> listMotorista = new List<MODEL.Motorista>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Motorista WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while(dados.Read())
                {
                    MODEL.Motorista motorista = new MODEL.Motorista();
                    motorista.id = Convert.ToInt32(dados["id"].ToString());
                    motorista.nome = dados["nome"].ToString();
                    motorista.telefone = dados["telefone"].ToString();
                    motorista.validadeCnh = Convert.ToDateTime(dados["validadeCnh"].ToString());
                    motorista.salario = Convert.ToSingle(dados["salario"].ToString());
                    

                    listMotorista.Add(motorista);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }
            finally
            {

            }

            return listMotorista;
        }

        public MODEL.Motorista SelectIDNome(int id)
        {
            MODEL.Motorista motorista = new MODEL.Motorista();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Motorista WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dados.Read())
                {                    
                    motorista.id = Convert.ToInt32(dados["id"].ToString());
                    motorista.nome = dados["nome"].ToString();
                    motorista.telefone = dados["telefone"].ToString();
                    motorista.validadeCnh = Convert.ToDateTime(dados["validadeCnh"].ToString());
                    motorista.salario = Convert.ToSingle(dados["salario"].ToString());                    
                                       
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }
            finally
            {

            }

            return motorista;
        }

        public List<MODEL.Motorista> SelectByNome(string nome)
        {
            List<MODEL.Motorista> listMotorista = new List<MODEL.Motorista>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Motorista WHERE (nome LIKE @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Motorista motorista = new MODEL.Motorista();
                    motorista.id = Convert.ToInt32(dados["id"].ToString());
                    motorista.nome = dados["nome"].ToString();
                    motorista.telefone = dados["telefone"].ToString();
                    motorista.validadeCnh = Convert.ToDateTime(dados["validadeCnh"].ToString());
                    motorista.salario = Convert.ToSingle(dados["salario"].ToString());

                    listMotorista.Add(motorista);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }
            finally
            {

            }

            return listMotorista;
        }

        //METODO INSERIR
        public void Inserir(MODEL.Motorista motorista)
        {            
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Motorista (nome, telefone, salario, validadeCnh, comissao) VALUES (@nome, @telefone, @salario, @validadeCnh, @comissao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", motorista.nome);
            cmd.Parameters.AddWithValue("@telefone", motorista.telefone);
            cmd.Parameters.AddWithValue("@salario", motorista.salario);
            cmd.Parameters.AddWithValue("@validadeCnh", motorista.validadeCnh);            

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("ERRO AO INSERIR MOTORISTA.");
            }
            finally
            {
                conexao.Close();
            }
        }

        //METODO UPDATE
        public void Update(MODEL.Motorista motorista)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Motorista SET nome=@nome, telefone=@telefone, salario=@salario, validadeCnh=@validadeCnh ";
                   sql += " WHERE id=@id";
            
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("id", motorista.id);
            cmd.Parameters.AddWithValue("nome", motorista.nome);
            cmd.Parameters.AddWithValue("telefone", motorista.telefone);
            cmd.Parameters.AddWithValue("salario", motorista.salario);
            cmd.Parameters.AddWithValue("validadeCnh", motorista.validadeCnh);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO REALIZAR UPDATE NA TABELA MOTORISTA!");
            }
            finally
            {

            }
        }

        //DELETE
        public void Delete(int idMotorista)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Motorista WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idMotorista);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO EXCLUIR MOTORISTA");
            }
            finally
            {

            }
        }

    }
}

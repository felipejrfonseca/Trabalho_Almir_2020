using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TRANSPORTADORA.CAMADAS.MODEL;

namespace TRANSPORTADORA.CAMADAS.DAL
{
    public class Cor
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cor> Select()
        {
            List<MODEL.Cor> listCor = new List<MODEL.Cor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Cor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dados.Read())
                {
                    MODEL.Cor cor = new MODEL.Cor();
                    cor.id = Convert.ToInt32(dados["id"].ToString());
                    cor.cor = dados["cor"].ToString();

                    listCor.Add(cor);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }

            finally
            {

            }

            return listCor;
        }

        public MODEL.Cor SelectIDNome(int id)
        {
            MODEL.Cor cor = new MODEL.Cor();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Cor WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dados.Read())
                {
                    cor.id = Convert.ToInt32(dados["id"].ToString());
                    cor.cor = dados["cor"].ToString();
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }
            finally
            {

            }

            return cor;
        }

        public void Inserir(MODEL.Cor cor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Cor (cor) VALUES (@COR) ;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@cor", cor.cor);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO INSERIR COR.");
            }
            finally
            {

            }
        }
        
    }
}

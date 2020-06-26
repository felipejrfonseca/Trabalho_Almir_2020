using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TRANSPORTADORA.CAMADAS.MODEL;
using System.Drawing.Imaging;

namespace TRANSPORTADORA.CAMADAS.DAL
{
    public class Caminhoes
    {
        private string strCon = Conexao.getConexao();

        //Metodo select
        public List<MODEL.Caminhao> Select()
        {
            List<MODEL.Caminhao> listCaminhao = new List<MODEL.Caminhao>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Caminhoes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Caminhao caminhao = new MODEL.Caminhao();
                    caminhao.id = Convert.ToInt32(dados["id"].ToString());
                    caminhao.placa = dados["placa"].ToString();
                    caminhao.modelo = dados["modelo"].ToString();
                    caminhao.cor = Convert.ToInt32(dados["corFK"].ToString());
                    caminhao.motorista = Convert.ToInt32(dados["motoristaFK"].ToString());

                    listCaminhao.Add(caminhao);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }

            finally
            {

            }

            return listCaminhao;
        }

        //INSERT
        public void Insert(MODEL.Caminhao caminhao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Caminhoes (placa, modelo, corFK, motoristaFK) VALUES (@placa, @modelo, @corFK, @motoristaFK);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@placa", caminhao.placa);
            cmd.Parameters.AddWithValue("@modelo", caminhao.modelo);
            cmd.Parameters.AddWithValue("@corFK", caminhao.cor);
            cmd.Parameters.AddWithValue("@motoristaFK", caminhao.motorista);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO INSERIR CAMINHÃO.");
            }

            finally
            {

            }
        }

        //METODO UPDATE
        public void Update(MODEL.Caminhao caminhao)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Caminhoes SET placa=@placa, modelo=@modelo, corFK=@corFK, motoristaFK=@motoristaFK WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("id", caminhao.id);
            cmd.Parameters.AddWithValue("placa", caminhao.placa);
            cmd.Parameters.AddWithValue("modelo", caminhao.modelo);
            cmd.Parameters.AddWithValue("corFK", caminhao.cor);
            cmd.Parameters.AddWithValue("motoristaFK", caminhao.motorista);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO REALIZAR UPDATE NA TABELA CAMINHÕES!");
            }

            finally
            {

            }
        }

        //EXCLUIR
        public void Delete(int idCaminhoes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Caminhoes WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCaminhoes);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO EXCLUIR CAMINHÃO!");
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TRANSPORTADORA.CAMADAS.MODEL;
using System.Runtime.Remoting.Messaging;
using System.Runtime.InteropServices;

namespace TRANSPORTADORA.CAMADAS.DAL
{
    public class Transportadora
    {
        private string strCon = Conexao.getConexao();

        //SELECT
        public List<MODEL.Transportadora> Select()
        {
            List<MODEL.Transportadora> listTransportadora = new List<MODEL.Transportadora>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Transportadora;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while(dados.Read())
                {
                    MODEL.Transportadora transportadora = new MODEL.Transportadora();
                    transportadora.id = Convert.ToInt32(dados["id"].ToString());
                    transportadora.nomeTransportadora = dados["nomeTransportadora"].ToString();

                    listTransportadora.Add(transportadora);
                }
            }
            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR BANCO");
            }
            finally
            {

            }

            return listTransportadora;
        }
        
        //METODO INSERIR
        public void Inserir(MODEL.Transportadora transportadora)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Transportadora (nomeTransportadora) VALUES (@nomeTransportadora);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomeTransportadora", transportadora.nomeTransportadora);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO INSERIR TRANSPORTADORA.");
            }
            finally
            {

            }
        }

        //METODO UPDATE
        public void Update(MODEL.Transportadora transportadora)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Transportadora SET nomeTransportadora=@nomeTransportadora WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("id", transportadora.id);
            cmd.Parameters.AddWithValue("@nomeTransportadora", transportadora.nomeTransportadora);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO REALIZAR UPDATE NA TABELA TRANSPORTADORA!");
            }
            finally
            {

            }
        }

        //DELETE
        public void Delete(int idTransportadora)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Transportadora WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idTransportadora);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO EXCLUIR TRANSPORTADORA");
            }
            finally
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TRANSPORTADORA.CAMADAS.MODEL;
using System.Runtime.Remoting.Messaging;

namespace TRANSPORTADORA.CAMADAS.DAL
{
    public class Frete
    {
        private string strCon = Conexao.getConexao();

        //SELECT
        public List<MODEL.Frete> Select()
        {
            List<MODEL.Frete> listFrete = new List<MODEL.Frete>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Frete;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while(dados.Read())
                {
                    MODEL.Frete frete = new MODEL.Frete();
                    frete.id = Convert.ToInt32(dados["id"].ToString());
                    frete.produto = dados["produto"].ToString();
                    frete.localPartida = dados["localPartida"].ToString();
                    frete.localEntrega = dados["localEntrega"].ToString();
                    frete.data = Convert.ToDateTime(dados["data"].ToString());
                    frete.valor = Convert.ToSingle(dados["valorFrete"].ToString());
                    frete.transportadora = Convert.ToInt32(dados["transportadoraFK"].ToString());
                    frete.motorista = Convert.ToInt32(dados["motoristaFK"].ToString());

                    CAMADAS.DAL.Motorista dalMoto = new CAMADAS.DAL.Motorista();
                    CAMADAS.MODEL.Motorista motorista = dalMoto.SelectIDNome(frete.motorista);
                    frete.nomeMotorista = motorista.nome;

                    CAMADAS.DAL.Transportadora dalTransportadora = new CAMADAS.DAL.Transportadora();
                    CAMADAS.MODEL.Transportadora transportadora = dalTransportadora.SelectIDNome(frete.transportadora);
                    frete.nomeTransportadora = transportadora.transportadoraNome;

                    listFrete.Add(frete);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR O BANCO DE DADOS!");
            }
            finally
            {

            }

            return listFrete;
        }

        //METODO INSERIR
        public void Inserir(MODEL.Frete frete)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Frete (produto, localPartida, localEntrega, data, valorFrete, TransportadoraFK, motoristaFK) VALUES (@produto, @localPartida, @localEntrega, @data, @valorFrete, @transportadoraFK, @motoristaFK);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@produto", frete.produto);
            cmd.Parameters.AddWithValue("@localPartida", frete.localPartida);
            cmd.Parameters.AddWithValue("@localEntrega", frete.localEntrega);
            cmd.Parameters.AddWithValue("@data", frete.data);
            cmd.Parameters.AddWithValue("@valorFrete", frete.valor);
            cmd.Parameters.AddWithValue("@transportadoraFK", frete.transportadora);
            cmd.Parameters.AddWithValue("@motoristaFK", frete.motorista);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO INSERIR FRETE.");
            }

            finally
            {
                conexao.Close();
            }
                        
        }

        //UPDATE
        public void Update(MODEL.Frete frete)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Frete SET produto=@produto, localPartida=@localPartida, localEntrega=@localEntrega, data=@data, valorFrete=@valorFrete, transportadoraFK=@transportadoraFK, motoristaFK=@motoristaFK WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("id", frete.id);
            cmd.Parameters.AddWithValue("produto", frete.produto);
            cmd.Parameters.AddWithValue("localPartida", frete.localPartida);
            cmd.Parameters.AddWithValue("localEntrega", frete.localEntrega);
            cmd.Parameters.AddWithValue("data", frete.data);
            cmd.Parameters.AddWithValue("valorFrete", frete.valor);
            cmd.Parameters.AddWithValue("transportadoraFK", frete.transportadora);
            cmd.Parameters.AddWithValue("motoristaFK", frete.motorista);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO REALIZAR UPDATE NA TABELA FRETE!");
            }

            finally
            {
                conexao.Close();
            }
        }

        //DELETE
        public void Delete(int idFrete)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Frete WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("id", idFrete);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }

            catch
            {
                Console.WriteLine("ERRO AO EXCLUIR FRETE");
            }

            finally
            {
                conexao.Close();
            }
        }

    }    
}
    


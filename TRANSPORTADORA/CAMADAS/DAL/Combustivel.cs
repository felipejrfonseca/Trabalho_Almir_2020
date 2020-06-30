using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using TRANSPORTADORA.CAMADAS.MODEL;

namespace TRANSPORTADORA.CAMADAS.DAL
{
    public class Combustivel
    {
        private string strCon = Conexao.getConexao();

        //SELECT
        public List<MODEL.Combustivel> Select()
        {
            List<MODEL.Combustivel> listCombustivel = new List<MODEL.Combustivel>();
            CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
            CAMADAS.DAL.Caminhoes dalCaminhoes = new CAMADAS.DAL.Caminhoes();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Combustivel;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dados.Read())
                {
                    MODEL.Combustivel combustivel = new MODEL.Combustivel();
                    combustivel.id = Convert.ToInt32(dados["id"].ToString());
                    combustivel.estoque = Convert.ToInt32(dados["estoque"].ToString());
                    combustivel.caminhaoID = Convert.ToInt32(dados["caminhaoFK"].ToString());                
                    combustivel.motoristaID = Convert.ToInt32(dados["motoristaFK"].ToString());

                    CAMADAS.DAL.Motorista dalMoto = new CAMADAS.DAL.Motorista();
                    CAMADAS.MODEL.Motorista motorista = dalMoto.SelectIDNome(combustivel.motoristaID);
                    combustivel.nomeMotorista = motorista.nome;

                    CAMADAS.DAL.Caminhoes dalCam = new CAMADAS.DAL.Caminhoes();
                    CAMADAS.MODEL.Caminhao caminhoes = dalCam.SelectIDnome(combustivel.caminhaoID);
                    combustivel.placaCaminhao = caminhoes.placa;
                    
                    listCombustivel.Add(combustivel);
                }
            }

            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR BANCO");
            }

            finally
            {

            }

            return listCombustivel;
        }


        public List<MODEL.Combustivel> SelectByID(int id)
        {
            List<MODEL.Combustivel> listCombustivel = new List<MODEL.Combustivel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Combustivel WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dados.Read())
                {                    
                    MODEL.Combustivel combustivel = new MODEL.Combustivel();
                    combustivel.id = Convert.ToInt32(dados["id"].ToString());
                    combustivel.estoque = Convert.ToInt32(dados["estoque"].ToString());
                    combustivel.caminhaoID = Convert.ToInt32(dados["caminhaoFK"].ToString());
                    combustivel.motoristaID = Convert.ToInt32(dados["motoristaFK"].ToString());

                    listCombustivel.Add(combustivel);
                }
            }
            catch
            {
                Console.WriteLine("ERRO AO CONSULTAR BANCO");
            }
            finally
            {

            }

            return listCombustivel;
        }

        /*
        public void BaixaEstoque(MODEL.Combustivel combustivel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Combustivel SET estoque = estoque-@estoque WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@estoque", combustivel.estoque);
            cmd.Parameters.AddWithValue("@id_produto", combustivel.id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO NA BAIXA DE ESTOQUE!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void EntradaEstoque(MODEL.Combustivel combustivel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Combustivel SET estoque = estoque+@estoque WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@estoque", combustivel.estoque);
            cmd.Parameters.AddWithValue("@id_produto", combustivel.id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO NA BAIXA DE ESTOQUE!");
            }
            finally
            {
                conexao.Close();
            }
        }*/

        /*
        public int SelectID()
        {

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select SUM(estoque) from Combustivel;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            int estoque = 0;
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Combustivel combustivel = new MODEL.Combustivel();
                    combustivel.atualEstoque = Convert.ToInt32(dados["estoque"].ToString());
                    estoque = combustivel.atualEstoque;
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na consulta de VendasID...");
            }
            finally
            {
                conexao.Close();
            }
            return estoque;
        }*/

        /*
        public List<MODEL.Combustivel> SelectByNome(string nome)
        {
            List<MODEL.Combustivel> listCombustivel = new List<MODEL.Combustivel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT *FROM Combustivel WHERE (nomeTransportadora LIKE @nomeTransportadora);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomeTransportadora", "%" + nome.Trim() + "%");

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dados.Read())
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
        }*/

        //METODO INSERIR
        public void Inserir(MODEL.Combustivel combustivel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Combustivel (estoque, caminhaoFK, motoristaFK) VALUES (@estoque, @caminhaoFK, @motoristaFK);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@estoque", combustivel.estoque);
            cmd.Parameters.AddWithValue("caminhaoFK", combustivel.caminhaoID);
            cmd.Parameters.AddWithValue("motoristaFK", combustivel.motoristaID);            

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO INSERIR NOVO ESTOQUE.");
            }
            finally
            {

            }
        }
        /*
        //METODO UPDATE
        public void Update(MODEL.Combustivel combustivel)
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
        }*/

        //DELETE
        public void Delete(int idCombustivel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Combustivel WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCombustivel);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO EXCLUIR COMBUSTIVEL");
            }
            finally
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS.BLL
{
    public class Combustivel
    {
        public List<MODEL.Combustivel> Select()
        {
            DAL.Combustivel dalCombustivel = new DAL.Combustivel();
            return dalCombustivel.Select();
        }

        public List<MODEL.Combustivel> SelectByID(int id)
        {
            DAL.Combustivel dalCombustivel = new DAL.Combustivel();
            return dalCombustivel.SelectByID(id);
        }

        public List<MODEL.Transportadora> SelectByNome(string nome)
        {
            DAL.Transportadora daltransportadora = new DAL.Transportadora();
            return daltransportadora.SelectByNome(nome);
        }

        public void Insert(MODEL.Combustivel combustivel)
        {
            DAL.Combustivel dalCombustivel = new DAL.Combustivel();
            dalCombustivel.Inserir(combustivel);
        }

        
        public void Update(MODEL.Transportadora transportadora)
        {
            DAL.Transportadora dalTransportadora = new DAL.Transportadora();
            dalTransportadora.Update(transportadora);
        }

        public void Delete(int idCombustivel)
        {
            if (idCombustivel > 0)
            {
                DAL.Combustivel dalCombustivel = new DAL.Combustivel();
                dalCombustivel.Delete(idCombustivel);
            }

            else
            {
                MessageBox.Show("ITEN PARA EXCLUSÃO NÃO SELECIONADO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

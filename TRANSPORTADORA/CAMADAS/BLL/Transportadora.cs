using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS.BLL
{
    public class Transportadora
    {
        public List<MODEL.Transportadora> Select()
        {
            DAL.Transportadora daltransportadora = new DAL.Transportadora();
            return daltransportadora.Select();
        }

        public List<MODEL.Transportadora> SelectByID(int id)
        {
            DAL.Transportadora daltransportadora = new DAL.Transportadora();
            return daltransportadora.SelectByID(id);
        }

        public List<MODEL.Transportadora> SelectByNome(string nome)
        {
            DAL.Transportadora daltransportadora = new DAL.Transportadora();
            return daltransportadora.SelectByNome(nome);
        }

        public void Insert(MODEL.Transportadora transportadora)
        {
            DAL.Transportadora dalTransportadora = new DAL.Transportadora();
            dalTransportadora.Inserir(transportadora);
        }

        public void Update(MODEL.Transportadora transportadora)
        {
            DAL.Transportadora dalTransportadora = new DAL.Transportadora();
            dalTransportadora.Update(transportadora);
        }

        public void Delete(int IdTransportadora)
        {
            if (IdTransportadora > 0)
            {
                DAL.Transportadora dalTransportadora = new DAL.Transportadora();
                dalTransportadora.Delete(IdTransportadora);
            }

            else
            {
                MessageBox.Show("ITEN PARA EXCLUSÃO NÃO SELECIONADO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}

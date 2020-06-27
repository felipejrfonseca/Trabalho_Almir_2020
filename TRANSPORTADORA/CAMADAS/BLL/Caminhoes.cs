using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS.BLL
{
    public class Caminhoes
    {
        public List<MODEL.Caminhao> Select()
        {
            DAL.Caminhoes dalCaminhao = new DAL.Caminhoes();
            return dalCaminhao.Select();
        }

        public void Insert(MODEL.Caminhao caminhao)
        {
            DAL.Caminhoes dalCaminhao = new DAL.Caminhoes();
            dalCaminhao.Insert(caminhao);
        }

        public void Update(MODEL.Caminhao caminhao)
        {
            DAL.Caminhoes dalCaminhao = new DAL.Caminhoes();
            dalCaminhao.Update(caminhao);
        }

        public void Delete(int idCaminhao)
        {
            if(idCaminhao > 0)
            {
                DAL.Caminhoes dalCaminhao = new DAL.Caminhoes();
                dalCaminhao.Delete(idCaminhao);
            }

            else
            {
                MessageBox.Show("ITEN PARA EXCLUSÃO NÃO SELECIONADO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

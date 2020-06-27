using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS.BLL
{
    public class Frete
    {
        public List<MODEL.Frete> Select()
        {
            DAL.Frete dalFrete = new DAL.Frete();
            return dalFrete.Select();
        }

        public void Insert(MODEL.Frete frete)
        {
            DAL.Frete dalFrete = new DAL.Frete();
            dalFrete.Inserir(frete);
        }

        public void Update(MODEL.Frete frete)
        {
            DAL.Frete dalFrete = new DAL.Frete();
            dalFrete.Update(frete);
        }

        public void Delete(int idFrete)
        {
            if(idFrete > 0)
            {
                DAL.Frete dalFrete = new DAL.Frete();
                dalFrete.Delete(idFrete);
            }

            else
            {
                MessageBox.Show("ITEN PARA EXCLUSÃO NÃO SELECIONADO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

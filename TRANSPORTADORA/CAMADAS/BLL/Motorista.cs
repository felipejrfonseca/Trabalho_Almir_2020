using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS.BLL
{
    public class Motorista
    {
        public List<MODEL.Motorista> Select()
        {
            DAL.Motorista dalMotorista = new DAL.Motorista();
            return dalMotorista.Select();
        }

        public List<MODEL.Motorista> SelectByID(int id)
        {
            DAL.Motorista dalMotorista = new DAL.Motorista();
            return dalMotorista.SelectByID(id);
        }

        public List<MODEL.Motorista> SelectByNome(string nome)
        {
            DAL.Motorista dalMotorista = new DAL.Motorista();
            return dalMotorista.SelectByNome(nome);
        }
        public void Insert(MODEL.Motorista motorista)
        {
            DAL.Motorista dalMotorista = new DAL.Motorista();
            dalMotorista.Inserir(motorista);
        }

        public void Update(MODEL.Motorista motorista)
        {
            DAL.Motorista dalMotorista = new DAL.Motorista();
            dalMotorista.Update(motorista);

        }

        public void Delete(int idMotorista)
        {
            if(idMotorista > 0)
            {
                DAL.Motorista dalMotorista = new DAL.Motorista();
                dalMotorista.Delete(idMotorista);
            }

            else
            {
                MessageBox.Show("ITEN PARA EXCLUSÃO NÃO SELECIONADO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA.CAMADAS
{
    public partial class FormTransportadora : Form
    {
        public FormTransportadora()
        {
            InitializeComponent();
        }

        private void FormTransportadora_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Transportadora dalTransportadora = new CAMADAS.DAL.Transportadora();
            DGTransportadora.DataSource = dalTransportadora.Select();
        }

        
        //LIMPANDO OS CAMPOS
        private void limparcontrole()
        {
            txtID.Text = "-1";
            txtTransportadora.Text = "";
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {       
            if (txtTransportadora.Text != "")
            {
                CAMADAS.MODEL.Transportadora transportadora = new CAMADAS.MODEL.Transportadora();
                transportadora.nomeTransportadora = txtTransportadora.Text;
                CAMADAS.DAL.Transportadora dalTransportadora = new CAMADAS.DAL.Transportadora();
                dalTransportadora.Inserir(transportadora);

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = dalTransportadora.Select();
                limparcontrole();
            }

            else 
            {
                MessageBox.Show("TODOS OS ITENS DEVEM SER PREENCHIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            limparcontrole();
            
            CAMADAS.MODEL.Transportadora transportadora = new CAMADAS.MODEL.Transportadora();

            transportadora.id = Convert.ToInt32(txtID.Text);
            transportadora.nomeTransportadora = txtTransportadora.Text;

            CAMADAS.DAL.Transportadora dalTransportadora = new CAMADAS.DAL.Transportadora();
            dalTransportadora.Update(transportadora);

            DGTransportadora.DataSource = "";
            DGTransportadora.DataSource = dalTransportadora.Select();
                
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            if (txtID != null)
            {
                int idTransportadora = Convert.ToInt32(txtID.Text);
                CAMADAS.DAL.Transportadora dalTransportadora = new CAMADAS.DAL.Transportadora();
                dalTransportadora.Delete(idTransportadora);

                limparcontrole();

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = dalTransportadora.Select();
            }

            else
            {
                MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

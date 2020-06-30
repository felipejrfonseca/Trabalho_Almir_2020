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
            limparcontrole();
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
                CAMADAS.BLL.Transportadora bllTransportadora = new CAMADAS.BLL.Transportadora();
                CAMADAS.MODEL.Transportadora transportadora = new CAMADAS.MODEL.Transportadora();
                transportadora.transportadoraNome = txtTransportadora.Text;

                bllTransportadora.Insert(transportadora);

                limparcontrole();

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = bllTransportadora.Select();
                
            }

            else 
            {
                MessageBox.Show("TODOS OS ITENS DEVEM SER PREENCHIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {       
            if(txtID.Text != "-1")
            {
                CAMADAS.MODEL.Transportadora transportadora = new CAMADAS.MODEL.Transportadora();
                transportadora.id = Convert.ToInt32(txtID.Text);
                transportadora.transportadoraNome = txtTransportadora.Text;

                CAMADAS.BLL.Transportadora bllTransportadora = new CAMADAS.BLL.Transportadora();
                bllTransportadora.Update(transportadora);

                limparcontrole();

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = bllTransportadora.Select();
            }

            else
            {
                MessageBox.Show("Nenhuma Transportadora Foi Selecionada para Edição", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Transportadora bllTransportadora = new CAMADAS.BLL.Transportadora();

            if (txtID.Text != null)
            {
                if(txtID.Text != "-1")
                {
                    DialogResult resp = MessageBox.Show("Deseja Excluir Realmente Transportadora?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (resp == DialogResult.Yes)
                    {
                        int idTransportadora = Convert.ToInt32(txtID.Text);
                        bllTransportadora.Delete(idTransportadora);
                    }
                }

                else
                {
                    MessageBox.Show("Nenhuma Transportadora Selecionada Para Exclusão!", "Excluir Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                limparcontrole();

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = bllTransportadora.Select();
            }

            else
            {
                MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGTransportadora_DoubleClick(object sender, EventArgs e)
        {            
            txtID.Text = DGTransportadora.SelectedRows[0].Cells["id"].Value.ToString();
            txtTransportadora.Text = DGTransportadora.SelectedRows[0].Cells["transportadoraNome"].Value.ToString();
            
        }

        private void DGTransportadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GbBuscar.Visible = !GbBuscar.Visible;

            CAMADAS.BLL.Transportadora bllTransportadora = new CAMADAS.BLL.Transportadora();
            DGTransportadora.DataSource = "";
            DGTransportadora.DataSource = bllTransportadora.Select();
        }

        private void RBId_CheckedChanged(object sender, EventArgs e)
        {
            LBFiltro.Text = "Informe o ID da Transportadora: ";
            TxtFiltro.Text = "";
            TxtFiltro.Focus();
        }

        private void RBNome_CheckedChanged(object sender, EventArgs e)
        {
            LBFiltro.Text = "Informe o Nome da Transportadora:";
            TxtFiltro.Text = "";
            TxtFiltro.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Transportadora bllTransportadora = new CAMADAS.BLL.Transportadora();
            List<CAMADAS.MODEL.Transportadora> listTransportadora = new List<CAMADAS.MODEL.Transportadora>();
            
            if(RBId.Checked)
            {
                int id = Convert.ToInt32(TxtFiltro.Text);
                listTransportadora = bllTransportadora.SelectByID(id);

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = bllTransportadora.SelectByID(id);
            }
            else if(RBNome.Checked)
            {
                string nome = TxtFiltro.Text;
                listTransportadora = bllTransportadora.SelectByNome(nome);

                DGTransportadora.DataSource = "";
                DGTransportadora.DataSource = bllTransportadora.SelectByNome(nome);
            }
        }
    }
}

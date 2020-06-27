using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRANSPORTADORA
{
    public partial class FormMotoristas : Form
    {
        public FormMotoristas()
        {
            InitializeComponent();
            limparcontrole();
        }

        //LIMPANDO OS CAMPOS
        private void limparcontrole()
        {
            txtID.Text = "-1";
            txtNome.Text = "";
            txtSalario.Text = "";
            txtTelefone.Text = "";
            txtValidadeCnh.Text = "";
        }

        private void FormMotoristas_Load(object sender, EventArgs e)
        {            
            CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
            DGMotorista.DataSource = "";
            DGMotorista.DataSource = dalMotorista.Select();
        }

        private void DGMotoristas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtSalario.Text != "" && txtTelefone.Text != "" && txtValidadeCnh.Text != "")
            {
                CAMADAS.BLL.Motorista bllmotorista = new CAMADAS.BLL.Motorista();
                CAMADAS.MODEL.Motorista motorista = new CAMADAS.MODEL.Motorista();

                motorista.nome = txtNome.Text;
                motorista.telefone = txtTelefone.Text;
                motorista.salario = Convert.ToSingle(txtSalario.Text);
                motorista.validadeCnh = Convert.ToDateTime(txtValidadeCnh.Text);
                bllmotorista.Insert(motorista);

                limparcontrole();

                DGMotorista.DataSource = "";
                DGMotorista.DataSource = bllmotorista.Select();                
            }

            else
            {
                MessageBox.Show("TODOS OS ITENS DEVEM SER PREENCHIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "-1")
            {
                CAMADAS.MODEL.Motorista motorista = new CAMADAS.MODEL.Motorista();

                motorista.id = Convert.ToInt32(txtID.Text);
                motorista.nome = txtNome.Text;
                motorista.telefone = txtTelefone.Text;
                motorista.salario = Convert.ToSingle(txtSalario.Text);
                motorista.validadeCnh = Convert.ToDateTime(txtValidadeCnh.Text);

                CAMADAS.BLL.Motorista bllMotorista = new CAMADAS.BLL.Motorista();
                bllMotorista.Update(motorista);

                limparcontrole();

                DGMotorista.DataSource = "";
                DGMotorista.DataSource = bllMotorista.Select();
            } 
            
            else
            {
                MessageBox.Show("Nenhum Motorista Selecionado para Edição", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Motorista bllMotorista = new CAMADAS.BLL.Motorista();

            if (txtID.Text != "-1")
            {
                DialogResult resp = MessageBox.Show("Deseja Excluir Realmente Motorista?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    int idMotorista = Convert.ToInt32(txtID.Text);
                    bllMotorista.Delete(idMotorista);
                }
            }

            else
            {
                MessageBox.Show("Nenhum Motorista Selecionado Para Exclusão!", "Excluir Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limparcontrole();

            DGMotorista.DataSource = "";
            DGMotorista.DataSource = bllMotorista.Select();
        }

        private void DGMotorista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGMotorista_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = DGMotorista.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = DGMotorista.SelectedRows[0].Cells["nome"].Value.ToString();
            txtTelefone.Text = DGMotorista.SelectedRows[0].Cells["telefone"].Value.ToString();
            txtSalario.Text = DGMotorista.SelectedRows[0].Cells["salario"].Value.ToString();
            txtValidadeCnh.Text = DGMotorista.SelectedRows[0].Cells["validadeCnh"].Value.ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GbBuscar.Visible = !GbBuscar.Visible;
            CAMADAS.BLL.Motorista bllMotorista = new CAMADAS.BLL.Motorista();

            DGMotorista.DataSource = "";
            DGMotorista.DataSource = bllMotorista.Select();
        }

        private void RBId_CheckedChanged(object sender, EventArgs e)
        {
            LBFiltro.Text = "Informe o ID do Motorista:";
            TxtFiltro.Text = "";
            TxtFiltro.Focus();
        }

        private void RBNome_CheckedChanged(object sender, EventArgs e)
        {
            LBFiltro.Text = "Informe o Nome do Motorista:";
            TxtFiltro.Text = "";
            TxtFiltro.Focus();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Motorista bllMotorista = new CAMADAS.BLL.Motorista();
            List<CAMADAS.MODEL.Motorista> listMotorista = new List<CAMADAS.MODEL.Motorista>();

            if(RBId.Checked)
            {
                int id = Convert.ToInt32(TxtFiltro.Text);
                listMotorista = bllMotorista.SelectByID(id);

                DGMotorista.DataSource = "";
                DGMotorista.DataSource = bllMotorista.SelectByID(id);
            }

            else if(RBNome.Checked)
            {
                string nome = TxtFiltro.Text;
                listMotorista = bllMotorista.SelectByNome(nome);

                DGMotorista.DataSource = "";
                DGMotorista.DataSource = bllMotorista.SelectByNome(nome);
            }
        }
    }
}

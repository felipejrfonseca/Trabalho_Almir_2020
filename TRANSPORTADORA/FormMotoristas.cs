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
            txtID.Text = "-1";

            if (txtNome.Text != "" && txtSalario.Text != "" && txtTelefone.Text != "" && txtValidadeCnh.Text != "")
            {
                CAMADAS.MODEL.Motorista motorista = new CAMADAS.MODEL.Motorista();

                motorista.nome = txtNome.Text;
                motorista.telefone = txtTelefone.Text;
                motorista.salario = Convert.ToSingle(txtSalario.Text);
                motorista.validadeCnh = Convert.ToDateTime(txtValidadeCnh.Text);

                CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
                dalMotorista.Inserir(motorista);

                DGMotorista.DataSource = "";
                DGMotorista.DataSource = dalMotorista.Select();
                limparcontrole();
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
            CAMADAS.MODEL.Motorista motorista = new CAMADAS.MODEL.Motorista();

            motorista.id = Convert.ToInt32(txtID.Text);
            motorista.nome = txtNome.Text;
            motorista.telefone = txtTelefone.Text;
            motorista.salario = Convert.ToSingle(txtSalario.Text);
            motorista.validadeCnh = Convert.ToDateTime(txtValidadeCnh.Text);

            CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
            dalMotorista.Update(motorista);

            limparcontrole();

            DGMotorista.DataSource = "";
            DGMotorista.DataSource = dalMotorista.Select();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int idMotorista = Convert.ToInt32(txtID.Text);
            CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
            dalMotorista.Delete(idMotorista);

            limparcontrole();

            DGMotorista.DataSource = "";
            DGMotorista.DataSource = dalMotorista.Select();
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
    }
}

﻿using System;
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
    public partial class FormCaminhoes : Form
    {
        public FormCaminhoes()
        {
            InitializeComponent();
            limparcontrole();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void limparcontrole()
        {
            txtID.Text = "-1";
            txtPlaca.Text = "";
            txtModelo.Text = "";
            cmbCor.Text = "";
            txtIdCor.Text = "";
            cmbMotorista.Text = "";
            txtIdMotorista.Text = "";

        }

        private void FormCaminhoes_Load(object sender, EventArgs e)
        {
            limparcontrole();

            CAMADAS.DAL.Caminhoes dalCaminhoes = new CAMADAS.DAL.Caminhoes();
            CAMADAS.DAL.Motorista dalMotorista = new CAMADAS.DAL.Motorista();
            CAMADAS.DAL.Cor dalcor = new CAMADAS.DAL.Cor();
            DGCaminhoes.DataSource = "";
            DGCaminhoes.DataSource = dalCaminhoes.Select();

            //COMBOBOX MOTORISTA
            cmbMotorista.DisplayMember = "nome";
            cmbMotorista.ValueMember = "id";
            cmbMotorista.DataSource = dalMotorista.Select();

            cmbCor.DisplayMember = "cor";
            cmbCor.ValueMember = "id";
            cmbCor.DataSource = dalcor.Select();
        }

        private void DGCaminhoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text != "" && txtModelo.Text != "" && txtIdCor.Text != "" && txtModelo.Text != "")
            {
                CAMADAS.BLL.Caminhoes bllCaminhoes = new CAMADAS.BLL.Caminhoes();
                CAMADAS.MODEL.Caminhao caminhoes = new CAMADAS.MODEL.Caminhao();

                caminhoes.placa = txtPlaca.Text;
                caminhoes.modelo = txtModelo.Text;
                caminhoes.cor = Convert.ToInt32(txtIdCor.Text);
                caminhoes.motorista = Convert.ToInt32(txtIdMotorista.Text);
                bllCaminhoes.Insert(caminhoes);
                
                limparcontrole();

                DGCaminhoes.DataSource = "";
                DGCaminhoes.DataSource = bllCaminhoes.Select();

                MessageBox.Show("CAMINHÃO INSERIDO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("TODOS OS ITENS DEVEM SER PREENCHIDOS!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ID MOTORISTA PARA COMBOBOX
            txtIdMotorista.Text = cmbMotorista.SelectedValue.ToString();
        }

        private void cmbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCor.Text = cmbCor.SelectedValue.ToString();
        }

        private void txtIdCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdMotorista_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "-1")
            {
                CAMADAS.MODEL.Caminhao caminhao = new CAMADAS.MODEL.Caminhao();

                caminhao.id = Convert.ToInt32(txtID.Text);
                caminhao.placa = txtPlaca.Text;
                caminhao.modelo = txtModelo.Text;
                caminhao.cor = Convert.ToInt32(txtIdCor.Text);
                caminhao.motorista = Convert.ToInt32(txtIdMotorista.Text);

                CAMADAS.BLL.Caminhoes bllCaminhoes = new CAMADAS.BLL.Caminhoes();
                bllCaminhoes.Update(caminhao);

                MessageBox.Show("Alteração Realizada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                limparcontrole();

                DGCaminhoes.DataSource = "";
                DGCaminhoes.DataSource = bllCaminhoes.Select();
            }

            else
            {
                MessageBox.Show("Nenhum Caminhão Selecionado para Edição", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Caminhoes bllCaminhoes = new CAMADAS.BLL.Caminhoes();

            if (txtID.Text != "-1")
            {
                DialogResult resp = MessageBox.Show("Deseja Excluir Realmente Caminhão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if(resp == DialogResult.Yes)
                {
                    int idCaminhoes = Convert.ToInt32(txtID.Text);                    
                    bllCaminhoes.Delete(idCaminhoes);
                }
            }

            else
            {
                MessageBox.Show("Nenhum Caminhão Selecionado Para Exclusão!", "Excluir Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limparcontrole();
                       
            DGCaminhoes.DataSource = "";
            DGCaminhoes.DataSource = bllCaminhoes.Select();                       
        }

        private void DGCaminhoes_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = DGCaminhoes.SelectedRows[0].Cells["id"].Value.ToString();
            txtPlaca.Text = DGCaminhoes.SelectedRows[0].Cells["placa"].Value.ToString();
            txtModelo.Text = DGCaminhoes.SelectedRows[0].Cells["modelo"].Value.ToString();
            /*txtIdCor.Text = DGCaminhoes.SelectedRows[0].Cells["corFK"].Value.ToString();
            cmbCor.Text = DGCaminhoes.SelectedRows[0].Cells["corFK"].Value.ToString();
            txtIdMotorista.Text = DGCaminhoes.SelectedRows[0].Cells["motoristaFK"].Value.ToString();
            cmbMotorista.Text = DGCaminhoes.SelectedRows[0].Cells["motoristaFK"].Value.ToString();*/
        }
    }
}

namespace TRANSPORTADORA.CAMADAS
{
    partial class FormCaminhoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGCaminhoes = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.cmbMotorista = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMotorista = new System.Windows.Forms.TextBox();
            this.txtIdCor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGCaminhoes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(279, 96);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(220, 20);
            this.txtPlaca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "PLACA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(279, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID:";
            // 
            // DGCaminhoes
            // 
            this.DGCaminhoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCaminhoes.Location = new System.Drawing.Point(12, 268);
            this.DGCaminhoes.Name = "DGCaminhoes";
            this.DGCaminhoes.Size = new System.Drawing.Size(884, 262);
            this.DGCaminhoes.TabIndex = 28;
            this.DGCaminhoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCaminhoes_CellContentClick);
            this.DGCaminhoes.DoubleClick += new System.EventHandler(this.DGCaminhoes_DoubleClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(19, 164);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 38);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(19, 98);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 38);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(19, 32);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(88, 38);
            this.BtnInserir.TabIndex = 7;
            this.BtnInserir.Text = "INSERIR";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(279, 138);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(220, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "MODELO:";
            // 
            // cmbCor
            // 
            this.cmbCor.DisplayMember = "id";
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Location = new System.Drawing.Point(633, 47);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(201, 21);
            this.cmbCor.TabIndex = 5;
            this.cmbCor.ValueMember = "id";
            this.cmbCor.SelectedIndexChanged += new System.EventHandler(this.cmbCor_SelectedIndexChanged);
            // 
            // cmbMotorista
            // 
            this.cmbMotorista.DisplayMember = "id";
            this.cmbMotorista.FormattingEnabled = true;
            this.cmbMotorista.Location = new System.Drawing.Point(633, 144);
            this.cmbMotorista.Name = "cmbMotorista";
            this.cmbMotorista.Size = new System.Drawing.Size(201, 21);
            this.cmbMotorista.TabIndex = 6;
            this.cmbMotorista.ValueMember = "id";
            this.cmbMotorista.SelectedIndexChanged += new System.EventHandler(this.cmbMotorista_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(581, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "COR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(525, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "MOTORISTA:";
            // 
            // txtIdMotorista
            // 
            this.txtIdMotorista.Location = new System.Drawing.Point(840, 144);
            this.txtIdMotorista.Name = "txtIdMotorista";
            this.txtIdMotorista.Size = new System.Drawing.Size(40, 20);
            this.txtIdMotorista.TabIndex = 41;
            this.txtIdMotorista.Visible = false;
            this.txtIdMotorista.TextChanged += new System.EventHandler(this.txtIdMotorista_TextChanged);
            // 
            // txtIdCor
            // 
            this.txtIdCor.Location = new System.Drawing.Point(840, 46);
            this.txtIdCor.Name = "txtIdCor";
            this.txtIdCor.Size = new System.Drawing.Size(40, 20);
            this.txtIdCor.TabIndex = 42;
            this.txtIdCor.Visible = false;
            this.txtIdCor.TextChanged += new System.EventHandler(this.txtIdCor_TextChanged);
            // 
            // FormCaminhoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.txtIdCor);
            this.Controls.Add(this.txtIdMotorista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMotorista);
            this.Controls.Add(this.cmbCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGCaminhoes);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "FormCaminhoes";
            this.Text = "Caminhoes";
            this.Load += new System.EventHandler(this.FormCaminhoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCaminhoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGCaminhoes;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.ComboBox cmbMotorista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdMotorista;
        private System.Windows.Forms.TextBox txtIdCor;
    }
}
namespace TRANSPORTADORA
{
    partial class FormMotoristas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtValidadeCnh = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DGMotorista = new System.Windows.Forms.DataGridView();
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.LBFiltro = new System.Windows.Forms.Label();
            this.RBId = new System.Windows.Forms.RadioButton();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.RBNome = new System.Windows.Forms.RadioButton();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGMotorista)).BeginInit();
            this.GbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "TELEFONE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "VALIDADE DA CNH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(187, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "SALARIO:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(269, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtValidadeCnh
            // 
            this.txtValidadeCnh.Location = new System.Drawing.Point(269, 124);
            this.txtValidadeCnh.Name = "txtValidadeCnh";
            this.txtValidadeCnh.Size = new System.Drawing.Size(100, 20);
            this.txtValidadeCnh.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(269, 158);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(269, 90);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(269, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 20);
            this.txtNome.TabIndex = 2;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.Location = new System.Drawing.Point(19, 12);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(88, 38);
            this.BtnInserir.TabIndex = 6;
            this.BtnInserir.Text = "INSERIR";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(19, 78);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 38);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(19, 144);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(88, 38);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DGMotorista
            // 
            this.DGMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMotorista.Location = new System.Drawing.Point(12, 257);
            this.DGMotorista.Name = "DGMotorista";
            this.DGMotorista.Size = new System.Drawing.Size(868, 255);
            this.DGMotorista.TabIndex = 9;
            this.DGMotorista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGMotorista_CellContentClick_1);
            this.DGMotorista.DoubleClick += new System.EventHandler(this.DGMotorista_DoubleClick);
            // 
            // GbBuscar
            // 
            this.GbBuscar.Controls.Add(this.LBFiltro);
            this.GbBuscar.Controls.Add(this.RBId);
            this.GbBuscar.Controls.Add(this.BtnFiltrar);
            this.GbBuscar.Controls.Add(this.RBNome);
            this.GbBuscar.Controls.Add(this.TxtFiltro);
            this.GbBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBuscar.ForeColor = System.Drawing.Color.White;
            this.GbBuscar.Location = new System.Drawing.Point(381, 126);
            this.GbBuscar.Name = "GbBuscar";
            this.GbBuscar.Size = new System.Drawing.Size(499, 125);
            this.GbBuscar.TabIndex = 27;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "FILTRO:";
            this.GbBuscar.Visible = false;
            // 
            // LBFiltro
            // 
            this.LBFiltro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiltro.Location = new System.Drawing.Point(27, 49);
            this.LBFiltro.Name = "LBFiltro";
            this.LBFiltro.Size = new System.Drawing.Size(361, 16);
            this.LBFiltro.TabIndex = 31;
            // 
            // RBId
            // 
            this.RBId.AutoSize = true;
            this.RBId.Location = new System.Drawing.Point(30, 19);
            this.RBId.Name = "RBId";
            this.RBId.Size = new System.Drawing.Size(35, 18);
            this.RBId.TabIndex = 30;
            this.RBId.Text = "ID";
            this.RBId.UseVisualStyleBackColor = true;
            this.RBId.CheckedChanged += new System.EventHandler(this.RBId_CheckedChanged);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.Location = new System.Drawing.Point(404, 50);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(88, 38);
            this.BtnFiltrar.TabIndex = 27;
            this.BtnFiltrar.Text = "FILTRAR";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // RBNome
            // 
            this.RBNome.AutoSize = true;
            this.RBNome.Location = new System.Drawing.Point(71, 19);
            this.RBNome.Name = "RBNome";
            this.RBNome.Size = new System.Drawing.Size(56, 18);
            this.RBNome.TabIndex = 29;
            this.RBNome.Text = "NOME";
            this.RBNome.UseVisualStyleBackColor = true;
            this.RBNome.CheckedChanged += new System.EventHandler(this.RBNome_CheckedChanged);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(27, 68);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(361, 20);
            this.TxtFiltro.TabIndex = 27;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(19, 203);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(88, 38);
            this.BtnBuscar.TabIndex = 32;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FormMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(892, 524);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GbBuscar);
            this.Controls.Add(this.DGMotorista);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtValidadeCnh);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMotoristas";
            this.Text = "Motoristas";
            this.Load += new System.EventHandler(this.FormMotoristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMotorista)).EndInit();
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtValidadeCnh;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DGMotorista;
        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.Label LBFiltro;
        private System.Windows.Forms.RadioButton RBId;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.RadioButton RBNome;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
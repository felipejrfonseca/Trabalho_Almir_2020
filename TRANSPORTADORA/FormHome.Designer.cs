namespace TRANSPORTADORA
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnCombustivel = new FontAwesome.Sharp.IconButton();
            this.BtnFrete = new FontAwesome.Sharp.IconButton();
            this.BtnCaminhoes = new FontAwesome.Sharp.IconButton();
            this.BtnTransportadora = new FontAwesome.Sharp.IconButton();
            this.BtnMotoristas = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMaximinizar = new FontAwesome.Sharp.IconPictureBox();
            this.BtnFechar = new FontAwesome.Sharp.IconPictureBox();
            this.TituloFomInicio = new System.Windows.Forms.Label();
            this.IconeFormInicio = new FontAwesome.Sharp.IconPictureBox();
            this.PanelSobraBarraTitulo = new System.Windows.Forms.Panel();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.BtnRelatorio = new FontAwesome.Sharp.IconButton();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconeFormInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.BtnRelatorio);
            this.PanelMenu.Controls.Add(this.BtnCombustivel);
            this.PanelMenu.Controls.Add(this.BtnFrete);
            this.PanelMenu.Controls.Add(this.BtnCaminhoes);
            this.PanelMenu.Controls.Add(this.BtnTransportadora);
            this.PanelMenu.Controls.Add(this.BtnMotoristas);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 647);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnCombustivel
            // 
            this.BtnCombustivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCombustivel.FlatAppearance.BorderSize = 0;
            this.BtnCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCombustivel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCombustivel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCombustivel.ForeColor = System.Drawing.Color.White;
            this.BtnCombustivel.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnCombustivel.IconColor = System.Drawing.Color.White;
            this.BtnCombustivel.IconSize = 35;
            this.BtnCombustivel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCombustivel.Location = new System.Drawing.Point(0, 328);
            this.BtnCombustivel.Name = "BtnCombustivel";
            this.BtnCombustivel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCombustivel.Rotation = 0D;
            this.BtnCombustivel.Size = new System.Drawing.Size(220, 45);
            this.BtnCombustivel.TabIndex = 12;
            this.BtnCombustivel.Text = "Combustível";
            this.BtnCombustivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCombustivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCombustivel.UseVisualStyleBackColor = true;
            this.BtnCombustivel.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // BtnFrete
            // 
            this.BtnFrete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFrete.FlatAppearance.BorderSize = 0;
            this.BtnFrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFrete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnFrete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFrete.ForeColor = System.Drawing.Color.White;
            this.BtnFrete.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.BtnFrete.IconColor = System.Drawing.Color.White;
            this.BtnFrete.IconSize = 35;
            this.BtnFrete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFrete.Location = new System.Drawing.Point(0, 283);
            this.BtnFrete.Name = "BtnFrete";
            this.BtnFrete.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnFrete.Rotation = 0D;
            this.BtnFrete.Size = new System.Drawing.Size(220, 45);
            this.BtnFrete.TabIndex = 11;
            this.BtnFrete.Text = "Fretes";
            this.BtnFrete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFrete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFrete.UseVisualStyleBackColor = true;
            this.BtnFrete.Click += new System.EventHandler(this.BtnFrete_Click);
            // 
            // BtnCaminhoes
            // 
            this.BtnCaminhoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCaminhoes.FlatAppearance.BorderSize = 0;
            this.BtnCaminhoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaminhoes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCaminhoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaminhoes.ForeColor = System.Drawing.Color.White;
            this.BtnCaminhoes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnCaminhoes.IconColor = System.Drawing.Color.White;
            this.BtnCaminhoes.IconSize = 35;
            this.BtnCaminhoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCaminhoes.Location = new System.Drawing.Point(0, 238);
            this.BtnCaminhoes.Name = "BtnCaminhoes";
            this.BtnCaminhoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCaminhoes.Rotation = 0D;
            this.BtnCaminhoes.Size = new System.Drawing.Size(220, 45);
            this.BtnCaminhoes.TabIndex = 10;
            this.BtnCaminhoes.Text = "Caminhões";
            this.BtnCaminhoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCaminhoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCaminhoes.UseVisualStyleBackColor = true;
            this.BtnCaminhoes.Click += new System.EventHandler(this.BtnCaminhoes_Click);
            // 
            // BtnTransportadora
            // 
            this.BtnTransportadora.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransportadora.FlatAppearance.BorderSize = 0;
            this.BtnTransportadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransportadora.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTransportadora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransportadora.ForeColor = System.Drawing.Color.White;
            this.BtnTransportadora.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.BtnTransportadora.IconColor = System.Drawing.Color.White;
            this.BtnTransportadora.IconSize = 35;
            this.BtnTransportadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransportadora.Location = new System.Drawing.Point(0, 193);
            this.BtnTransportadora.Name = "BtnTransportadora";
            this.BtnTransportadora.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnTransportadora.Rotation = 0D;
            this.BtnTransportadora.Size = new System.Drawing.Size(220, 45);
            this.BtnTransportadora.TabIndex = 2;
            this.BtnTransportadora.Text = "Transportadora";
            this.BtnTransportadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransportadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTransportadora.UseVisualStyleBackColor = true;
            this.BtnTransportadora.Click += new System.EventHandler(this.BtnTransportadora_Click);
            // 
            // BtnMotoristas
            // 
            this.BtnMotoristas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMotoristas.FlatAppearance.BorderSize = 0;
            this.BtnMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMotoristas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMotoristas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMotoristas.ForeColor = System.Drawing.Color.White;
            this.BtnMotoristas.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.BtnMotoristas.IconColor = System.Drawing.Color.White;
            this.BtnMotoristas.IconSize = 35;
            this.BtnMotoristas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMotoristas.Location = new System.Drawing.Point(0, 148);
            this.BtnMotoristas.Name = "BtnMotoristas";
            this.BtnMotoristas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnMotoristas.Rotation = 0D;
            this.BtnMotoristas.Size = new System.Drawing.Size(220, 45);
            this.BtnMotoristas.TabIndex = 1;
            this.BtnMotoristas.Text = "Motoristas";
            this.BtnMotoristas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMotoristas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMotoristas.UseVisualStyleBackColor = true;
            this.BtnMotoristas.Click += new System.EventHandler(this.BtnTransporte_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.BtnHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PanelLogo.Size = new System.Drawing.Size(220, 148);
            this.PanelLogo.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(217, 148);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.BtnMaximinizar);
            this.PanelBarraTitulo.Controls.Add(this.BtnFechar);
            this.PanelBarraTitulo.Controls.Add(this.TituloFomInicio);
            this.PanelBarraTitulo.Controls.Add(this.IconeFormInicio);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(908, 75);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarraTitulo_Paint);
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.BtnMinimizar.IconSize = 25;
            this.BtnMinimizar.Location = new System.Drawing.Point(818, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximinizar
            // 
            this.BtnMaximinizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximinizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnMaximinizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximinizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMaximinizar.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.BtnMaximinizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.BtnMaximinizar.IconSize = 25;
            this.BtnMaximinizar.Location = new System.Drawing.Point(849, 3);
            this.BtnMaximinizar.Name = "BtnMaximinizar";
            this.BtnMaximinizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximinizar.TabIndex = 3;
            this.BtnMaximinizar.TabStop = false;
            this.BtnMaximinizar.Click += new System.EventHandler(this.BtnMaximinizar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnFechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnFechar.IconColor = System.Drawing.SystemColors.ControlText;
            this.BtnFechar.IconSize = 25;
            this.BtnFechar.Location = new System.Drawing.Point(880, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(25, 25);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.TabStop = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // TituloFomInicio
            // 
            this.TituloFomInicio.AutoSize = true;
            this.TituloFomInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFomInicio.ForeColor = System.Drawing.Color.White;
            this.TituloFomInicio.Location = new System.Drawing.Point(58, 35);
            this.TituloFomInicio.Name = "TituloFomInicio";
            this.TituloFomInicio.Size = new System.Drawing.Size(38, 14);
            this.TituloFomInicio.TabIndex = 1;
            this.TituloFomInicio.Text = "HOME";
            // 
            // IconeFormInicio
            // 
            this.IconeFormInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconeFormInicio.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconeFormInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconeFormInicio.IconColor = System.Drawing.Color.MediumPurple;
            this.IconeFormInicio.Location = new System.Drawing.Point(20, 26);
            this.IconeFormInicio.Name = "IconeFormInicio";
            this.IconeFormInicio.Size = new System.Drawing.Size(32, 32);
            this.IconeFormInicio.TabIndex = 0;
            this.IconeFormInicio.TabStop = false;
            this.IconeFormInicio.Click += new System.EventHandler(this.IconeFormInicio_Click);
            // 
            // PanelSobraBarraTitulo
            // 
            this.PanelSobraBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.PanelSobraBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSobraBarraTitulo.Location = new System.Drawing.Point(220, 75);
            this.PanelSobraBarraTitulo.Name = "PanelSobraBarraTitulo";
            this.PanelSobraBarraTitulo.Size = new System.Drawing.Size(908, 9);
            this.PanelSobraBarraTitulo.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(220, 84);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(908, 563);
            this.PanelDesktop.TabIndex = 3;
            this.PanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRelatorio.FlatAppearance.BorderSize = 0;
            this.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRelatorio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorio.ForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnRelatorio.IconColor = System.Drawing.Color.White;
            this.BtnRelatorio.IconSize = 35;
            this.BtnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorio.Location = new System.Drawing.Point(0, 373);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnRelatorio.Rotation = 0D;
            this.BtnRelatorio.Size = new System.Drawing.Size(220, 45);
            this.BtnRelatorio.TabIndex = 13;
            this.BtnRelatorio.Text = "Relatórios";
            this.BtnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click_1);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 647);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelSobraBarraTitulo);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormHome";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconeFormInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton BtnMotoristas;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton BtnCaminhoes;
        private FontAwesome.Sharp.IconButton BtnTransportadora;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.Label TituloFomInicio;
        private FontAwesome.Sharp.IconPictureBox IconeFormInicio;
        private System.Windows.Forms.Panel PanelSobraBarraTitulo;
        private System.Windows.Forms.Panel PanelDesktop;
        private FontAwesome.Sharp.IconPictureBox BtnFechar;
        private FontAwesome.Sharp.IconPictureBox BtnMaximinizar;
        private FontAwesome.Sharp.IconPictureBox BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnFrete;
        private FontAwesome.Sharp.IconButton BtnCombustivel;
        private FontAwesome.Sharp.IconButton BtnRelatorio;
    }
}
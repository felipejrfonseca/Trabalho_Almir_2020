namespace TRANSPORTADORA.CAMADAS
{
    partial class FormRelatorio
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
            this.DGCor = new System.Windows.Forms.DataGridView();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.BtnCor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGCor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCor
            // 
            this.DGCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCor.Location = new System.Drawing.Point(12, 277);
            this.DGCor.Name = "DGCor";
            this.DGCor.Size = new System.Drawing.Size(776, 150);
            this.DGCor.TabIndex = 0;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(255, 133);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(180, 20);
            this.txtCor.TabIndex = 1;
            // 
            // BtnCor
            // 
            this.BtnCor.Location = new System.Drawing.Point(325, 223);
            this.BtnCor.Name = "BtnCor";
            this.BtnCor.Size = new System.Drawing.Size(75, 23);
            this.BtnCor.TabIndex = 2;
            this.BtnCor.Text = "button1";
            this.BtnCor.UseVisualStyleBackColor = true;
            this.BtnCor.Click += new System.EventHandler(this.BtnCor_Click);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.DGCor);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Button BtnCor;
    }
}
namespace pryEDSilvaJ
{
    partial class frmGrafo
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
            this.grbCargaDatos = new System.Windows.Forms.GroupBox();
            this.grbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbListarViajes = new System.Windows.Forms.GroupBox();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCargaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCargaDatos
            // 
            this.grbCargaDatos.Controls.Add(this.label2);
            this.grbCargaDatos.Controls.Add(this.label1);
            this.grbCargaDatos.Location = new System.Drawing.Point(247, 12);
            this.grbCargaDatos.Name = "grbCargaDatos";
            this.grbCargaDatos.Size = new System.Drawing.Size(264, 169);
            this.grbCargaDatos.TabIndex = 0;
            this.grbCargaDatos.TabStop = false;
            this.grbCargaDatos.Text = "Carga de Datos";
            // 
            // grbConsultaDatos
            // 
            this.grbConsultaDatos.Location = new System.Drawing.Point(526, 12);
            this.grbConsultaDatos.Name = "grbConsultaDatos";
            this.grbConsultaDatos.Size = new System.Drawing.Size(242, 169);
            this.grbConsultaDatos.TabIndex = 1;
            this.grbConsultaDatos.TabStop = false;
            this.grbConsultaDatos.Text = "Consulta de Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 169);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grbListarViajes
            // 
            this.grbListarViajes.Controls.Add(this.dgvViajes);
            this.grbListarViajes.Location = new System.Drawing.Point(12, 200);
            this.grbListarViajes.Name = "grbListarViajes";
            this.grbListarViajes.Size = new System.Drawing.Size(756, 360);
            this.grbListarViajes.TabIndex = 3;
            this.grbListarViajes.TabStop = false;
            this.grbListarViajes.Text = "Listar Viajes";
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(14, 73);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(729, 273);
            this.dgvViajes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 585);
            this.Controls.Add(this.grbListarViajes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbConsultaDatos);
            this.Controls.Add(this.grbCargaDatos);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            this.grbCargaDatos.ResumeLayout(false);
            this.grbCargaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbListarViajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCargaDatos;
        private System.Windows.Forms.GroupBox grbConsultaDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbListarViajes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvViajes;
    }
}
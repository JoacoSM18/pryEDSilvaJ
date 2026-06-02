namespace pryEDSilvaJ
{
    partial class frmConsultaSQL
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
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvConsultaSQL = new System.Windows.Forms.DataGridView();
            this.txtConsultaSQL = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(491, 172);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 30);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvConsultaSQL
            // 
            this.dgvConsultaSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSQL.Location = new System.Drawing.Point(12, 208);
            this.dgvConsultaSQL.Name = "dgvConsultaSQL";
            this.dgvConsultaSQL.Size = new System.Drawing.Size(572, 295);
            this.dgvConsultaSQL.TabIndex = 1;
            // 
            // txtConsultaSQL
            // 
            this.txtConsultaSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaSQL.Location = new System.Drawing.Point(12, 22);
            this.txtConsultaSQL.Name = "txtConsultaSQL";
            this.txtConsultaSQL.Size = new System.Drawing.Size(572, 144);
            this.txtConsultaSQL.TabIndex = 2;
            this.txtConsultaSQL.Text = "";
            // 
            // frmConsultaSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 515);
            this.Controls.Add(this.txtConsultaSQL);
            this.Controls.Add(this.dgvConsultaSQL);
            this.Controls.Add(this.btnListar);
            this.Name = "frmConsultaSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas en la Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvConsultaSQL;
        private System.Windows.Forms.RichTextBox txtConsultaSQL;
    }
}
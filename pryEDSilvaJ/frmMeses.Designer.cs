namespace pryEDSilvaJ
{
    partial class frmMeses
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.btnGrabarMeses = new System.Windows.Forms.Button();
            this.btnListarMeses = new System.Windows.Forms.Button();
            this.txtNombreMeses = new System.Windows.Forms.TextBox();
            this.lblNombreMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(78, 131);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(288, 147);
            this.lstMeses.TabIndex = 9;
            // 
            // btnGrabarMeses
            // 
            this.btnGrabarMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarMeses.Location = new System.Drawing.Point(233, 84);
            this.btnGrabarMeses.Name = "btnGrabarMeses";
            this.btnGrabarMeses.Size = new System.Drawing.Size(133, 27);
            this.btnGrabarMeses.TabIndex = 8;
            this.btnGrabarMeses.Text = "Grabar";
            this.btnGrabarMeses.UseVisualStyleBackColor = true;
            this.btnGrabarMeses.Click += new System.EventHandler(this.btnGrabarMeses_Click);
            // 
            // btnListarMeses
            // 
            this.btnListarMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMeses.Location = new System.Drawing.Point(78, 84);
            this.btnListarMeses.Name = "btnListarMeses";
            this.btnListarMeses.Size = new System.Drawing.Size(136, 27);
            this.btnListarMeses.TabIndex = 7;
            this.btnListarMeses.Text = "Listar";
            this.btnListarMeses.UseVisualStyleBackColor = true;
            // 
            // txtNombreMeses
            // 
            this.txtNombreMeses.Location = new System.Drawing.Point(162, 29);
            this.txtNombreMeses.Name = "txtNombreMeses";
            this.txtNombreMeses.Size = new System.Drawing.Size(204, 20);
            this.txtNombreMeses.TabIndex = 6;
            // 
            // lblNombreMeses
            // 
            this.lblNombreMeses.AutoSize = true;
            this.lblNombreMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMeses.Location = new System.Drawing.Point(75, 32);
            this.lblNombreMeses.Name = "lblNombreMeses";
            this.lblNombreMeses.Size = new System.Drawing.Size(62, 17);
            this.lblNombreMeses.TabIndex = 5;
            this.lblNombreMeses.Text = "Nombre:";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(441, 305);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.btnGrabarMeses);
            this.Controls.Add(this.btnListarMeses);
            this.Controls.Add(this.txtNombreMeses);
            this.Controls.Add(this.lblNombreMeses);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Button btnGrabarMeses;
        private System.Windows.Forms.Button btnListarMeses;
        private System.Windows.Forms.TextBox txtNombreMeses;
        private System.Windows.Forms.Label lblNombreMeses;
    }
}
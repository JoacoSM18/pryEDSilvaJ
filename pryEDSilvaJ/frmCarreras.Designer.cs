namespace pryEDSilvaJ
{
    partial class frmCarreras
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
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.btnGrabarCarrera = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.Location = new System.Drawing.Point(78, 130);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(288, 147);
            this.lstCarreras.TabIndex = 14;
            // 
            // btnGrabarCarrera
            // 
            this.btnGrabarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarCarrera.Location = new System.Drawing.Point(233, 83);
            this.btnGrabarCarrera.Name = "btnGrabarCarrera";
            this.btnGrabarCarrera.Size = new System.Drawing.Size(133, 27);
            this.btnGrabarCarrera.TabIndex = 13;
            this.btnGrabarCarrera.Text = "Grabar";
            this.btnGrabarCarrera.UseVisualStyleBackColor = true;
            this.btnGrabarCarrera.Click += new System.EventHandler(this.btnGrabarCarrera_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(162, 28);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(204, 20);
            this.txtCarrera.TabIndex = 11;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(75, 31);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(60, 17);
            this.lblCarrera.TabIndex = 10;
            this.lblCarrera.Text = "Carrera:";
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(441, 308);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.btnGrabarCarrera);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Button btnGrabarCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblCarrera;
    }
}
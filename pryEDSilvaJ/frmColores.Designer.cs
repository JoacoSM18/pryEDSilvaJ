namespace pryEDSilvaJ
{
    partial class frmColores
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
            this.lblNombreColor = new System.Windows.Forms.Label();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.btnListarColor = new System.Windows.Forms.Button();
            this.btnGrabarColor = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombreColor
            // 
            this.lblNombreColor.AutoSize = true;
            this.lblNombreColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColor.Location = new System.Drawing.Point(69, 35);
            this.lblNombreColor.Name = "lblNombreColor";
            this.lblNombreColor.Size = new System.Drawing.Size(62, 17);
            this.lblNombreColor.TabIndex = 0;
            this.lblNombreColor.Text = "Nombre:";
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(156, 32);
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(204, 20);
            this.txtNombreColor.TabIndex = 1;
            // 
            // btnListarColor
            // 
            this.btnListarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarColor.Location = new System.Drawing.Point(72, 88);
            this.btnListarColor.Name = "btnListarColor";
            this.btnListarColor.Size = new System.Drawing.Size(136, 27);
            this.btnListarColor.TabIndex = 2;
            this.btnListarColor.Text = "Listar";
            this.btnListarColor.UseVisualStyleBackColor = true;
            this.btnListarColor.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnGrabarColor
            // 
            this.btnGrabarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarColor.Location = new System.Drawing.Point(227, 88);
            this.btnGrabarColor.Name = "btnGrabarColor";
            this.btnGrabarColor.Size = new System.Drawing.Size(133, 27);
            this.btnGrabarColor.TabIndex = 3;
            this.btnGrabarColor.Text = "Grabar";
            this.btnGrabarColor.UseVisualStyleBackColor = true;
            this.btnGrabarColor.Click += new System.EventHandler(this.btnGrabarColor_Click);
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(72, 134);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(288, 147);
            this.lstColores.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(441, 305);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.btnGrabarColor);
            this.Controls.Add(this.btnListarColor);
            this.Controls.Add(this.txtNombreColor);
            this.Controls.Add(this.lblNombreColor);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreColor;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Button btnListarColor;
        private System.Windows.Forms.Button btnGrabarColor;
        private System.Windows.Forms.ListBox lstColores;
    }
}
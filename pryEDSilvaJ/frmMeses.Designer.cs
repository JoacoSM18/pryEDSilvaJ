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
            this.lstMeses.ItemHeight = 20;
            this.lstMeses.Location = new System.Drawing.Point(117, 201);
            this.lstMeses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(430, 224);
            this.lstMeses.TabIndex = 9;
            // 
            // btnGrabarMeses
            // 
            this.btnGrabarMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarMeses.Location = new System.Drawing.Point(349, 130);
            this.btnGrabarMeses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrabarMeses.Name = "btnGrabarMeses";
            this.btnGrabarMeses.Size = new System.Drawing.Size(200, 42);
            this.btnGrabarMeses.TabIndex = 8;
            this.btnGrabarMeses.Text = "Grabar";
            this.btnGrabarMeses.UseVisualStyleBackColor = true;
            // 
            // btnListarMeses
            // 
            this.btnListarMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMeses.Location = new System.Drawing.Point(117, 130);
            this.btnListarMeses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarMeses.Name = "btnListarMeses";
            this.btnListarMeses.Size = new System.Drawing.Size(204, 42);
            this.btnListarMeses.TabIndex = 7;
            this.btnListarMeses.Text = "Listar";
            this.btnListarMeses.UseVisualStyleBackColor = true;
            // 
            // txtNombreMeses
            // 
            this.txtNombreMeses.Location = new System.Drawing.Point(243, 44);
            this.txtNombreMeses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreMeses.Name = "txtNombreMeses";
            this.txtNombreMeses.Size = new System.Drawing.Size(304, 26);
            this.txtNombreMeses.TabIndex = 6;
            // 
            // lblNombreMeses
            // 
            this.lblNombreMeses.AutoSize = true;
            this.lblNombreMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMeses.Location = new System.Drawing.Point(113, 49);
            this.lblNombreMeses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMeses.Name = "lblNombreMeses";
            this.lblNombreMeses.Size = new System.Drawing.Size(87, 25);
            this.lblNombreMeses.TabIndex = 5;
            this.lblNombreMeses.Text = "Nombre:";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 469);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.btnGrabarMeses);
            this.Controls.Add(this.btnListarMeses);
            this.Controls.Add(this.txtNombreMeses);
            this.Controls.Add(this.lblNombreMeses);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
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
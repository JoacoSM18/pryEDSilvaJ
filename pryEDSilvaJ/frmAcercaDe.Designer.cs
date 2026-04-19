namespace pryEDSilvaJ
{
    partial class frmAcercaDe
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreDesarrollador = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDNIDesarrollador = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(112, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(245, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Desarrollador:";
            // 
            // lblNombreDesarrollador
            // 
            this.lblNombreDesarrollador.AutoSize = true;
            this.lblNombreDesarrollador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDesarrollador.Location = new System.Drawing.Point(378, 78);
            this.lblNombreDesarrollador.Name = "lblNombreDesarrollador";
            this.lblNombreDesarrollador.Size = new System.Drawing.Size(249, 26);
            this.lblNombreDesarrollador.TabIndex = 1;
            this.lblNombreDesarrollador.Text = "Joaquín Silva Menendez";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(148, 132);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(209, 22);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI del Desarrollador:";
            // 
            // lblDNIDesarrollador
            // 
            this.lblDNIDesarrollador.AutoSize = true;
            this.lblDNIDesarrollador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIDesarrollador.Location = new System.Drawing.Point(378, 128);
            this.lblDNIDesarrollador.Name = "lblDNIDesarrollador";
            this.lblDNIDesarrollador.Size = new System.Drawing.Size(108, 26);
            this.lblDNIDesarrollador.TabIndex = 3;
            this.lblDNIDesarrollador.Text = "46771710";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(275, 181);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(82, 22);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia:";
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(378, 178);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(204, 26);
            this.lblNombreMateria.TabIndex = 5;
            this.lblNombreMateria.Text = "Estructura de Datos";
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Palatino Linotype", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(191, 283);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(493, 85);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Este programa fue creado para la materia \"Estructura de Datos\" a pedido de la pro" +
    "fesora Erica Bongiovanni en la cátedra B";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDSilvaJ.Properties.Resources.pngtree_business_man_avatar_png_image_6514640;
            this.pictureBox1.Location = new System.Drawing.Point(12, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(721, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblNombreMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDNIDesarrollador);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombreDesarrollador);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca del Desarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreDesarrollador;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDNIDesarrollador;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
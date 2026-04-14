namespace pryEDSilvaJ
{
    partial class frmCola
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
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.grbEliminarElemento = new System.Windows.Forms.GroupBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblCodigo3D = new System.Windows.Forms.Label();
            this.lblNombre3D = new System.Windows.Forms.Label();
            this.lblTramite3D = new System.Windows.Forms.Label();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.grp1.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            this.grbEliminarElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(299, 17);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(397, 214);
            this.dgvCola.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(91, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(102, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(91, 136);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(102, 23);
            this.txtTramite.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(6, 143);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 6;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 31);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(6, 181);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(166, 31);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(6, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(287, 212);
            this.lstCola.TabIndex = 9;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.dgvCola);
            this.grp1.Controls.Add(this.lstCola);
            this.grp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp1.Location = new System.Drawing.Point(12, 248);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(696, 245);
            this.grp1.TabIndex = 10;
            this.grp1.TabStop = false;
            this.grp1.Text = "Listado en una Lista y en una Grilla";
            // 
            // grpNuevoElemento
            // 
            this.grpNuevoElemento.Controls.Add(this.btnAgregar);
            this.grpNuevoElemento.Controls.Add(this.lblCodigo);
            this.grpNuevoElemento.Controls.Add(this.lblNombre);
            this.grpNuevoElemento.Controls.Add(this.txtCodigo);
            this.grpNuevoElemento.Controls.Add(this.txtNombre);
            this.grpNuevoElemento.Controls.Add(this.txtTramite);
            this.grpNuevoElemento.Controls.Add(this.lblTramite);
            this.grpNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoElemento.Location = new System.Drawing.Point(311, 12);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Size = new System.Drawing.Size(199, 218);
            this.grpNuevoElemento.TabIndex = 10;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // grbEliminarElemento
            // 
            this.grbEliminarElemento.Controls.Add(this.lblTramite3D);
            this.grbEliminarElemento.Controls.Add(this.lblNombre3D);
            this.grbEliminarElemento.Controls.Add(this.lblCodigo3D);
            this.grbEliminarElemento.Controls.Add(this.lblTramite2);
            this.grbEliminarElemento.Controls.Add(this.lblNombre2);
            this.grbEliminarElemento.Controls.Add(this.lblCodigo2);
            this.grbEliminarElemento.Controls.Add(this.btnBorrar);
            this.grbEliminarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEliminarElemento.Location = new System.Drawing.Point(530, 12);
            this.grbEliminarElemento.Name = "grbEliminarElemento";
            this.grbEliminarElemento.Size = new System.Drawing.Size(178, 218);
            this.grbEliminarElemento.TabIndex = 12;
            this.grbEliminarElemento.TabStop = false;
            this.grbEliminarElemento.Text = "Eliminar Elemento";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(6, 30);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo2.TabIndex = 13;
            this.lblCodigo2.Text = "Codigo: ";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(6, 87);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(62, 16);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.Text = "Nombre: ";
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(6, 147);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(56, 16);
            this.lblTramite2.TabIndex = 13;
            this.lblTramite2.Text = "Trámite:";
            // 
            // lblCodigo3D
            // 
            this.lblCodigo3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo3D.Location = new System.Drawing.Point(113, 23);
            this.lblCodigo3D.Name = "lblCodigo3D";
            this.lblCodigo3D.Size = new System.Drawing.Size(59, 23);
            this.lblCodigo3D.TabIndex = 13;
            this.lblCodigo3D.Text = " ";
            this.lblCodigo3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre3D
            // 
            this.lblNombre3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre3D.Location = new System.Drawing.Point(82, 84);
            this.lblNombre3D.Name = "lblNombre3D";
            this.lblNombre3D.Size = new System.Drawing.Size(90, 23);
            this.lblNombre3D.TabIndex = 14;
            this.lblNombre3D.Text = " ";
            this.lblNombre3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTramite3D
            // 
            this.lblTramite3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite3D.Location = new System.Drawing.Point(82, 140);
            this.lblTramite3D.Name = "lblTramite3D";
            this.lblTramite3D.Size = new System.Drawing.Size(90, 23);
            this.lblTramite3D.TabIndex = 15;
            this.lblTramite3D.Text = " ";
            this.lblTramite3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcb1
            // 
            this.pcb1.Image = global::pryEDSilvaJ.Properties.Resources.b10;
            this.pcb1.Location = new System.Drawing.Point(18, 12);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(259, 218);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb1.TabIndex = 13;
            this.pcb1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(720, 499);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.grbEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Controls.Add(this.grp1);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            this.grbEliminarElemento.ResumeLayout(false);
            this.grbEliminarElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.Windows.Forms.GroupBox grbEliminarElemento;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblTramite3D;
        private System.Windows.Forms.Label lblNombre3D;
        private System.Windows.Forms.Label lblCodigo3D;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.PictureBox pcb1;
    }
}
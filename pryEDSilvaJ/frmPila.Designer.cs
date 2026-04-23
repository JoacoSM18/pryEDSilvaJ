namespace pryEDSilvaJ
{
    partial class frmPila
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
            this.grpEliminarElemento = new System.Windows.Forms.GroupBox();
            this.lblTramite3D = new System.Windows.Forms.Label();
            this.lblNombre3D = new System.Windows.Forms.Label();
            this.lblCodigo3D = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.grpEliminarElemento.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarElemento
            // 
            this.grpEliminarElemento.Controls.Add(this.lblTramite3D);
            this.grpEliminarElemento.Controls.Add(this.lblNombre3D);
            this.grpEliminarElemento.Controls.Add(this.lblCodigo3D);
            this.grpEliminarElemento.Controls.Add(this.lblTramite2);
            this.grpEliminarElemento.Controls.Add(this.lblNombre2);
            this.grpEliminarElemento.Controls.Add(this.lblCodigo2);
            this.grpEliminarElemento.Controls.Add(this.btnBorrar);
            this.grpEliminarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarElemento.Location = new System.Drawing.Point(499, 12);
            this.grpEliminarElemento.Name = "grpEliminarElemento";
            this.grpEliminarElemento.Size = new System.Drawing.Size(178, 218);
            this.grpEliminarElemento.TabIndex = 16;
            this.grpEliminarElemento.TabStop = false;
            this.grpEliminarElemento.Text = "Eliminar Elemento";
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
            this.grpNuevoElemento.Location = new System.Drawing.Point(284, 12);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Size = new System.Drawing.Size(199, 218);
            this.grpNuevoElemento.TabIndex = 14;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
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
            // lstPila
            // 
            this.lstPila.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 16;
            this.lstPila.Location = new System.Drawing.Point(7, 19);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(266, 196);
            this.lstPila.TabIndex = 9;
            // 
            // dgvPila
            // 
            this.dgvPila.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvPila.Location = new System.Drawing.Point(277, 15);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 4;
            this.dgvPila.Size = new System.Drawing.Size(387, 203);
            this.dgvPila.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 8;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 150;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 8;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 150;
            // 
            // colTramite
            // 
            this.colTramite.HeaderText = "Trámite";
            this.colTramite.MinimumWidth = 8;
            this.colTramite.Name = "colTramite";
            this.colTramite.Width = 150;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.dgvPila);
            this.grp2.Controls.Add(this.lstPila);
            this.grp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp2.Location = new System.Drawing.Point(12, 250);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(671, 231);
            this.grp2.TabIndex = 18;
            this.grp2.TabStop = false;
            this.grp2.Text = "Listado en una List Box y una Grilla";
            // 
            // pcb2
            // 
            this.pcb2.Image = global::pryEDSilvaJ.Properties.Resources.images1;
            this.pcb2.Location = new System.Drawing.Point(12, 12);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(259, 218);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb2.TabIndex = 17;
            this.pcb2.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(701, 490);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.grpEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Pila";
            this.grpEliminarElemento.ResumeLayout(false);
            this.grpEliminarElemento.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.GroupBox grpEliminarElemento;
        private System.Windows.Forms.Label lblTramite3D;
        private System.Windows.Forms.Label lblNombre3D;
        private System.Windows.Forms.Label lblCodigo3D;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
        private System.Windows.Forms.GroupBox grp2;
    }
}
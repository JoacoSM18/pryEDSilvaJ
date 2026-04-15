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
            this.lblTramite3D = new System.Windows.Forms.Label();
            this.lblNombre3D = new System.Windows.Forms.Label();
            this.lblCodigo3D = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.grp1.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            this.grbEliminarElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCola
            // 
            this.dgvCola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvCola.Location = new System.Drawing.Point(448, 33);
            this.dgvCola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersWidth = 62;
            this.dgvCola.Size = new System.Drawing.Size(592, 279);
            this.dgvCola.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 30);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 123);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 30);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(136, 209);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(151, 30);
            this.txtTramite.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 46);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 24);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 134);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 24);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(9, 220);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(78, 24);
            this.lblTramite.TabIndex = 6;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(14, 278);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(276, 48);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(9, 278);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(249, 48);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lstCola
            // 
            this.lstCola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 25;
            this.lstCola.Location = new System.Drawing.Point(12, 33);
            this.lstCola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(428, 279);
            this.lstCola.TabIndex = 9;
            // 
            // grp1
            // 
            this.grp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp1.Controls.Add(this.dgvCola);
            this.grp1.Controls.Add(this.lstCola);
            this.grp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp1.Location = new System.Drawing.Point(18, 382);
            this.grp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1.Size = new System.Drawing.Size(1054, 336);
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
            this.grpNuevoElemento.Location = new System.Drawing.Point(466, 18);
            this.grpNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevoElemento.Size = new System.Drawing.Size(298, 335);
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
            this.grbEliminarElemento.Location = new System.Drawing.Point(795, 18);
            this.grbEliminarElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEliminarElemento.Name = "grbEliminarElemento";
            this.grbEliminarElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEliminarElemento.Size = new System.Drawing.Size(267, 335);
            this.grbEliminarElemento.TabIndex = 12;
            this.grbEliminarElemento.TabStop = false;
            this.grbEliminarElemento.Text = "Eliminar Elemento";
            // 
            // lblTramite3D
            // 
            this.lblTramite3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite3D.Location = new System.Drawing.Point(123, 215);
            this.lblTramite3D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite3D.Name = "lblTramite3D";
            this.lblTramite3D.Size = new System.Drawing.Size(135, 35);
            this.lblTramite3D.TabIndex = 15;
            this.lblTramite3D.Text = " ";
            this.lblTramite3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre3D
            // 
            this.lblNombre3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre3D.Location = new System.Drawing.Point(123, 129);
            this.lblNombre3D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre3D.Name = "lblNombre3D";
            this.lblNombre3D.Size = new System.Drawing.Size(135, 35);
            this.lblNombre3D.TabIndex = 14;
            this.lblNombre3D.Text = " ";
            this.lblNombre3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo3D
            // 
            this.lblCodigo3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo3D.Location = new System.Drawing.Point(170, 35);
            this.lblCodigo3D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo3D.Name = "lblCodigo3D";
            this.lblCodigo3D.Size = new System.Drawing.Size(88, 35);
            this.lblCodigo3D.TabIndex = 13;
            this.lblCodigo3D.Text = " ";
            this.lblCodigo3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(9, 226);
            this.lblTramite2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(78, 24);
            this.lblTramite2.TabIndex = 13;
            this.lblTramite2.Text = "Trámite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(9, 134);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(89, 24);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.Text = "Nombre: ";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(9, 46);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(81, 24);
            this.lblCodigo2.TabIndex = 13;
            this.lblCodigo2.Text = "Codigo: ";
            // 
            // pcb1
            // 
            this.pcb1.Image = global::pryEDSilvaJ.Properties.Resources.b10;
            this.pcb1.Location = new System.Drawing.Point(27, 18);
            this.pcb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(388, 335);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb1.TabIndex = 13;
            this.pcb1.TabStop = false;
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
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1084, 754);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.grbEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Controls.Add(this.grp1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
    }
}
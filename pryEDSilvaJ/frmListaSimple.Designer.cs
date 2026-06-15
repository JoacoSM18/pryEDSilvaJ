namespace pryEDSilvaJ
{
    partial class frmListaSimple
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
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
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
            this.lstLista = new System.Windows.Forms.ListBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.grpEliminarElemento.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarElemento
            // 
            this.grpEliminarElemento.Controls.Add(this.cmbCodigo);
            this.grpEliminarElemento.Controls.Add(this.lblCodigo2);
            this.grpEliminarElemento.Controls.Add(this.btnBorrar);
            this.grpEliminarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarElemento.Location = new System.Drawing.Point(777, 18);
            this.grpEliminarElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminarElemento.Name = "grpEliminarElemento";
            this.grpEliminarElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminarElemento.Size = new System.Drawing.Size(291, 335);
            this.grpEliminarElemento.TabIndex = 20;
            this.grpEliminarElemento.TabStop = false;
            this.grpEliminarElemento.Text = "Eliminar Elemento";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(106, 206);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(151, 33);
            this.cmbCodigo.TabIndex = 14;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(24, 215);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(81, 24);
            this.lblCodigo2.TabIndex = 13;
            this.lblCodigo2.Text = "Codigo: ";
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
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.grpNuevoElemento.Location = new System.Drawing.Point(436, 18);
            this.grpNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevoElemento.Size = new System.Drawing.Size(332, 335);
            this.grpNuevoElemento.TabIndex = 19;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.lblNombre.Location = new System.Drawing.Point(9, 128);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 24);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(178, 40);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 30);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 122);
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
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(9, 215);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(78, 24);
            this.lblTramite.TabIndex = 6;
            this.lblTramite.Text = "Trámite:";
            // 
            // lstLista
            // 
            this.lstLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 20;
            this.lstLista.Location = new System.Drawing.Point(8, 23);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(390, 304);
            this.lstLista.TabIndex = 9;
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvLista.Location = new System.Drawing.Point(418, 33);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 170;
            this.dgvLista.Size = new System.Drawing.Size(624, 294);
            this.dgvLista.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 8;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 150;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 8;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 150;
            // 
            // colTramite
            // 
            this.colTramite.HeaderText = "Trámite";
            this.colTramite.MinimumWidth = 8;
            this.colTramite.Name = "colTramite";
            this.colTramite.ReadOnly = true;
            this.colTramite.Width = 150;
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.dgvLista);
            this.grp3.Controls.Add(this.lstLista);
            this.grp3.Location = new System.Drawing.Point(18, 363);
            this.grp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp3.Name = "grp3";
            this.grp3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp3.Size = new System.Drawing.Size(1050, 335);
            this.grp3.TabIndex = 22;
            this.grp3.TabStop = false;
            this.grp3.Text = "Listado en un List Box y Grilla";
            // 
            // pcb2
            // 
            this.pcb2.Image = global::pryEDSilvaJ.Properties.Resources.lista_enlazada;
            this.pcb2.Location = new System.Drawing.Point(18, 18);
            this.pcb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(398, 335);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb2.TabIndex = 21;
            this.pcb2.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1084, 769);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.grpEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos Lineal - Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.grpEliminarElemento.ResumeLayout(false);
            this.grpEliminarElemento.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.GroupBox grpEliminarElemento;
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
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.ComboBox cmbCodigo;
    }
}
namespace pryEDSilvaJ
{
    partial class frmListaDoble
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
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
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
            this.grp4 = new System.Windows.Forms.GroupBox();
            this.btnDesc = new System.Windows.Forms.RadioButton();
            this.btnAsc = new System.Windows.Forms.RadioButton();
            this.grp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.grpEliminarElemento.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            this.grp4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.dgvListaDoble);
            this.grp3.Controls.Add(this.lstListaDoble);
            this.grp3.Location = new System.Drawing.Point(14, 371);
            this.grp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp3.Name = "grp3";
            this.grp3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp3.Size = new System.Drawing.Size(1042, 335);
            this.grp3.TabIndex = 26;
            this.grp3.TabStop = false;
            this.grp3.Text = "Listado en un List Box y Grilla";
            this.grp3.Enter += new System.EventHandler(this.grp3_Enter);
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvListaDoble.Location = new System.Drawing.Point(394, 23);
            this.dgvListaDoble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 40;
            this.dgvListaDoble.Size = new System.Drawing.Size(622, 305);
            this.dgvListaDoble.TabIndex = 0;
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
            // lstListaDoble
            // 
            this.lstListaDoble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.ItemHeight = 20;
            this.lstListaDoble.Location = new System.Drawing.Point(8, 23);
            this.lstListaDoble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(379, 304);
            this.lstListaDoble.TabIndex = 9;
            // 
            // pcb2
            // 
            this.pcb2.Image = global::pryEDSilvaJ.Properties.Resources.lista_enlazada;
            this.pcb2.Location = new System.Drawing.Point(14, 14);
            this.pcb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(388, 335);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb2.TabIndex = 25;
            this.pcb2.TabStop = false;
            // 
            // grpEliminarElemento
            // 
            this.grpEliminarElemento.Controls.Add(this.cmbCodigo);
            this.grpEliminarElemento.Controls.Add(this.lblCodigo2);
            this.grpEliminarElemento.Controls.Add(this.btnBorrar);
            this.grpEliminarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarElemento.Location = new System.Drawing.Point(742, 14);
            this.grpEliminarElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminarElemento.Name = "grpEliminarElemento";
            this.grpEliminarElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminarElemento.Size = new System.Drawing.Size(288, 177);
            this.grpEliminarElemento.TabIndex = 24;
            this.grpEliminarElemento.TabStop = false;
            this.grpEliminarElemento.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(96, 55);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(180, 33);
            this.cmbCodigo.TabIndex = 14;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(8, 65);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(81, 24);
            this.lblCodigo2.TabIndex = 13;
            this.lblCodigo2.Text = "Codigo: ";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(8, 112);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(268, 54);
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
            this.grpNuevoElemento.Location = new System.Drawing.Point(432, 14);
            this.grpNuevoElemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevoElemento.Size = new System.Drawing.Size(296, 335);
            this.grpNuevoElemento.TabIndex = 23;
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
            // grp4
            // 
            this.grp4.Controls.Add(this.btnDesc);
            this.grp4.Controls.Add(this.btnAsc);
            this.grp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp4.Location = new System.Drawing.Point(742, 198);
            this.grp4.Name = "grp4";
            this.grp4.Size = new System.Drawing.Size(288, 149);
            this.grp4.TabIndex = 27;
            this.grp4.TabStop = false;
            this.grp4.Text = "Listar Datos";
            // 
            // btnDesc
            // 
            this.btnDesc.AutoSize = true;
            this.btnDesc.Location = new System.Drawing.Point(12, 103);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(153, 29);
            this.btnDesc.TabIndex = 1;
            this.btnDesc.TabStop = true;
            this.btnDesc.Text = "Descendente";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.CheckedChanged += new System.EventHandler(this.btnDesc_CheckedChanged);
            // 
            // btnAsc
            // 
            this.btnAsc.AutoSize = true;
            this.btnAsc.Location = new System.Drawing.Point(12, 49);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(142, 29);
            this.btnAsc.TabIndex = 0;
            this.btnAsc.TabStop = true;
            this.btnAsc.Text = "Ascendente";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.CheckedChanged += new System.EventHandler(this.btnAsc_CheckedChanged);
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1069, 768);
            this.Controls.Add(this.grp4);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.grpEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente Enlazada";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.grp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.grpEliminarElemento.ResumeLayout(false);
            this.grpEliminarElemento.PerformLayout();
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            this.grp4.ResumeLayout(false);
            this.grp4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp3;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.GroupBox grpEliminarElemento;
        private System.Windows.Forms.ComboBox cmbCodigo;
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
        private System.Windows.Forms.GroupBox grp4;
        private System.Windows.Forms.RadioButton btnDesc;
        private System.Windows.Forms.RadioButton btnAsc;
    }
}
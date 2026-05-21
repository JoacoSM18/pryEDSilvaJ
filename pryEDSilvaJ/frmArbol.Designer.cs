namespace pryEDSilvaJ
{
    partial class frmArbol
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
            this.trvArbol = new System.Windows.Forms.TreeView();
            this.grpNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.grpEliminarElemento = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNuevoElemento.SuspendLayout();
            this.grpEliminarElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // trvArbol
            // 
            this.trvArbol.Location = new System.Drawing.Point(12, 12);
            this.trvArbol.Name = "trvArbol";
            this.trvArbol.Size = new System.Drawing.Size(220, 191);
            this.trvArbol.TabIndex = 0;
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
            this.grpNuevoElemento.Location = new System.Drawing.Point(250, 12);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Size = new System.Drawing.Size(153, 204);
            this.grpNuevoElemento.TabIndex = 24;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 31);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.lblNombre.Location = new System.Drawing.Point(6, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(91, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(56, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(73, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(69, 107);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(73, 23);
            this.txtTramite.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(7, 114);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 6;
            this.lblTramite.Text = "Trámite:";
            // 
            // grpEliminarElemento
            // 
            this.grpEliminarElemento.Controls.Add(this.button1);
            this.grpEliminarElemento.Controls.Add(this.cmbCodigo);
            this.grpEliminarElemento.Controls.Add(this.lblCodigo2);
            this.grpEliminarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarElemento.Location = new System.Drawing.Point(415, 12);
            this.grpEliminarElemento.Name = "grpEliminarElemento";
            this.grpEliminarElemento.Size = new System.Drawing.Size(199, 150);
            this.grpEliminarElemento.TabIndex = 25;
            this.grpEliminarElemento.TabStop = false;
            this.grpEliminarElemento.Text = "Elemento a Eliminar";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(64, 41);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 24);
            this.cmbCodigo.TabIndex = 14;
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(5, 47);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo2.TabIndex = 13;
            this.lblCodigo2.Text = "Codigo: ";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(415, 172);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(183, 35);
            this.btnEquilibrar.TabIndex = 8;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(23, 31);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 17);
            this.btn1.TabIndex = 26;
            this.btn1.TabStop = true;
            this.btn1.Text = "In - Orden";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(23, 79);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 17);
            this.btn2.TabIndex = 27;
            this.btn2.TabStop = true;
            this.btn2.Text = "Pre - Orden";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(23, 124);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 17);
            this.btn3.TabIndex = 28;
            this.btn3.TabStop = true;
            this.btn3.Text = "Post - Orden";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvArbol);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(14, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 163);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Arbol";
            // 
            // dgvArbol
            // 
            this.dgvArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvArbol.Location = new System.Drawing.Point(236, 19);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.RowHeadersWidth = 40;
            this.dgvArbol.Size = new System.Drawing.Size(348, 138);
            this.dgvArbol.TabIndex = 29;
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
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.trvArbol);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
            this.grpEliminarElemento.ResumeLayout(false);
            this.grpEliminarElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvArbol;
        private System.Windows.Forms.GroupBox grpNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox grpEliminarElemento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.RadioButton btn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
    }
}
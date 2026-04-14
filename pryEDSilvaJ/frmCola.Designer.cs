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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.grp1.SuspendLayout();
            this.grpNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(299, 17);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(371, 214);
            this.dgvCola.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(91, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(117, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(91, 101);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(117, 23);
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
            this.lblNombre.Location = new System.Drawing.Point(6, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(6, 109);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 6;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(199, 31);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(348, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(145, 37);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
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
            this.grp1.Location = new System.Drawing.Point(12, 246);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(676, 252);
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
            this.grpNuevoElemento.Location = new System.Drawing.Point(311, 75);
            this.grpNuevoElemento.Name = "grpNuevoElemento";
            this.grpNuevoElemento.Size = new System.Drawing.Size(214, 165);
            this.grpNuevoElemento.TabIndex = 10;
            this.grpNuevoElemento.TabStop = false;
            this.grpNuevoElemento.Text = "Nuevo Elemento";
            // 
            // grbEliminarElemento
            // 
            this.grbEliminarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEliminarElemento.Location = new System.Drawing.Point(539, 75);
            this.grbEliminarElemento.Name = "grbEliminarElemento";
            this.grbEliminarElemento.Size = new System.Drawing.Size(142, 161);
            this.grbEliminarElemento.TabIndex = 12;
            this.grbEliminarElemento.TabStop = false;
            this.grbEliminarElemento.Text = "Eliminar Elemento";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 514);
            this.Controls.Add(this.grbEliminarElemento);
            this.Controls.Add(this.grpNuevoElemento);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.btnBorrar);
            this.Name = "frmCola";
            this.Text = "Estructura Dinámica Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grpNuevoElemento.ResumeLayout(false);
            this.grpNuevoElemento.PerformLayout();
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
    }
}
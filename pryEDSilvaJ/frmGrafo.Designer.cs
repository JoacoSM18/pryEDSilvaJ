namespace pryEDSilvaJ
{
    partial class frmGrafo
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
            this.grbCargaDatos = new System.Windows.Forms.GroupBox();
            this.grbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbListarViajes = new System.Windows.Forms.GroupBox();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbOrigenes = new System.Windows.Forms.ComboBox();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.cmbOrigenes2 = new System.Windows.Forms.ComboBox();
            this.cmbDestinos2 = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnVerTodoslosViajes = new System.Windows.Forms.Button();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.grbCargaDatos.SuspendLayout();
            this.grbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCargaDatos
            // 
            this.grbCargaDatos.Controls.Add(this.cmbDestinos);
            this.grbCargaDatos.Controls.Add(this.cmbOrigenes);
            this.grbCargaDatos.Controls.Add(this.btnCargar);
            this.grbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.grbCargaDatos.Controls.Add(this.lblPrecio);
            this.grbCargaDatos.Controls.Add(this.lblDestino);
            this.grbCargaDatos.Controls.Add(this.lblOrigen);
            this.grbCargaDatos.Location = new System.Drawing.Point(247, 12);
            this.grbCargaDatos.Name = "grbCargaDatos";
            this.grbCargaDatos.Size = new System.Drawing.Size(264, 169);
            this.grbCargaDatos.TabIndex = 0;
            this.grbCargaDatos.TabStop = false;
            this.grbCargaDatos.Text = "Carga de Datos";
            // 
            // grbConsultaDatos
            // 
            this.grbConsultaDatos.Controls.Add(this.cmbDestinos2);
            this.grbConsultaDatos.Controls.Add(this.cmbOrigenes2);
            this.grbConsultaDatos.Controls.Add(this.btnBorrar);
            this.grbConsultaDatos.Controls.Add(this.btnConsultar);
            this.grbConsultaDatos.Controls.Add(this.lblPrecio2);
            this.grbConsultaDatos.Controls.Add(this.lblDestino2);
            this.grbConsultaDatos.Controls.Add(this.lblOrigen2);
            this.grbConsultaDatos.Location = new System.Drawing.Point(526, 12);
            this.grbConsultaDatos.Name = "grbConsultaDatos";
            this.grbConsultaDatos.Size = new System.Drawing.Size(242, 169);
            this.grbConsultaDatos.TabIndex = 1;
            this.grbConsultaDatos.TabStop = false;
            this.grbConsultaDatos.Text = "Consulta de Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 169);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grbListarViajes
            // 
            this.grbListarViajes.Controls.Add(this.btnListarDestinos);
            this.grbListarViajes.Controls.Add(this.btnVerTodoslosViajes);
            this.grbListarViajes.Controls.Add(this.btnListarOrigenes);
            this.grbListarViajes.Controls.Add(this.cmbHasta);
            this.grbListarViajes.Controls.Add(this.cmbDesde);
            this.grbListarViajes.Controls.Add(this.lblHasta);
            this.grbListarViajes.Controls.Add(this.lblDesde);
            this.grbListarViajes.Controls.Add(this.dgvViajes);
            this.grbListarViajes.Location = new System.Drawing.Point(12, 200);
            this.grbListarViajes.Name = "grbListarViajes";
            this.grbListarViajes.Size = new System.Drawing.Size(756, 360);
            this.grbListarViajes.TabIndex = 3;
            this.grbListarViajes.TabStop = false;
            this.grbListarViajes.Text = "Listar Viajes";
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(14, 73);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(729, 273);
            this.dgvViajes.TabIndex = 0;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 27);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 64);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 102);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(5, 27);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(5, 64);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(46, 13);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(5, 102);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(11, 35);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(323, 35);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(6, 140);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(115, 23);
            this.btnBorrarTodo.TabIndex = 3;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(132, 140);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(126, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(8, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(127, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cmbOrigenes
            // 
            this.cmbOrigenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenes.FormattingEnabled = true;
            this.cmbOrigenes.Location = new System.Drawing.Point(118, 24);
            this.cmbOrigenes.Name = "cmbOrigenes";
            this.cmbOrigenes.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenes.TabIndex = 5;
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(118, 61);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinos.TabIndex = 6;
            // 
            // cmbOrigenes2
            // 
            this.cmbOrigenes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenes2.FormattingEnabled = true;
            this.cmbOrigenes2.Location = new System.Drawing.Point(98, 24);
            this.cmbOrigenes2.Name = "cmbOrigenes2";
            this.cmbOrigenes2.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenes2.TabIndex = 5;
            // 
            // cmbDestinos2
            // 
            this.cmbDestinos2.FormattingEnabled = true;
            this.cmbDestinos2.Location = new System.Drawing.Point(98, 56);
            this.cmbDestinos2.Name = "cmbDestinos2";
            this.cmbDestinos2.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinos2.TabIndex = 6;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(58, 27);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(153, 21);
            this.cmbDesde.TabIndex = 3;
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(367, 32);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 4;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(514, 30);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(107, 23);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnVerTodoslosViajes
            // 
            this.btnVerTodoslosViajes.Location = new System.Drawing.Point(627, 30);
            this.btnVerTodoslosViajes.Name = "btnVerTodoslosViajes";
            this.btnVerTodoslosViajes.Size = new System.Drawing.Size(123, 23);
            this.btnVerTodoslosViajes.TabIndex = 6;
            this.btnVerTodoslosViajes.Text = "Ver Todos los Viajes";
            this.btnVerTodoslosViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(231, 30);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(86, 23);
            this.btnListarDestinos.TabIndex = 7;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 585);
            this.Controls.Add(this.grbListarViajes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbConsultaDatos);
            this.Controls.Add(this.grbCargaDatos);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.grbCargaDatos.ResumeLayout(false);
            this.grbCargaDatos.PerformLayout();
            this.grbConsultaDatos.ResumeLayout(false);
            this.grbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbListarViajes.ResumeLayout(false);
            this.grbListarViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCargaDatos;
        private System.Windows.Forms.GroupBox grbConsultaDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbListarViajes;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.ComboBox cmbOrigenes;
        private System.Windows.Forms.ComboBox cmbDestinos2;
        private System.Windows.Forms.ComboBox cmbOrigenes2;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.Button btnVerTodoslosViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
    }
}
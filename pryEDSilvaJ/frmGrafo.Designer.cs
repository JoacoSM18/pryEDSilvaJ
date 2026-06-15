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
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.cmbOrigenes = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.grbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.cmbDestinos2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigenes2 = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbListarViajes = new System.Windows.Forms.GroupBox();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.btnVerTodoslosViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.lblPrecio3D = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.grbCargaDatos.SuspendLayout();
            this.grbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCargaDatos
            // 
            this.grbCargaDatos.Controls.Add(this.txtPrecio);
            this.grbCargaDatos.Controls.Add(this.cmbDestinos);
            this.grbCargaDatos.Controls.Add(this.cmbOrigenes);
            this.grbCargaDatos.Controls.Add(this.btnCargar);
            this.grbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.grbCargaDatos.Controls.Add(this.lblPrecio);
            this.grbCargaDatos.Controls.Add(this.lblDestino);
            this.grbCargaDatos.Controls.Add(this.lblOrigen);
            this.grbCargaDatos.Location = new System.Drawing.Point(370, 18);
            this.grbCargaDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCargaDatos.Name = "grbCargaDatos";
            this.grbCargaDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCargaDatos.Size = new System.Drawing.Size(396, 260);
            this.grbCargaDatos.TabIndex = 0;
            this.grbCargaDatos.TabStop = false;
            this.grbCargaDatos.Text = "Carga de Datos";
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(177, 94);
            this.cmbDestinos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(180, 28);
            this.cmbDestinos.TabIndex = 6;
            // 
            // cmbOrigenes
            // 
            this.cmbOrigenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenes.FormattingEnabled = true;
            this.cmbOrigenes.Location = new System.Drawing.Point(177, 37);
            this.cmbOrigenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOrigenes.Name = "cmbOrigenes";
            this.cmbOrigenes.Size = new System.Drawing.Size(180, 28);
            this.cmbOrigenes.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(198, 215);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(189, 35);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(9, 215);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(172, 35);
            this.btnBorrarTodo.TabIndex = 3;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(10, 157);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(9, 98);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(68, 20);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(9, 42);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(60, 20);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // grbConsultaDatos
            // 
            this.grbConsultaDatos.Controls.Add(this.lblPrecio3D);
            this.grbConsultaDatos.Controls.Add(this.cmbDestinos2);
            this.grbConsultaDatos.Controls.Add(this.cmbOrigenes2);
            this.grbConsultaDatos.Controls.Add(this.btnBorrar);
            this.grbConsultaDatos.Controls.Add(this.btnConsultar);
            this.grbConsultaDatos.Controls.Add(this.lblPrecio2);
            this.grbConsultaDatos.Controls.Add(this.lblDestino2);
            this.grbConsultaDatos.Controls.Add(this.lblOrigen2);
            this.grbConsultaDatos.Location = new System.Drawing.Point(789, 18);
            this.grbConsultaDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbConsultaDatos.Name = "grbConsultaDatos";
            this.grbConsultaDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbConsultaDatos.Size = new System.Drawing.Size(363, 260);
            this.grbConsultaDatos.TabIndex = 1;
            this.grbConsultaDatos.TabStop = false;
            this.grbConsultaDatos.Text = "Consulta de Datos";
            // 
            // cmbDestinos2
            // 
            this.cmbDestinos2.FormattingEnabled = true;
            this.cmbDestinos2.Location = new System.Drawing.Point(147, 86);
            this.cmbDestinos2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDestinos2.Name = "cmbDestinos2";
            this.cmbDestinos2.Size = new System.Drawing.Size(180, 28);
            this.cmbDestinos2.TabIndex = 6;
            // 
            // cmbOrigenes2
            // 
            this.cmbOrigenes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenes2.FormattingEnabled = true;
            this.cmbOrigenes2.Location = new System.Drawing.Point(147, 37);
            this.cmbOrigenes2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOrigenes2.Name = "cmbOrigenes2";
            this.cmbOrigenes2.Size = new System.Drawing.Size(180, 28);
            this.cmbOrigenes2.TabIndex = 5;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(190, 215);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(164, 35);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 215);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(148, 35);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(8, 157);
            this.lblPrecio2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio2.TabIndex = 2;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(8, 98);
            this.lblDestino2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(68, 20);
            this.lblDestino2.TabIndex = 1;
            this.lblDestino2.Text = "Destino:";
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(8, 42);
            this.lblOrigen2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(60, 20);
            this.lblOrigen2.TabIndex = 0;
            this.lblOrigen2.Text = "Origen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDSilvaJ.Properties.Resources.Captura_de_pantalla_2019_10_18_a_las_14_04_37;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.grbListarViajes.Location = new System.Drawing.Point(18, 308);
            this.grbListarViajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListarViajes.Name = "grbListarViajes";
            this.grbListarViajes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbListarViajes.Size = new System.Drawing.Size(1134, 562);
            this.grbListarViajes.TabIndex = 3;
            this.grbListarViajes.TabStop = false;
            this.grbListarViajes.Text = "Listar Viajes";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(320, 47);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(129, 35);
            this.btnListarDestinos.TabIndex = 7;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // btnVerTodoslosViajes
            // 
            this.btnVerTodoslosViajes.Location = new System.Drawing.Point(941, 43);
            this.btnVerTodoslosViajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerTodoslosViajes.Name = "btnVerTodoslosViajes";
            this.btnVerTodoslosViajes.Size = new System.Drawing.Size(184, 35);
            this.btnVerTodoslosViajes.TabIndex = 6;
            this.btnVerTodoslosViajes.Text = "Ver Todos los Viajes";
            this.btnVerTodoslosViajes.UseVisualStyleBackColor = true;
            this.btnVerTodoslosViajes.Click += new System.EventHandler(this.btnVerTodoslosViajes_Click);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(738, 46);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(160, 35);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(550, 50);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(180, 28);
            this.cmbHasta.TabIndex = 4;
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(84, 50);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(228, 28);
            this.cmbDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(486, 53);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(17, 54);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(21, 112);
            this.dgvViajes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.RowHeadersWidth = 62;
            this.dgvViajes.Size = new System.Drawing.Size(1094, 420);
            this.dgvViajes.TabIndex = 0;
            // 
            // lblPrecio3D
            // 
            this.lblPrecio3D.Location = new System.Drawing.Point(143, 154);
            this.lblPrecio3D.Name = "lblPrecio3D";
            this.lblPrecio3D.Size = new System.Drawing.Size(150, 23);
            this.lblPrecio3D.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(177, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 26);
            this.txtPrecio.TabIndex = 7;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1176, 934);
            this.Controls.Add(this.grbListarViajes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbConsultaDatos);
            this.Controls.Add(this.grbCargaDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label lblPrecio3D;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}
namespace pryEDSilvaJ
{
    partial class frmOperacionesBD
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
            this.gbOpAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.gbOpSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnMultiat = new System.Windows.Forms.Button();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.gbOpProyeccion = new System.Windows.Forms.GroupBox();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.btnMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.gbOpAlgebraicas.SuspendLayout();
            this.gbOpSeleccion.SuspendLayout();
            this.gbOpProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpAlgebraicas
            // 
            this.gbOpAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gbOpAlgebraicas.Controls.Add(this.btnInterseccion);
            this.gbOpAlgebraicas.Controls.Add(this.btnUnion);
            this.gbOpAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpAlgebraicas.Location = new System.Drawing.Point(823, 470);
            this.gbOpAlgebraicas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpAlgebraicas.Name = "gbOpAlgebraicas";
            this.gbOpAlgebraicas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpAlgebraicas.Size = new System.Drawing.Size(354, 205);
            this.gbOpAlgebraicas.TabIndex = 7;
            this.gbOpAlgebraicas.TabStop = false;
            this.gbOpAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(9, 143);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(336, 35);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(9, 88);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(336, 35);
            this.btnInterseccion.TabIndex = 7;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(9, 31);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(336, 35);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // gbOpSeleccion
            // 
            this.gbOpSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.gbOpSeleccion.Controls.Add(this.btnMultiat);
            this.gbOpSeleccion.Controls.Add(this.btnConvolucion);
            this.gbOpSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpSeleccion.Location = new System.Drawing.Point(421, 470);
            this.gbOpSeleccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpSeleccion.Name = "gbOpSeleccion";
            this.gbOpSeleccion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpSeleccion.Size = new System.Drawing.Size(354, 205);
            this.gbOpSeleccion.TabIndex = 6;
            this.gbOpSeleccion.TabStop = false;
            this.gbOpSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(9, 31);
            this.btnSeleccionSimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(336, 35);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Selección Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnMultiat
            // 
            this.btnMultiat.Location = new System.Drawing.Point(9, 88);
            this.btnMultiat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiat.Name = "btnMultiat";
            this.btnMultiat.Size = new System.Drawing.Size(336, 35);
            this.btnMultiat.TabIndex = 4;
            this.btnMultiat.Text = "Selección Multiatributo";
            this.btnMultiat.UseVisualStyleBackColor = true;
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Location = new System.Drawing.Point(9, 143);
            this.btnConvolucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(336, 35);
            this.btnConvolucion.TabIndex = 5;
            this.btnConvolucion.Text = "Selección por Convolución";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            // 
            // gbOpProyeccion
            // 
            this.gbOpProyeccion.Controls.Add(this.btnProySimple);
            this.gbOpProyeccion.Controls.Add(this.btnMultiatributo);
            this.gbOpProyeccion.Controls.Add(this.btnJuntar);
            this.gbOpProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpProyeccion.Location = new System.Drawing.Point(13, 470);
            this.gbOpProyeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpProyeccion.Name = "gbOpProyeccion";
            this.gbOpProyeccion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpProyeccion.Size = new System.Drawing.Size(354, 205);
            this.gbOpProyeccion.TabIndex = 5;
            this.gbOpProyeccion.TabStop = false;
            this.gbOpProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(9, 31);
            this.btnProySimple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(336, 35);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección Simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            // 
            // btnMultiatributo
            // 
            this.btnMultiatributo.Location = new System.Drawing.Point(9, 88);
            this.btnMultiatributo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiatributo.Name = "btnMultiatributo";
            this.btnMultiatributo.Size = new System.Drawing.Size(336, 35);
            this.btnMultiatributo.TabIndex = 1;
            this.btnMultiatributo.Text = "Proyección Multiatributo";
            this.btnMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(9, 143);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(336, 35);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // dgvBD
            // 
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(13, 14);
            this.dgvBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.RowHeadersWidth = 62;
            this.dgvBD.Size = new System.Drawing.Size(1164, 430);
            this.dgvBD.TabIndex = 4;
            // 
            // frmOperacionesBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1211, 689);
            this.Controls.Add(this.gbOpAlgebraicas);
            this.Controls.Add(this.gbOpSeleccion);
            this.Controls.Add(this.gbOpProyeccion);
            this.Controls.Add(this.dgvBD);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOperacionesBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones con Base de Datos";
            this.gbOpAlgebraicas.ResumeLayout(false);
            this.gbOpSeleccion.ResumeLayout(false);
            this.gbOpProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox gbOpSeleccion;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnMultiat;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.GroupBox gbOpProyeccion;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.Button btnMultiatributo;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.DataGridView dgvBD;
    }
}
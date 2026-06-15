namespace pryEDSilvaJ
{
    partial class frmConsultasVarias
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Location = new System.Drawing.Point(12, 160);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(944, 181);
            this.lbl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operaciones a Realizar en la Base de Datos";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(408, 81);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(385, 28);
            this.cmbOperacion.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(813, 75);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(143, 39);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(12, 354);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.RowHeadersWidth = 62;
            this.dgvOperaciones.RowTemplate.Height = 28;
            this.dgvOperaciones.Size = new System.Drawing.Size(944, 275);
            this.dgvOperaciones.TabIndex = 4;
            // 
            // frmConsultasVarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(968, 641);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "frmConsultasVarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas Varias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvOperaciones;
    }
}
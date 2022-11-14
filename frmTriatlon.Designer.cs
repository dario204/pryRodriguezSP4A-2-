namespace pryRodriguezSP4A_2_
{
    partial class frmTriatlon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.btnAsignarParticipantes = new System.Windows.Forms.Button();
            this.btnGanadores = new System.Windows.Forms.Button();
            this.lblPosiciones = new System.Windows.Forms.Label();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.lblGanadores = new System.Windows.Forms.Label();
            this.dgvGanadores = new System.Windows.Forms.DataGridView();
            this.Ganadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picGanadores = new System.Windows.Forms.PictureBox();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Columna2,
            this.Columna3});
            this.dgvParticipantes.Location = new System.Drawing.Point(29, 37);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersWidth = 51;
            this.dgvParticipantes.RowTemplate.Height = 24;
            this.dgvParticipantes.Size = new System.Drawing.Size(769, 216);
            this.dgvParticipantes.TabIndex = 0;
            this.dgvParticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipantes_CellContentClick);
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(26, 18);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(85, 16);
            this.lblParticipantes.TabIndex = 1;
            this.lblParticipantes.Text = "Participantes";
            // 
            // btnAsignarParticipantes
            // 
            this.btnAsignarParticipantes.Location = new System.Drawing.Point(850, 37);
            this.btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            this.btnAsignarParticipantes.Size = new System.Drawing.Size(109, 60);
            this.btnAsignarParticipantes.TabIndex = 2;
            this.btnAsignarParticipantes.Text = "Asignar Participantes";
            this.btnAsignarParticipantes.UseVisualStyleBackColor = true;
            this.btnAsignarParticipantes.Click += new System.EventHandler(this.btnAsignarParticipantes_Click);
            // 
            // btnGanadores
            // 
            this.btnGanadores.Location = new System.Drawing.Point(850, 116);
            this.btnGanadores.Name = "btnGanadores";
            this.btnGanadores.Size = new System.Drawing.Size(109, 53);
            this.btnGanadores.TabIndex = 3;
            this.btnGanadores.Text = "Determinar Ganadores";
            this.btnGanadores.UseVisualStyleBackColor = true;
            this.btnGanadores.Click += new System.EventHandler(this.btnGanadores_Click);
            // 
            // lblPosiciones
            // 
            this.lblPosiciones.AutoSize = true;
            this.lblPosiciones.Location = new System.Drawing.Point(26, 279);
            this.lblPosiciones.Name = "lblPosiciones";
            this.lblPosiciones.Size = new System.Drawing.Size(74, 16);
            this.lblPosiciones.TabIndex = 4;
            this.lblPosiciones.Text = "Posiciones";
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.AllowUserToAddRows = false;
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPosiciones.Location = new System.Drawing.Point(29, 311);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowHeadersWidth = 51;
            this.dgvPosiciones.RowTemplate.Height = 24;
            this.dgvPosiciones.Size = new System.Drawing.Size(930, 150);
            this.dgvPosiciones.TabIndex = 5;
            // 
            // lblGanadores
            // 
            this.lblGanadores.AutoSize = true;
            this.lblGanadores.Location = new System.Drawing.Point(26, 482);
            this.lblGanadores.Name = "lblGanadores";
            this.lblGanadores.Size = new System.Drawing.Size(75, 16);
            this.lblGanadores.TabIndex = 6;
            this.lblGanadores.Text = "Ganadores";
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.AllowUserToAddRows = false;
            this.dgvGanadores.AllowUserToDeleteRows = false;
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ganadores,
            this.Nombre,
            this.País,
            this.Puntos});
            this.dgvGanadores.Location = new System.Drawing.Point(29, 501);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.ReadOnly = true;
            this.dgvGanadores.RowHeadersWidth = 51;
            this.dgvGanadores.RowTemplate.Height = 24;
            this.dgvGanadores.Size = new System.Drawing.Size(802, 181);
            this.dgvGanadores.TabIndex = 7;
            // 
            // Ganadores
            // 
            this.Ganadores.HeaderText = "Puesto";
            this.Ganadores.MinimumWidth = 6;
            this.Ganadores.Name = "Ganadores";
            this.Ganadores.ReadOnly = true;
            this.Ganadores.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.MinimumWidth = 6;
            this.País.Name = "País";
            this.País.ReadOnly = true;
            this.País.Width = 125;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            this.Puntos.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Nombre";
            this.Columna2.MinimumWidth = 6;
            this.Columna2.Name = "Columna2";
            this.Columna2.Width = 250;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "País";
            this.Columna3.MinimumWidth = 6;
            this.Columna3.Name = "Columna3";
            this.Columna3.Width = 200;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(850, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // picGanadores
            // 
            this.picGanadores.Image = global::pryRodriguezSP4A_2_.Properties.Resources.puestos;
            this.picGanadores.Location = new System.Drawing.Point(852, 501);
            this.picGanadores.Name = "picGanadores";
            this.picGanadores.Size = new System.Drawing.Size(251, 198);
            this.picGanadores.TabIndex = 9;
            this.picGanadores.TabStop = false;
            // 
            // Prueba
            // 
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.MinimumWidth = 6;
            this.Prueba.Name = "Prueba";
            this.Prueba.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Participante 1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Participante 2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Participante 3";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Participante 4";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Participante 5";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Participante 6";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // frmTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 749);
            this.Controls.Add(this.picGanadores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvGanadores);
            this.Controls.Add(this.lblGanadores);
            this.Controls.Add(this.dgvPosiciones);
            this.Controls.Add(this.lblPosiciones);
            this.Controls.Add(this.btnGanadores);
            this.Controls.Add(this.btnAsignarParticipantes);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.dgvParticipantes);
            this.Name = "frmTriatlon";
            this.Text = "Triatlon";
            this.Load += new System.EventHandler(this.frmTriatlon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.Button btnAsignarParticipantes;
        private System.Windows.Forms.Button btnGanadores;
        private System.Windows.Forms.Label lblPosiciones;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.Label lblGanadores;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}


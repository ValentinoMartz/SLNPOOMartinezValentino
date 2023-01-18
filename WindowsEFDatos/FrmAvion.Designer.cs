namespace WindowsEFDatos
{
    partial class FrmAvion
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
            this.btnCrearAvion = new System.Windows.Forms.Button();
            this.gridAviones = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblDenominacion = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnTraerPorID = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearAvion
            // 
            this.btnCrearAvion.Location = new System.Drawing.Point(626, 28);
            this.btnCrearAvion.Name = "btnCrearAvion";
            this.btnCrearAvion.Size = new System.Drawing.Size(115, 44);
            this.btnCrearAvion.TabIndex = 0;
            this.btnCrearAvion.Text = "Crear Avion";
            this.btnCrearAvion.UseVisualStyleBackColor = true;
            this.btnCrearAvion.Click += new System.EventHandler(this.btnCrearAvion_Click);
            // 
            // gridAviones
            // 
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Location = new System.Drawing.Point(12, 120);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.Size = new System.Drawing.Size(569, 227);
            this.gridAviones.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(179, 59);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 3;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(382, 59);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(100, 20);
            this.txtDenominacion.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(176, 28);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 10;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Location = new System.Drawing.Point(379, 28);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(75, 13);
            this.lblDenominacion.TabIndex = 11;
            this.lblDenominacion.Text = "Denominacion";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(626, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 44);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnTraerPorID
            // 
            this.btnTraerPorID.Location = new System.Drawing.Point(626, 303);
            this.btnTraerPorID.Name = "btnTraerPorID";
            this.btnTraerPorID.Size = new System.Drawing.Size(115, 44);
            this.btnTraerPorID.TabIndex = 13;
            this.btnTraerPorID.Text = "Traer por ID";
            this.btnTraerPorID.UseVisualStyleBackColor = true;
            this.btnTraerPorID.Click += new System.EventHandler(this.btnTraerPorID_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(626, 210);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 44);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 394);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTraerPorID);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblDenominacion);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.gridAviones);
            this.Controls.Add(this.btnCrearAvion);
            this.Name = "FrmAvion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAvion;
        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblDenominacion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnTraerPorID;
        private System.Windows.Forms.Button btnEliminar;
    }
}


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
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearAvion
            // 
            this.btnCrearAvion.Location = new System.Drawing.Point(629, 83);
            this.btnCrearAvion.Name = "btnCrearAvion";
            this.btnCrearAvion.Size = new System.Drawing.Size(115, 73);
            this.btnCrearAvion.TabIndex = 0;
            this.btnCrearAvion.Text = "Crear Avion";
            this.btnCrearAvion.UseVisualStyleBackColor = true;
            this.btnCrearAvion.Click += new System.EventHandler(this.btnCrearAvion_Click);
            // 
            // gridAviones
            // 
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Location = new System.Drawing.Point(12, 52);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.Size = new System.Drawing.Size(569, 150);
            this.gridAviones.TabIndex = 1;
            
            // 
            // FrmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 278);
            this.Controls.Add(this.gridAviones);
            this.Controls.Add(this.btnCrearAvion);
            this.Name = "FrmAvion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAvion;
        private System.Windows.Forms.DataGridView gridAviones;
    }
}


﻿namespace PresentacionVehiculos
{
    partial class Form1
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
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnRemolque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCamion
            // 
            this.btnCamion.Location = new System.Drawing.Point(104, 95);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(149, 71);
            this.btnCamion.TabIndex = 0;
            this.btnCamion.Text = "Crear Camion";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // btnRemolque
            // 
            this.btnRemolque.Location = new System.Drawing.Point(104, 259);
            this.btnRemolque.Name = "btnRemolque";
            this.btnRemolque.Size = new System.Drawing.Size(149, 71);
            this.btnRemolque.TabIndex = 1;
            this.btnRemolque.Text = "Crear Remolque";
            this.btnRemolque.UseVisualStyleBackColor = true;
            this.btnRemolque.Click += new System.EventHandler(this.btnRemolque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btnRemolque);
            this.Controls.Add(this.btnCamion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnRemolque;
    }
}


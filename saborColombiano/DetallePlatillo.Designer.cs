
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class DetallePlatillo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        /// 
        
        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblPLatillo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.tbxReferencia = new System.Windows.Forms.TextBox();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.tbxPrecio);
            this.pnlPrincipal.Controls.Add(this.lblPLatillo);
            this.pnlPrincipal.Controls.Add(this.lblPrecio);
            this.pnlPrincipal.Controls.Add(this.lblCantidad);
            this.pnlPrincipal.Controls.Add(this.lblReferencia);
            this.pnlPrincipal.Controls.Add(this.tbxDescripcion);
            this.pnlPrincipal.Controls.Add(this.tbxCantidad);
            this.pnlPrincipal.Controls.Add(this.tbxReferencia);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(422, 84);
            this.pnlPrincipal.TabIndex = 1;
            this.pnlPrincipal.Click += new System.EventHandler(this.pnlPrincipal_Click);
            this.pnlPrincipal.Leave += new System.EventHandler(this.DetallePlatillo_Leave);
            this.pnlPrincipal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPrincipal_MouseClick);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BackColor = System.Drawing.Color.White;
            this.tbxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPrecio.Enabled = false;
            this.tbxPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrecio.Location = new System.Drawing.Point(231, 23);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.ReadOnly = true;
            this.tbxPrecio.Size = new System.Drawing.Size(79, 20);
            this.tbxPrecio.TabIndex = 1;
            // 
            // lblPLatillo
            // 
            this.lblPLatillo.AutoSize = true;
            this.lblPLatillo.Location = new System.Drawing.Point(6, 55);
            this.lblPLatillo.Name = "lblPLatillo";
            this.lblPLatillo.Size = new System.Drawing.Size(59, 15);
            this.lblPLatillo.TabIndex = 4;
            this.lblPLatillo.Text = "Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(184, 24);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(318, 23);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(40, 17);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cant:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReferencia.Location = new System.Drawing.Point(6, 24);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(32, 17);
            this.lblReferencia.TabIndex = 2;
            this.lblReferencia.Text = "Ref:";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.Color.White;
            this.tbxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescripcion.Enabled = false;
            this.tbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescripcion.Location = new System.Drawing.Point(65, 54);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.ReadOnly = true;
            this.tbxDescripcion.Size = new System.Drawing.Size(314, 22);
            this.tbxDescripcion.TabIndex = 1;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.BackColor = System.Drawing.Color.White;
            this.tbxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCantidad.Enabled = false;
            this.tbxCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCantidad.Location = new System.Drawing.Point(360, 22);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.ReadOnly = true;
            this.tbxCantidad.Size = new System.Drawing.Size(42, 20);
            this.tbxCantidad.TabIndex = 1;
            // 
            // tbxReferencia
            // 
            this.tbxReferencia.BackColor = System.Drawing.Color.White;
            this.tbxReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxReferencia.Enabled = false;
            this.tbxReferencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxReferencia.Location = new System.Drawing.Point(39, 22);
            this.tbxReferencia.Name = "tbxReferencia";
            this.tbxReferencia.ReadOnly = true;
            this.tbxReferencia.Size = new System.Drawing.Size(118, 20);
            this.tbxReferencia.TabIndex = 1;
            // 
            // DetallePlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.Name = "DetallePlatillo";
            this.Size = new System.Drawing.Size(422, 84);
            this.Leave += new System.EventHandler(this.DetallePlatillo_Leave);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        public System.Windows.Forms.TextBox tbxReferencia;
        public System.Windows.Forms.TextBox tbxDescripcion;
        public System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblPLatillo;
        private System.Windows.Forms.Label lblCantidad;
        public System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}

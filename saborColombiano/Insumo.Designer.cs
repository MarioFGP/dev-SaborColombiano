
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class Insumo
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.imgBusqued = new System.Windows.Forms.PictureBox();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqued)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.imgBusqued);
            this.pnlPrincipal.Controls.Add(this.tbxBarrabusqueda);
            this.pnlPrincipal.Controls.Add(this.btnEliminar);
            this.pnlPrincipal.Controls.Add(this.btnModificar);
            this.pnlPrincipal.Controls.Add(this.btnRegistrar);
            this.pnlPrincipal.Controls.Add(this.tbxPrecio);
            this.pnlPrincipal.Controls.Add(this.lblPrecio);
            this.pnlPrincipal.Controls.Add(this.tbxDescripcion);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.tbxNombre);
            this.pnlPrincipal.Controls.Add(this.lblDescripcion);
            this.pnlPrincipal.Controls.Add(this.tbxReferencia);
            this.pnlPrincipal.Controls.Add(this.lblReferencia);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(835, 508);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // imgBusqued
            // 
            this.imgBusqued.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.imgBusqued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBusqued.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqued.Location = new System.Drawing.Point(342, 54);
            this.imgBusqued.Name = "imgBusqued";
            this.imgBusqued.Size = new System.Drawing.Size(39, 24);
            this.imgBusqued.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqued.TabIndex = 22;
            this.imgBusqued.TabStop = false;
            this.imgBusqued.Click += new System.EventHandler(this.imgBusqued_Click);
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(49, 54);
            this.tbxBarrabusqueda.MaxLength = 20;
            this.tbxBarrabusqueda.Name = "tbxBarrabusqueda";
            this.tbxBarrabusqueda.PlaceholderText = "Busque por nombre o referencia";
            this.tbxBarrabusqueda.Size = new System.Drawing.Size(292, 24);
            this.tbxBarrabusqueda.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(511, 356);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 49);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar insumo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(295, 356);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 49);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar insumo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(98, 356);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 49);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar insumo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrecio.Location = new System.Drawing.Point(432, 146);
            this.tbxPrecio.MaxLength = 11;
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(317, 26);
            this.tbxPrecio.TabIndex = 3;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(432, 116);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(177, 28);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio unitario";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescripcion.Location = new System.Drawing.Point(432, 237);
            this.tbxDescripcion.MaxLength = 20;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(317, 26);
            this.tbxDescripcion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(432, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripción";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNombre.Location = new System.Drawing.Point(49, 237);
            this.tbxNombre.MaxLength = 20;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(317, 26);
            this.tbxNombre.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(49, 207);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(241, 28);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Nombre del insumo";
            // 
            // tbxReferencia
            // 
            this.tbxReferencia.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxReferencia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxReferencia.Location = new System.Drawing.Point(49, 146);
            this.tbxReferencia.MaxLength = 15;
            this.tbxReferencia.Name = "tbxReferencia";
            this.tbxReferencia.Size = new System.Drawing.Size(317, 26);
            this.tbxReferencia.TabIndex = 2;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReferencia.Location = new System.Drawing.Point(49, 116);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(137, 28);
            this.lblReferencia.TabIndex = 12;
            this.lblReferencia.Text = "Referencia";
            // 
            // Insumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insumo";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqued)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TextBox tbxBarrabusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgBusqued;
    }
}
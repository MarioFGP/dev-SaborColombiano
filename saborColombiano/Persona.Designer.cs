
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class Persona
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
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.tbxIdentificacion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.imgBusqued = new System.Windows.Forms.PictureBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.tbxSueldo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqued)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 55);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(171, 28);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // tbxIdentificacion
            // 
            this.tbxIdentificacion.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxIdentificacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxIdentificacion.Location = new System.Drawing.Point(12, 92);
            this.tbxIdentificacion.MaxLength = 20;
            this.tbxIdentificacion.Name = "tbxIdentificacion";
            this.tbxIdentificacion.Size = new System.Drawing.Size(317, 26);
            this.tbxIdentificacion.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 143);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 28);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre ";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNombre.Location = new System.Drawing.Point(12, 180);
            this.tbxNombre.MaxLength = 30;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(317, 26);
            this.tbxNombre.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(12, 228);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(109, 28);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Telefono";
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTelefono.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxTelefono.Location = new System.Drawing.Point(12, 265);
            this.tbxTelefono.MaxLength = 10;
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(317, 26);
            this.tbxTelefono.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.Location = new System.Drawing.Point(12, 312);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(92, 28);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCorreo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCorreo.Location = new System.Drawing.Point(12, 349);
            this.tbxCorreo.MaxLength = 30;
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(317, 26);
            this.tbxCorreo.TabIndex = 4;
            // 
            // cmbPersona
            // 
            this.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersona.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Items.AddRange(new object[] {
            "Empleado",
            "Proveedor"});
            this.cmbPersona.Location = new System.Drawing.Point(451, 89);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(171, 28);
            this.cmbPersona.TabIndex = 5;
            this.cmbPersona.SelectedIndexChanged += new System.EventHandler(this.cmbPersona_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(451, 143);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(150, 28);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescripcion.Enabled = false;
            this.tbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescripcion.Location = new System.Drawing.Point(451, 180);
            this.tbxDescripcion.MaxLength = 50;
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(317, 111);
            this.tbxDescripcion.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(503, 429);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 49);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar persona";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(287, 429);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 49);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar persona";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(90, 429);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 49);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar persona";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoPersona.Location = new System.Drawing.Point(451, 55);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(199, 28);
            this.lblTipoPersona.TabIndex = 0;
            this.lblTipoPersona.Text = "Tipo de persona";
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(12, 8);
            this.tbxBarrabusqueda.MaxLength = 50;
            this.tbxBarrabusqueda.Name = "tbxBarrabusqueda";
            this.tbxBarrabusqueda.PlaceholderText = "Busque por nombre o referencia";
            this.tbxBarrabusqueda.Size = new System.Drawing.Size(292, 24);
            this.tbxBarrabusqueda.TabIndex = 24;
            // 
            // imgBusqued
            // 
            this.imgBusqued.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.imgBusqued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBusqued.Enabled = false;
            this.imgBusqued.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqued.Location = new System.Drawing.Point(308, 8);
            this.imgBusqued.Name = "imgBusqued";
            this.imgBusqued.Size = new System.Drawing.Size(39, 24);
            this.imgBusqued.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqued.TabIndex = 26;
            this.imgBusqued.TabStop = false;
            this.imgBusqued.Visible = false;
            this.imgBusqued.Click += new System.EventHandler(this.imgBusqued_Click_1);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSueldo.Location = new System.Drawing.Point(451, 312);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(90, 28);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo";
            // 
            // tbxSueldo
            // 
            this.tbxSueldo.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSueldo.Enabled = false;
            this.tbxSueldo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSueldo.Location = new System.Drawing.Point(451, 349);
            this.tbxSueldo.MaxLength = 30;
            this.tbxSueldo.Name = "tbxSueldo";
            this.tbxSueldo.Size = new System.Drawing.Size(317, 26);
            this.tbxSueldo.TabIndex = 4;
            this.tbxSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSueldo_KeyPress);
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.imgBusqued);
            this.Controls.Add(this.tbxBarrabusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbPersona);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbxSueldo);
            this.Controls.Add(this.tbxCorreo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxIdentificacion);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.lblIdentificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Persona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Persona";
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqued)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox tbxIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.TextBox tbxBarrabusqueda;
        private System.Windows.Forms.PictureBox imgBusqued;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox tbxSueldo;
    }
}
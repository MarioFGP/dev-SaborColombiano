
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class ComprarInsumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTablaInsumo = new System.Windows.Forms.Panel();
            this.TablaInsumo = new System.Windows.Forms.DataGridView();
            this.imgBusqueda = new System.Windows.Forms.PictureBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.btnUsar = new System.Windows.Forms.Button();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTablaInsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTablaInsumo
            // 
            this.pnlTablaInsumo.Controls.Add(this.TablaInsumo);
            this.pnlTablaInsumo.Location = new System.Drawing.Point(12, 42);
            this.pnlTablaInsumo.Name = "pnlTablaInsumo";
            this.pnlTablaInsumo.Size = new System.Drawing.Size(600, 454);
            this.pnlTablaInsumo.TabIndex = 0;
            // 
            // TablaInsumo
            // 
            this.TablaInsumo.AllowUserToAddRows = false;
            this.TablaInsumo.AllowUserToResizeRows = false;
            this.TablaInsumo.BackgroundColor = System.Drawing.Color.White;
            this.TablaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaInsumo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaInsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaInsumo.ColumnHeadersHeight = 30;
            this.TablaInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Nombre,
            this.PrecioUnidad,
            this.Stock,
            this.Descripcion});
            this.TablaInsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaInsumo.EnableHeadersVisualStyles = false;
            this.TablaInsumo.Location = new System.Drawing.Point(0, 0);
            this.TablaInsumo.MultiSelect = false;
            this.TablaInsumo.Name = "TablaInsumo";
            this.TablaInsumo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TablaInsumo.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablaInsumo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaInsumo.RowTemplate.Height = 25;
            this.TablaInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaInsumo.Size = new System.Drawing.Size(600, 454);
            this.TablaInsumo.TabIndex = 1;
            this.TablaInsumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaInsumo_CellContentClick);
            // 
            // imgBusqueda
            // 
            this.imgBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.imgBusqueda.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqueda.Location = new System.Drawing.Point(298, 12);
            this.imgBusqueda.Name = "imgBusqueda";
            this.imgBusqueda.Size = new System.Drawing.Size(39, 24);
            this.imgBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqueda.TabIndex = 17;
            this.imgBusqueda.TabStop = false;
            // 
            // numCantidad
            // 
            this.numCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCantidad.Location = new System.Drawing.Point(690, 92);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(49, 22);
            this.numCantidad.TabIndex = 16;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(672, 68);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 21);
            this.lblCantidad.TabIndex = 15;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerLista.ForeColor = System.Drawing.Color.White;
            this.btnVerLista.Location = new System.Drawing.Point(660, 285);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(116, 33);
            this.btnVerLista.TabIndex = 12;
            this.btnVerLista.Text = "Ver lista";
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(660, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 33);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(660, 146);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 33);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(12, 12);
            this.tbxBarrabusqueda.MaxLength = 10;
            this.tbxBarrabusqueda.Name = "tbxBarrabusqueda";
            this.tbxBarrabusqueda.PlaceholderText = "Busque por nombre o referencia";
            this.tbxBarrabusqueda.Size = new System.Drawing.Size(292, 24);
            this.tbxBarrabusqueda.TabIndex = 11;
            this.tbxBarrabusqueda.TextChanged += new System.EventHandler(this.tbxBarrabusqueda_TextChanged);
            // 
            // btnUsar
            // 
            this.btnUsar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnUsar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsar.ForeColor = System.Drawing.Color.White;
            this.btnUsar.Location = new System.Drawing.Point(660, 241);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(116, 33);
            this.btnUsar.TabIndex = 13;
            this.btnUsar.Text = "Usar";
            this.btnUsar.UseVisualStyleBackColor = false;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrecioUnidad
            // 
            this.PrecioUnidad.HeaderText = "Precio";
            this.PrecioUnidad.MaxInputLength = 10;
            this.PrecioUnidad.Name = "PrecioUnidad";
            this.PrecioUnidad.ReadOnly = true;
            this.PrecioUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "En Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 204;
            // 
            // ComprarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.imgBusqueda);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxBarrabusqueda);
            this.Controls.Add(this.pnlTablaInsumo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ComprarInsumo";
            this.Load += new System.EventHandler(this.ComprarInsumo_Load);
            this.pnlTablaInsumo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTablaInsumo;
        private System.Windows.Forms.DataGridView TablaInsumo;
        private System.Windows.Forms.PictureBox imgBusqueda;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxBarrabusqueda;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}
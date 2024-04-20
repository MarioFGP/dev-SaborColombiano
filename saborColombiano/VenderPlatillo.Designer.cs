
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class VenderPlatillo
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
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.TablaPlatillo = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.imgBusqueda = new System.Windows.Forms.PictureBox();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTabla
            // 
            this.pnlTabla.AutoScroll = true;
            this.pnlTabla.Controls.Add(this.TablaPlatillo);
            this.pnlTabla.Location = new System.Drawing.Point(23, 68);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(569, 428);
            this.pnlTabla.TabIndex = 0;
            this.pnlTabla.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTabla_Paint);
            // 
            // TablaPlatillo
            // 
            this.TablaPlatillo.AllowUserToAddRows = false;
            this.TablaPlatillo.AllowUserToResizeRows = false;
            this.TablaPlatillo.BackgroundColor = System.Drawing.Color.White;
            this.TablaPlatillo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaPlatillo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPlatillo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaPlatillo.ColumnHeadersHeight = 30;
            this.TablaPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaPlatillo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Descripcion,
            this.Precio,
            this.dataGridViewTextBoxColumn1});
            this.TablaPlatillo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaPlatillo.EnableHeadersVisualStyles = false;
            this.TablaPlatillo.Location = new System.Drawing.Point(0, 0);
            this.TablaPlatillo.MultiSelect = false;
            this.TablaPlatillo.Name = "TablaPlatillo";
            this.TablaPlatillo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TablaPlatillo.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablaPlatillo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaPlatillo.RowTemplate.Height = 25;
            this.TablaPlatillo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPlatillo.Size = new System.Drawing.Size(569, 428);
            this.TablaPlatillo.TabIndex = 0;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Disponibilidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 164;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(660, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(660, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerLista.ForeColor = System.Drawing.Color.White;
            this.btnVerLista.Location = new System.Drawing.Point(660, 247);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(116, 33);
            this.btnVerLista.TabIndex = 2;
            this.btnVerLista.Text = "Ver lista";
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(672, 68);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(87, 21);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCantidad.Location = new System.Drawing.Point(690, 92);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(49, 22);
            this.numCantidad.TabIndex = 4;
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(23, 38);
            this.tbxBarrabusqueda.MaxLength = 10;
            this.tbxBarrabusqueda.Name = "tbxBarrabusqueda";
            this.tbxBarrabusqueda.PlaceholderText = "Busque por referencia o descripcion";
            this.tbxBarrabusqueda.Size = new System.Drawing.Size(292, 24);
            this.tbxBarrabusqueda.TabIndex = 1;
            this.tbxBarrabusqueda.TextChanged += new System.EventHandler(this.tbxBarrabusqueda_TextChanged);
            // 
            // imgBusqueda
            // 
            this.imgBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.imgBusqueda.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqueda.Location = new System.Drawing.Point(317, 38);
            this.imgBusqueda.Name = "imgBusqueda";
            this.imgBusqueda.Size = new System.Drawing.Size(39, 24);
            this.imgBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqueda.TabIndex = 10;
            this.imgBusqueda.TabStop = false;
            this.imgBusqueda.Click += new System.EventHandler(this.imgBusqueda_Click);
            // 
            // VenderPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.imgBusqueda);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxBarrabusqueda);
            this.Controls.Add(this.pnlTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenderPlatillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VenderPlatillo";
            this.Load += new System.EventHandler(this.VenderPlatillo_Load);
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView TablaPlatillo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox tbxBarrabusqueda;
        private System.Windows.Forms.PictureBox imgBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class Personas
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
            this.pnlTablaPersona = new System.Windows.Forms.Panel();
            this.TablaPersona = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgBusqueda = new System.Windows.Forms.PictureBox();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.pnlTablaPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTablaPersona
            // 
            this.pnlTablaPersona.Controls.Add(this.TablaPersona);
            this.pnlTablaPersona.Location = new System.Drawing.Point(3, 44);
            this.pnlTablaPersona.Name = "pnlTablaPersona";
            this.pnlTablaPersona.Size = new System.Drawing.Size(820, 403);
            this.pnlTablaPersona.TabIndex = 0;
            // 
            // TablaPersona
            // 
            this.TablaPersona.AllowUserToAddRows = false;
            this.TablaPersona.AllowUserToResizeRows = false;
            this.TablaPersona.BackgroundColor = System.Drawing.Color.White;
            this.TablaPersona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaPersona.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaPersona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaPersona.ColumnHeadersHeight = 30;
            this.TablaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Telefono,
            this.Correo,
            this.TipoPersona,
            this.Descripcion,
            this.Estado});
            this.TablaPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaPersona.EnableHeadersVisualStyles = false;
            this.TablaPersona.Location = new System.Drawing.Point(0, 0);
            this.TablaPersona.MultiSelect = false;
            this.TablaPersona.Name = "TablaPersona";
            this.TablaPersona.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TablaPersona.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablaPersona.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaPersona.RowTemplate.Height = 25;
            this.TablaPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPersona.Size = new System.Drawing.Size(820, 403);
            this.TablaPersona.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 15;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MaxInputLength = 30;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MaxInputLength = 10;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MaxInputLength = 30;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TipoPersona
            // 
            this.TipoPersona.HeaderText = "Persona";
            this.TipoPersona.MaxInputLength = 12;
            this.TipoPersona.Name = "TipoPersona";
            this.TipoPersona.ReadOnly = true;
            this.TipoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MaxInputLength = 50;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 204;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MaxInputLength = 10;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imgBusqueda
            // 
            this.imgBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.imgBusqueda.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqueda.Location = new System.Drawing.Point(296, 12);
            this.imgBusqueda.Name = "imgBusqueda";
            this.imgBusqueda.Size = new System.Drawing.Size(39, 24);
            this.imgBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqueda.TabIndex = 19;
            this.imgBusqueda.TabStop = false;
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(12, 12);
            this.tbxBarrabusqueda.MaxLength = 50;
            this.tbxBarrabusqueda.Name = "tbxBarrabusqueda";
            this.tbxBarrabusqueda.PlaceholderText = "Busque por nombre o referencia";
            this.tbxBarrabusqueda.Size = new System.Drawing.Size(292, 24);
            this.tbxBarrabusqueda.TabIndex = 18;
            this.tbxBarrabusqueda.TextChanged += new System.EventHandler(this.tbxBarrabusqueda_TextChanged);
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVerFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFacturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerFacturas.ForeColor = System.Drawing.Color.White;
            this.btnVerFacturas.Location = new System.Drawing.Point(692, 463);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(116, 33);
            this.btnVerFacturas.TabIndex = 20;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = false;
            this.btnVerFacturas.Click += new System.EventHandler(this.btnVerFacturas_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Empleado",
            "Proveedor"});
            this.cmbFiltro.Location = new System.Drawing.Point(679, 14);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(129, 25);
            this.cmbFiltro.TabIndex = 21;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltro.Location = new System.Drawing.Point(627, 16);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 20);
            this.lblFiltro.TabIndex = 22;
            this.lblFiltro.Text = "Filtro:";
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLiquidar.ForeColor = System.Drawing.Color.White;
            this.btnLiquidar.Location = new System.Drawing.Point(570, 463);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(116, 33);
            this.btnLiquidar.TabIndex = 20;
            this.btnLiquidar.Text = "Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = false;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnVerFacturas);
            this.Controls.Add(this.imgBusqueda);
            this.Controls.Add(this.tbxBarrabusqueda);
            this.Controls.Add(this.pnlTablaPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.Personas_Load);
            this.pnlTablaPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTablaPersona;
        private System.Windows.Forms.DataGridView TablaPersona;
        private System.Windows.Forms.PictureBox imgBusqueda;
        private System.Windows.Forms.TextBox tbxBarrabusqueda;
        private System.Windows.Forms.Button btnVerFacturas;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnLiquidar;
    }
}
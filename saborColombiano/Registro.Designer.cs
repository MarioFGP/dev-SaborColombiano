
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class Registro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTablaRegistros = new System.Windows.Forms.Panel();
            this.TablaFacturas = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVistaDetallada = new System.Windows.Forms.Button();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.imgBusqueda = new System.Windows.Forms.PictureBox();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlTablaRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTablaRegistros
            // 
            this.pnlTablaRegistros.AutoScroll = true;
            this.pnlTablaRegistros.AutoSize = true;
            this.pnlTablaRegistros.Controls.Add(this.TablaFacturas);
            this.pnlTablaRegistros.Location = new System.Drawing.Point(0, 42);
            this.pnlTablaRegistros.Name = "pnlTablaRegistros";
            this.pnlTablaRegistros.Size = new System.Drawing.Size(711, 427);
            this.pnlTablaRegistros.TabIndex = 0;
            // 
            // TablaFacturas
            // 
            this.TablaFacturas.AllowUserToAddRows = false;
            this.TablaFacturas.AllowUserToResizeRows = false;
            this.TablaFacturas.BackgroundColor = System.Drawing.Color.White;
            this.TablaFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaFacturas.ColumnHeadersHeight = 30;
            this.TablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TablaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Total,
            this.Fecha,
            this.Empleado,
            this.Concepto,
            this.Estado});
            this.TablaFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaFacturas.EnableHeadersVisualStyles = false;
            this.TablaFacturas.Location = new System.Drawing.Point(0, 0);
            this.TablaFacturas.MultiSelect = false;
            this.TablaFacturas.Name = "TablaFacturas";
            this.TablaFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TablaFacturas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TablaFacturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaFacturas.RowTemplate.Height = 25;
            this.TablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaFacturas.Size = new System.Drawing.Size(711, 427);
            this.TablaFacturas.TabIndex = 2;
            this.TablaFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaFacturas_CellContentClick);
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.MaxInputLength = 12;
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MaxInputLength = 10;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 150;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Concepto.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnVistaDetallada
            // 
            this.btnVistaDetallada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVistaDetallada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVistaDetallada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVistaDetallada.ForeColor = System.Drawing.Color.White;
            this.btnVistaDetallada.Location = new System.Drawing.Point(736, 184);
            this.btnVistaDetallada.Name = "btnVistaDetallada";
            this.btnVistaDetallada.Size = new System.Drawing.Size(116, 33);
            this.btnVistaDetallada.TabIndex = 3;
            this.btnVistaDetallada.Text = "Ver Detalle";
            this.btnVistaDetallada.UseVisualStyleBackColor = false;
            this.btnVistaDetallada.Click += new System.EventHandler(this.btnVistaDetallada_Click);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLiquidar.ForeColor = System.Drawing.Color.White;
            this.btnLiquidar.Location = new System.Drawing.Point(736, 129);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(116, 33);
            this.btnLiquidar.TabIndex = 4;
            this.btnLiquidar.Text = "Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = false;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // imgBusqueda
            // 
            this.imgBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.imgBusqueda.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqueda.Location = new System.Drawing.Point(296, 12);
            this.imgBusqueda.Name = "imgBusqueda";
            this.imgBusqueda.Size = new System.Drawing.Size(39, 24);
            this.imgBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqueda.TabIndex = 12;
            this.imgBusqueda.TabStop = false;
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(2, 12);
            this.tbxBarrabusqueda.MaxLength = 10;
            this.tbxBarrabusqueda.Name = "tbxBarrabusqueda";
            this.tbxBarrabusqueda.PlaceholderText = "Busque por ID o Factura";
            this.tbxBarrabusqueda.Size = new System.Drawing.Size(292, 24);
            this.tbxBarrabusqueda.TabIndex = 11;
            this.tbxBarrabusqueda.TextChanged += new System.EventHandler(this.tbxBarrabusqueda_TextChanged);
            // 
            // dateFinal
            // 
            this.dateFinal.Checked = false;
            this.dateFinal.CustomFormat = "MM-yyyy";
            this.dateFinal.Location = new System.Drawing.Point(708, 13);
            this.dateFinal.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(150, 23);
            this.dateFinal.TabIndex = 13;
            this.dateFinal.ValueChanged += new System.EventHandler(this.dateFinal_ValueChanged);
            // 
            // dateInicio
            // 
            this.dateInicio.CustomFormat = "MM/yyyy";
            this.dateInicio.Location = new System.Drawing.Point(493, 12);
            this.dateInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(150, 23);
            this.dateInicio.TabIndex = 13;
            this.dateInicio.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateInicio.ValueChanged += new System.EventHandler(this.dateInicio_ValueChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinal.Location = new System.Drawing.Point(663, 14);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(45, 20);
            this.lblFinal.TabIndex = 14;
            this.lblFinal.Text = "Final:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.Location = new System.Drawing.Point(440, 13);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(53, 20);
            this.lblInicio.TabIndex = 15;
            this.lblInicio.Text = "Inicio:";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.cmbFiltro);
            this.pnlPrincipal.Controls.Add(this.btnNuevaFactura);
            this.pnlPrincipal.Controls.Add(this.btnPdf);
            this.pnlPrincipal.Controls.Add(this.btnFiltrar);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(886, 475);
            this.pnlPrincipal.TabIndex = 16;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos"});
            this.cmbFiltro.Location = new System.Drawing.Point(736, 42);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(116, 25);
            this.cmbFiltro.TabIndex = 22;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.White;
            this.btnNuevaFactura.Location = new System.Drawing.Point(736, 290);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(116, 33);
            this.btnNuevaFactura.TabIndex = 4;
            this.btnNuevaFactura.Text = "Nueva";
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(736, 238);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(116, 33);
            this.btnPdf.TabIndex = 4;
            this.btnPdf.Text = "Generar PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(370, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(71, 26);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 475);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.dateFinal);
            this.Controls.Add(this.imgBusqueda);
            this.Controls.Add(this.tbxBarrabusqueda);
            this.Controls.Add(this.btnVistaDetallada);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.pnlTablaRegistros);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.pnlTablaRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTablaRegistros;
        private System.Windows.Forms.DataGridView TablaFacturas;
        private System.Windows.Forms.Button btnVistaDetallada;
        private System.Windows.Forms.Panel pnlPrincipal;
        public System.Windows.Forms.Button btnLiquidar;
        public System.Windows.Forms.PictureBox imgBusqueda;
        public System.Windows.Forms.TextBox tbxBarrabusqueda;
        public System.Windows.Forms.DateTimePicker dateFinal;
        public System.Windows.Forms.DateTimePicker dateInicio;
        public System.Windows.Forms.Label lblFinal;
        public System.Windows.Forms.Label lblInicio;
        public System.Windows.Forms.Button btnPdf;
        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Button btnNuevaFactura;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}

namespace saborColombiano
{
    partial class DetalleLista
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleLista));
            this.lblSaborColombiano = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlMedio = new System.Windows.Forms.Panel();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblNumeroID = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblNomina = new System.Windows.Forms.Label();
            this.lblPagoNomina = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.pnlMedio.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaborColombiano
            // 
            this.lblSaborColombiano.AutoSize = true;
            this.lblSaborColombiano.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaborColombiano.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaborColombiano.Location = new System.Drawing.Point(27, 38);
            this.lblSaborColombiano.Name = "lblSaborColombiano";
            this.lblSaborColombiano.Size = new System.Drawing.Size(138, 25);
            this.lblSaborColombiano.TabIndex = 0;
            this.lblSaborColombiano.Text = "Vista previa ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::saborColombiano.Properties.Resources.saborColombiano;
            this.pictureBox1.Location = new System.Drawing.Point(246, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.lblSaborColombiano);
            this.pnlSuperior.Location = new System.Drawing.Point(12, 12);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(422, 105);
            this.pnlSuperior.TabIndex = 2;
            // 
            // pnlMedio
            // 
            this.pnlMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMedio.Controls.Add(this.cbxNombre);
            this.pnlMedio.Controls.Add(this.lblCliente);
            this.pnlMedio.Controls.Add(this.lblPersona);
            this.pnlMedio.Controls.Add(this.lblNumeroID);
            this.pnlMedio.Controls.Add(this.lblIdentificacion);
            this.pnlMedio.Controls.Add(this.lblTipoPersona);
            this.pnlMedio.Controls.Add(this.lblNumeroFactura);
            this.pnlMedio.Controls.Add(this.lblDate);
            this.pnlMedio.Controls.Add(this.lblFecha);
            this.pnlMedio.Controls.Add(this.lblFactura);
            this.pnlMedio.Location = new System.Drawing.Point(12, 123);
            this.pnlMedio.Name = "pnlMedio";
            this.pnlMedio.Size = new System.Drawing.Size(422, 100);
            this.pnlMedio.TabIndex = 3;
            // 
            // cbxNombre
            // 
            this.cbxNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(303, 38);
            this.cbxNombre.MaxLength = 15;
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(114, 23);
            this.cbxNombre.Sorted = true;
            this.cbxNombre.TabIndex = 1;
            this.cbxNombre.SelectedIndexChanged += new System.EventHandler(this.cbxNombre_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(246, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 15);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Nombre: ";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersona.Location = new System.Drawing.Point(130, 40);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(102, 17);
            this.lblPersona.TabIndex = 2;
            this.lblPersona.Text = "Juridica/cliente";
            // 
            // lblNumeroID
            // 
            this.lblNumeroID.AutoSize = true;
            this.lblNumeroID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroID.Location = new System.Drawing.Point(130, 67);
            this.lblNumeroID.Name = "lblNumeroID";
            this.lblNumeroID.Size = new System.Drawing.Size(98, 17);
            this.lblNumeroID.TabIndex = 2;
            this.lblNumeroID.Text = "##########";
            this.lblNumeroID.TextChanged += new System.EventHandler(this.lblNumeroID_TextChanged);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacion.Location = new System.Drawing.Point(16, 67);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(97, 17);
            this.lblIdentificacion.TabIndex = 2;
            this.lblIdentificacion.Text = "Identificacion: ";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoPersona.Location = new System.Drawing.Point(16, 40);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(108, 17);
            this.lblTipoPersona.TabIndex = 2;
            this.lblTipoPersona.Text = "Tipo de persona: ";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroFactura.Location = new System.Drawing.Point(74, 15);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(90, 17);
            this.lblNumeroFactura.TabIndex = 1;
            this.lblNumeroFactura.Text = "# facturacion";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(303, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "xx/xx/xxxx";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(246, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFactura.Location = new System.Drawing.Point(16, 15);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(60, 17);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura: ";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.lblNomina);
            this.pnlPrincipal.Controls.Add(this.lblPagoNomina);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 229);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(422, 266);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomina.Location = new System.Drawing.Point(268, 20);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(139, 21);
            this.lblNomina.TabIndex = 0;
            this.lblNomina.Text = "Pago de nomina";
            this.lblNomina.Visible = false;
            // 
            // lblPagoNomina
            // 
            this.lblPagoNomina.AutoSize = true;
            this.lblPagoNomina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPagoNomina.Location = new System.Drawing.Point(16, 20);
            this.lblPagoNomina.Name = "lblPagoNomina";
            this.lblPagoNomina.Size = new System.Drawing.Size(140, 19);
            this.lblPagoNomina.TabIndex = 0;
            this.lblPagoNomina.Text = "Pago de nomina";
            this.lblPagoNomina.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(38, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 34);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFacturar.Location = new System.Drawing.Point(290, 4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(92, 34);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnPDF);
            this.pnlInferior.Controls.Add(this.btnFacturar);
            this.pnlInferior.Controls.Add(this.btnVolver);
            this.pnlInferior.Location = new System.Drawing.Point(12, 544);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(419, 48);
            this.pnlInferior.TabIndex = 5;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnPDF.Enabled = false;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPDF.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPDF.Location = new System.Drawing.Point(168, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(92, 34);
            this.btnPDF.TabIndex = 3;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(316, 498);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: ";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(365, 498);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(43, 17);
            this.Total.TabIndex = 7;
            this.Total.Text = "$$$$$";
            // 
            // DetalleLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 640);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlMedio);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleLista";
            this.Load += new System.EventHandler(this.DetalleLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlMedio.ResumeLayout(false);
            this.pnlMedio.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlMedio;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlInferior;
        public System.Windows.Forms.Label lblPersona;
        public System.Windows.Forms.Label lblNumeroID;
        public System.Windows.Forms.Label lblNumeroFactura;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblSaborColombiano;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label Total;
        public System.Windows.Forms.ComboBox cbxNombre;
        public System.Windows.Forms.Button btnFacturar;
        public System.Windows.Forms.Button btnPDF;
        public System.Windows.Forms.Label lblNomina;
        public System.Windows.Forms.Label lblPagoNomina;
    }
}
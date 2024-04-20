
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class Platillo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Platillo));
            this.lblReferencia = new System.Windows.Forms.Label();
            this.tbxReferencia = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbxBarrabusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.imgBusqueda = new System.Windows.Forms.PictureBox();
            this.imgNota = new System.Windows.Forms.PictureBox();
            this.tbxNota = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReferencia.Location = new System.Drawing.Point(60, 60);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(137, 28);
            this.lblReferencia.TabIndex = 0;
            this.lblReferencia.Text = "Referencia";
            // 
            // tbxReferencia
            // 
            this.tbxReferencia.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxReferencia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxReferencia.Location = new System.Drawing.Point(60, 93);
            this.tbxReferencia.Name = "tbxReferencia";
            this.tbxReferencia.Size = new System.Drawing.Size(317, 26);
            this.tbxReferencia.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(60, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(84, 28);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPrecio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPrecio.Location = new System.Drawing.Point(60, 182);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(317, 26);
            this.tbxPrecio.TabIndex = 3;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(60, 246);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(150, 28);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescripcion.Location = new System.Drawing.Point(60, 279);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(317, 26);
            this.tbxDescripcion.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(108, 380);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 49);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar producto";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(316, 380);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 49);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar producto";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbxBarrabusqueda
            // 
            this.tbxBarrabusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.tbxBarrabusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBarrabusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBarrabusqueda.Location = new System.Drawing.Point(60, 5);
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
            this.btnEliminar.Location = new System.Drawing.Point(533, 380);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 49);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // imgBusqueda
            // 
            this.imgBusqueda.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.imgBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBusqueda.Image = global::saborColombiano.Properties.Resources.busqueda;
            this.imgBusqueda.Location = new System.Drawing.Point(353, 5);
            this.imgBusqueda.Name = "imgBusqueda";
            this.imgBusqueda.Size = new System.Drawing.Size(39, 24);
            this.imgBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBusqueda.TabIndex = 9;
            this.imgBusqueda.TabStop = false;
            this.imgBusqueda.Click += new System.EventHandler(this.imgBusqueda_Click);
            // 
            // imgNota
            // 
            this.imgNota.Image = global::saborColombiano.Properties.Resources.aviso;
            this.imgNota.Location = new System.Drawing.Point(469, 60);
            this.imgNota.Name = "imgNota";
            this.imgNota.Size = new System.Drawing.Size(15, 15);
            this.imgNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNota.TabIndex = 10;
            this.imgNota.TabStop = false;
            // 
            // tbxNota
            // 
            this.tbxNota.BackColor = System.Drawing.Color.White;
            this.tbxNota.Enabled = false;
            this.tbxNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNota.Location = new System.Drawing.Point(490, 60);
            this.tbxNota.Multiline = true;
            this.tbxNota.Name = "tbxNota";
            this.tbxNota.ReadOnly = true;
            this.tbxNota.Size = new System.Drawing.Size(305, 253);
            this.tbxNota.TabIndex = 11;
            this.tbxNota.Text = resources.GetString("tbxNota.Text");
            this.tbxNota.TextChanged += new System.EventHandler(this.tbxNota_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(756, -315);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(247, 228);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.tbxNota_TextChanged);
            // 
            // Platillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.imgBusqueda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbxNota);
            this.Controls.Add(this.imgNota);
            this.Controls.Add(this.tbxBarrabusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbxReferencia);
            this.Controls.Add(this.lblReferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Platillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Platillos";
            this.Load += new System.EventHandler(this.Platillo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox tbxReferencia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbxBarrabusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox imgBusqueda;
        private System.Windows.Forms.PictureBox imgNota;
        private System.Windows.Forms.TextBox tbxNota;
        private System.Windows.Forms.TextBox textBox1;
    }
}
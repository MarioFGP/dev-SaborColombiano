
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class InicioSesion
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.tbxUsario = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.tbxContasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsario = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.pnlBorde);
            this.pnlPrincipal.Controls.Add(this.Cerrarbtn);
            this.pnlPrincipal.Controls.Add(this.btnMinimizar);
            this.pnlPrincipal.Controls.Add(this.imgLogo);
            this.pnlPrincipal.Controls.Add(this.tbxUsario);
            this.pnlPrincipal.Controls.Add(this.btnEntrar);
            this.pnlPrincipal.Controls.Add(this.tbxContasena);
            this.pnlPrincipal.Controls.Add(this.lblContrasena);
            this.pnlPrincipal.Controls.Add(this.lblUsario);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.ForeColor = System.Drawing.Color.White;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(440, 580);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorde.Location = new System.Drawing.Point(0, 0);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(375, 30);
            this.pnlBorde.TabIndex = 11;
            this.pnlBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorde_MouseDown);
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.BackColor = System.Drawing.Color.White;
            this.Cerrarbtn.FlatAppearance.BorderSize = 0;
            this.Cerrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrarbtn.Image = global::saborColombiano.Properties.Resources.icons8_multiplicar_30;
            this.Cerrarbtn.Location = new System.Drawing.Point(408, 0);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(32, 32);
            this.Cerrarbtn.TabIndex = 9;
            this.Cerrarbtn.UseVisualStyleBackColor = false;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::saborColombiano.Properties.Resources.icons8_menos_30;
            this.btnMinimizar.Location = new System.Drawing.Point(375, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::saborColombiano.Properties.Resources.saborColombiano;
            this.imgLogo.Location = new System.Drawing.Point(24, 38);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(381, 180);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 8;
            this.imgLogo.TabStop = false;
            // 
            // tbxUsario
            // 
            this.tbxUsario.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxUsario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUsario.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUsario.Location = new System.Drawing.Point(59, 275);
            this.tbxUsario.MaxLength = 40;
            this.tbxUsario.Name = "tbxUsario";
            this.tbxUsario.Size = new System.Drawing.Size(322, 24);
            this.tbxUsario.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntrar.Location = new System.Drawing.Point(162, 400);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(116, 35);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Iniciar sesion";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // tbxContasena
            // 
            this.tbxContasena.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxContasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxContasena.ForeColor = System.Drawing.Color.DimGray;
            this.tbxContasena.Location = new System.Drawing.Point(59, 355);
            this.tbxContasena.MaxLength = 40;
            this.tbxContasena.Name = "tbxContasena";
            this.tbxContasena.PasswordChar = '*';
            this.tbxContasena.Size = new System.Drawing.Size(322, 24);
            this.tbxContasena.TabIndex = 2;
            this.tbxContasena.UseSystemPasswordChar = true;
            this.tbxContasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxContasena_KeyPress);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblContrasena.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblContrasena.Location = new System.Drawing.Point(58, 319);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(152, 30);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsario
            // 
            this.lblUsario.AutoSize = true;
            this.lblUsario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsario.ForeColor = System.Drawing.Color.Black;
            this.lblUsario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsario.Location = new System.Drawing.Point(58, 239);
            this.lblUsario.Name = "lblUsario";
            this.lblUsario.Size = new System.Drawing.Size(241, 30);
            this.lblUsario.TabIndex = 4;
            this.lblUsario.Text = "Nombre de usuario";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsario;
        private System.Windows.Forms.PictureBox imgLogo;
        public System.Windows.Forms.Button btnEntrar;
        public System.Windows.Forms.TextBox tbxContasena;
        public System.Windows.Forms.TextBox tbxUsario;
        private System.Windows.Forms.Button Cerrarbtn;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel pnlBorde;
    }
}
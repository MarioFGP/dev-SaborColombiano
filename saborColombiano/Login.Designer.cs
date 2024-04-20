namespace saborColombiano
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.chbxMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.tbxContasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.tbxUsario = new System.Windows.Forms.TextBox();
            this.lblUsario = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            resources.ApplyResources(this.pnlPrincipal, "pnlPrincipal");
            this.pnlPrincipal.Controls.Add(this.btnEntrar);
            this.pnlPrincipal.Controls.Add(this.chbxMostrarContrasena);
            this.pnlPrincipal.Controls.Add(this.tbxContasena);
            this.pnlPrincipal.Controls.Add(this.lblContrasena);
            this.pnlPrincipal.Controls.Add(this.tbxUsario);
            this.pnlPrincipal.Controls.Add(this.lblUsario);
            this.pnlPrincipal.Controls.Add(this.lblIniciarSesion);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(69)))), ((int)(((byte)(46)))));
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // chbxMostrarContrasena
            // 
            resources.ApplyResources(this.chbxMostrarContrasena, "chbxMostrarContrasena");
            this.chbxMostrarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbxMostrarContrasena.ForeColor = System.Drawing.Color.Black;
            this.chbxMostrarContrasena.Name = "chbxMostrarContrasena";
            this.chbxMostrarContrasena.UseVisualStyleBackColor = true;
            // 
            // tbxContasena
            // 
            resources.ApplyResources(this.tbxContasena, "tbxContasena");
            this.tbxContasena.BackColor = System.Drawing.Color.Honeydew;
            this.tbxContasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContasena.Name = "tbxContasena";
            // 
            // lblContrasena
            // 
            resources.ApplyResources(this.lblContrasena, "lblContrasena");
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(69)))), ((int)(((byte)(46)))));
            this.lblContrasena.Name = "lblContrasena";
            // 
            // tbxUsario
            // 
            resources.ApplyResources(this.tbxUsario, "tbxUsario");
            this.tbxUsario.BackColor = System.Drawing.Color.Honeydew;
            this.tbxUsario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsario.Name = "tbxUsario";
            // 
            // lblUsario
            // 
            resources.ApplyResources(this.lblUsario, "lblUsario");
            this.lblUsario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(69)))), ((int)(((byte)(46)))));
            this.lblUsario.Name = "lblUsario";
            // 
            // lblIniciarSesion
            // 
            resources.ApplyResources(this.lblIniciarSesion, "lblIniciarSesion");
            this.lblIniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.pnlPrincipal);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TextBox tbxUsario;
        private System.Windows.Forms.Label lblUsario;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.TextBox tbxContasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.CheckBox chbxMostrarContrasena;
    }
}


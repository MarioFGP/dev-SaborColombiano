
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class MainWindows
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlbtnsInsumo = new System.Windows.Forms.Panel();
            this.btnComprar = new System.Windows.Forms.Button();
            this.bntGestionarInsumo = new System.Windows.Forms.Button();
            this.pnlBtnsPersona = new System.Windows.Forms.Panel();
            this.btnVerPersonas = new System.Windows.Forms.Button();
            this.btnGestionarPersonas = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnInsumo = new System.Windows.Forms.Button();
            this.pnlBtnsPlatillos = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnPlatillos = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav.SuspendLayout();
            this.pnlbtnsInsumo.SuspendLayout();
            this.pnlBtnsPersona.SuspendLayout();
            this.pnlBtnsPlatillos.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.pnlNav.Controls.Add(this.pnlbtnsInsumo);
            this.pnlNav.Controls.Add(this.pnlBtnsPersona);
            this.pnlNav.Controls.Add(this.btnRegistros);
            this.pnlNav.Controls.Add(this.btnProveedor);
            this.pnlNav.Controls.Add(this.btnInsumo);
            this.pnlNav.Controls.Add(this.pnlBtnsPlatillos);
            this.pnlNav.Controls.Add(this.btnCerrar);
            this.pnlNav.Controls.Add(this.btnEstadistica);
            this.pnlNav.Controls.Add(this.btnPlatillos);
            this.pnlNav.Controls.Add(this.pnlUsuario);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(186, 700);
            this.pnlNav.TabIndex = 0;
            // 
            // pnlbtnsInsumo
            // 
            this.pnlbtnsInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            this.pnlbtnsInsumo.Controls.Add(this.btnComprar);
            this.pnlbtnsInsumo.Controls.Add(this.bntGestionarInsumo);
            this.pnlbtnsInsumo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlbtnsInsumo.ForeColor = System.Drawing.Color.White;
            this.pnlbtnsInsumo.Location = new System.Drawing.Point(82, 481);
            this.pnlbtnsInsumo.Name = "pnlbtnsInsumo";
            this.pnlbtnsInsumo.Size = new System.Drawing.Size(186, 100);
            this.pnlbtnsInsumo.TabIndex = 2;
            this.pnlbtnsInsumo.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnComprar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.Location = new System.Drawing.Point(0, 50);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(186, 50);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // bntGestionarInsumo
            // 
            this.bntGestionarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.bntGestionarInsumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntGestionarInsumo.FlatAppearance.BorderSize = 0;
            this.bntGestionarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGestionarInsumo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntGestionarInsumo.ForeColor = System.Drawing.Color.White;
            this.bntGestionarInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGestionarInsumo.Location = new System.Drawing.Point(0, 0);
            this.bntGestionarInsumo.Name = "bntGestionarInsumo";
            this.bntGestionarInsumo.Size = new System.Drawing.Size(186, 50);
            this.bntGestionarInsumo.TabIndex = 1;
            this.bntGestionarInsumo.Text = "Gestionar";
            this.bntGestionarInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGestionarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntGestionarInsumo.UseVisualStyleBackColor = false;
            this.bntGestionarInsumo.Click += new System.EventHandler(this.bntGestionarInsumo_Click);
            // 
            // pnlBtnsPersona
            // 
            this.pnlBtnsPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            this.pnlBtnsPersona.Controls.Add(this.btnVerPersonas);
            this.pnlBtnsPersona.Controls.Add(this.btnGestionarPersonas);
            this.pnlBtnsPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBtnsPersona.Location = new System.Drawing.Point(12, 492);
            this.pnlBtnsPersona.Name = "pnlBtnsPersona";
            this.pnlBtnsPersona.Size = new System.Drawing.Size(186, 100);
            this.pnlBtnsPersona.TabIndex = 1;
            this.pnlBtnsPersona.Visible = false;
            // 
            // btnVerPersonas
            // 
            this.btnVerPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVerPersonas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVerPersonas.FlatAppearance.BorderSize = 0;
            this.btnVerPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPersonas.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerPersonas.ForeColor = System.Drawing.Color.White;
            this.btnVerPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerPersonas.Location = new System.Drawing.Point(0, 50);
            this.btnVerPersonas.Name = "btnVerPersonas";
            this.btnVerPersonas.Size = new System.Drawing.Size(186, 50);
            this.btnVerPersonas.TabIndex = 1;
            this.btnVerPersonas.Text = "Ver Personas";
            this.btnVerPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerPersonas.UseVisualStyleBackColor = false;
            this.btnVerPersonas.Click += new System.EventHandler(this.btnVerPersonas_Click);
            // 
            // btnGestionarPersonas
            // 
            this.btnGestionarPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnGestionarPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarPersonas.FlatAppearance.BorderSize = 0;
            this.btnGestionarPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPersonas.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGestionarPersonas.ForeColor = System.Drawing.Color.White;
            this.btnGestionarPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionarPersonas.Location = new System.Drawing.Point(0, 0);
            this.btnGestionarPersonas.Name = "btnGestionarPersonas";
            this.btnGestionarPersonas.Size = new System.Drawing.Size(186, 50);
            this.btnGestionarPersonas.TabIndex = 1;
            this.btnGestionarPersonas.Text = "Gestionar";
            this.btnGestionarPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionarPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarPersonas.UseVisualStyleBackColor = false;
            this.btnGestionarPersonas.Click += new System.EventHandler(this.btnGestionarPersonas_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistros.ForeColor = System.Drawing.Color.White;
            this.btnRegistros.Location = new System.Drawing.Point(0, 375);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(186, 50);
            this.btnRegistros.TabIndex = 1;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            this.btnRegistros.Leave += new System.EventHandler(this.btnRegistros_Leave);
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Location = new System.Drawing.Point(0, 325);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(186, 50);
            this.btnProveedor.TabIndex = 1;
            this.btnProveedor.Text = "Personas";
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            this.btnProveedor.Leave += new System.EventHandler(this.btnProveedor_Leave);
            // 
            // btnInsumo
            // 
            this.btnInsumo.FlatAppearance.BorderSize = 0;
            this.btnInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsumo.ForeColor = System.Drawing.Color.White;
            this.btnInsumo.Location = new System.Drawing.Point(0, 275);
            this.btnInsumo.Name = "btnInsumo";
            this.btnInsumo.Size = new System.Drawing.Size(186, 50);
            this.btnInsumo.TabIndex = 1;
            this.btnInsumo.Text = "Insumos  ";
            this.btnInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsumo.UseVisualStyleBackColor = true;
            this.btnInsumo.Click += new System.EventHandler(this.btnInsumo_Click);
            this.btnInsumo.Leave += new System.EventHandler(this.btnInsumo_Leave);
            // 
            // pnlBtnsPlatillos
            // 
            this.pnlBtnsPlatillos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            this.pnlBtnsPlatillos.Controls.Add(this.btnVender);
            this.pnlBtnsPlatillos.Controls.Add(this.btnGestionar);
            this.pnlBtnsPlatillos.Location = new System.Drawing.Point(3, 514);
            this.pnlBtnsPlatillos.Name = "pnlBtnsPlatillos";
            this.pnlBtnsPlatillos.Size = new System.Drawing.Size(186, 100);
            this.pnlBtnsPlatillos.TabIndex = 0;
            this.pnlBtnsPlatillos.Visible = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnVender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVender.Location = new System.Drawing.Point(0, 50);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(186, 50);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            this.btnVender.Leave += new System.EventHandler(this.btnPlatillos_Leave);
            // 
            // btnGestionar
            // 
            this.btnGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.btnGestionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionar.FlatAppearance.BorderSize = 0;
            this.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGestionar.ForeColor = System.Drawing.Color.White;
            this.btnGestionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionar.Location = new System.Drawing.Point(0, 0);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(186, 50);
            this.btnGestionar.TabIndex = 1;
            this.btnGestionar.Text = "Gestionar";
            this.btnGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionar.UseVisualStyleBackColor = false;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            this.btnGestionar.Leave += new System.EventHandler(this.btnPlatillos_Leave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 655);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(186, 42);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.Leave += new System.EventHandler(this.btnCerrar_Leave);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 425);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(186, 50);
            this.btnEstadistica.TabIndex = 1;
            this.btnEstadistica.Text = "Estadisticas";
            this.btnEstadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            this.btnEstadistica.Leave += new System.EventHandler(this.btnRegistros_Leave);
            // 
            // btnPlatillos
            // 
            this.btnPlatillos.FlatAppearance.BorderSize = 0;
            this.btnPlatillos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatillos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlatillos.ForeColor = System.Drawing.Color.White;
            this.btnPlatillos.Location = new System.Drawing.Point(0, 225);
            this.btnPlatillos.Name = "btnPlatillos";
            this.btnPlatillos.Size = new System.Drawing.Size(186, 50);
            this.btnPlatillos.TabIndex = 1;
            this.btnPlatillos.Text = "Productos ";
            this.btnPlatillos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlatillos.UseVisualStyleBackColor = true;
            this.btnPlatillos.Click += new System.EventHandler(this.btnPlatillos_Click);
            this.btnPlatillos.Leave += new System.EventHandler(this.btnPlatillos_Leave);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(138)))));
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Controls.Add(this.imgUsuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(186, 164);
            this.pnlUsuario.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(40, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de usuario";
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::saborColombiano.Properties.Resources.icons8_invitado_masculino_50__1_;
            this.imgUsuario.Location = new System.Drawing.Point(60, 32);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(63, 63);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 0;
            this.imgUsuario.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(186, 188);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(838, 508);
            this.pnlPrincipal.TabIndex = 1;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint);
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorde.Location = new System.Drawing.Point(186, 0);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(767, 30);
            this.pnlBorde.TabIndex = 4;
            this.pnlBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBorde_MouseDown);
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.BackColor = System.Drawing.Color.White;
            this.Cerrarbtn.FlatAppearance.BorderSize = 0;
            this.Cerrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrarbtn.Image = global::saborColombiano.Properties.Resources.icons8_multiplicar_30;
            this.Cerrarbtn.Location = new System.Drawing.Point(992, 0);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(32, 32);
            this.Cerrarbtn.TabIndex = 0;
            this.Cerrarbtn.UseVisualStyleBackColor = false;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::saborColombiano.Properties.Resources.icons8_menos_30;
            this.btnMinimizar.Location = new System.Drawing.Point(959, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(489, 147);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Menu Principal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::saborColombiano.Properties.Resources.saborColombiano;
            this.pictureBox1.Location = new System.Drawing.Point(358, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.Cerrarbtn);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlBorde);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlbtnsInsumo.ResumeLayout(false);
            this.pnlBtnsPersona.ResumeLayout(false);
            this.pnlBtnsPlatillos.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnPlatillos;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnInsumo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBtnsPlatillos;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button bntGestionarInsumo;
        private System.Windows.Forms.Panel pnlbtnsInsumo;
        private System.Windows.Forms.Panel pnlBtnsPersona;
        private System.Windows.Forms.Button btnVerPersonas;
        private System.Windows.Forms.Button btnGestionarPersonas;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button Cerrarbtn;
    }
}
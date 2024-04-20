
using System;
using System.Runtime.InteropServices;

namespace saborColombiano
{
    partial class Estadisticas
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3dItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.tbxGasto = new System.Windows.Forms.TextBox();
            this.lblGasto = new System.Windows.Forms.Label();
            this.tbxInversion = new System.Windows.Forms.TextBox();
            this.lblInversion = new System.Windows.Forms.Label();
            this.tbxGeneradoMes = new System.Windows.Forms.TextBox();
            this.lblGeneradoMes = new System.Windows.Forms.Label();
            this.tbxNeta = new System.Windows.Forms.TextBox();
            this.lblNeta = new System.Windows.Forms.Label();
            this.tbxGeneradoEspeciales = new System.Windows.Forms.TextBox();
            this.lblMenosVendido = new System.Windows.Forms.Label();
            this.tbxGeneradoCorrientes = new System.Windows.Forms.TextBox();
            this.lblMasVendido = new System.Windows.Forms.Label();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.graficaCrecimiento = new CircularProgressBar_NET5.CircularProgressBar();
            this.lblCrecimiento = new System.Windows.Forms.Label();
            this.pnlGraficaAnterior = new System.Windows.Forms.Panel();
            this.lblGraficaAnterior = new System.Windows.Forms.Label();
            this.diagramaIngresos = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            this.pnlGrafica.SuspendLayout();
            this.pnlGraficaAnterior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.tbxGasto);
            this.pnlSuperior.Controls.Add(this.lblGasto);
            this.pnlSuperior.Controls.Add(this.tbxInversion);
            this.pnlSuperior.Controls.Add(this.lblInversion);
            this.pnlSuperior.Controls.Add(this.tbxGeneradoMes);
            this.pnlSuperior.Controls.Add(this.lblGeneradoMes);
            this.pnlSuperior.Controls.Add(this.tbxNeta);
            this.pnlSuperior.Controls.Add(this.lblNeta);
            this.pnlSuperior.Controls.Add(this.tbxGeneradoEspeciales);
            this.pnlSuperior.Controls.Add(this.lblMenosVendido);
            this.pnlSuperior.Controls.Add(this.tbxGeneradoCorrientes);
            this.pnlSuperior.Controls.Add(this.lblMasVendido);
            this.pnlSuperior.Location = new System.Drawing.Point(4, 1);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(811, 216);
            this.pnlSuperior.TabIndex = 0;
            // 
            // tbxGasto
            // 
            this.tbxGasto.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxGasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGasto.Enabled = false;
            this.tbxGasto.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGasto.Location = new System.Drawing.Point(540, 131);
            this.tbxGasto.Multiline = true;
            this.tbxGasto.Name = "tbxGasto";
            this.tbxGasto.ReadOnly = true;
            this.tbxGasto.Size = new System.Drawing.Size(138, 52);
            this.tbxGasto.TabIndex = 1;
            this.tbxGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGasto.Location = new System.Drawing.Point(540, 109);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(128, 19);
            this.lblGasto.TabIndex = 0;
            this.lblGasto.Text = "Gasto mensual ";
            // 
            // tbxInversion
            // 
            this.tbxInversion.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxInversion.Enabled = false;
            this.tbxInversion.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxInversion.Location = new System.Drawing.Point(540, 34);
            this.tbxInversion.Multiline = true;
            this.tbxInversion.Name = "tbxInversion";
            this.tbxInversion.ReadOnly = true;
            this.tbxInversion.Size = new System.Drawing.Size(138, 52);
            this.tbxInversion.TabIndex = 1;
            this.tbxInversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInversion
            // 
            this.lblInversion.AutoSize = true;
            this.lblInversion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInversion.Location = new System.Drawing.Point(540, 12);
            this.lblInversion.Name = "lblInversion";
            this.lblInversion.Size = new System.Drawing.Size(126, 19);
            this.lblInversion.TabIndex = 0;
            this.lblInversion.Text = "Costo mensual ";
            // 
            // tbxGeneradoMes
            // 
            this.tbxGeneradoMes.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxGeneradoMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGeneradoMes.Enabled = false;
            this.tbxGeneradoMes.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGeneradoMes.Location = new System.Drawing.Point(26, 131);
            this.tbxGeneradoMes.Multiline = true;
            this.tbxGeneradoMes.Name = "tbxGeneradoMes";
            this.tbxGeneradoMes.ReadOnly = true;
            this.tbxGeneradoMes.Size = new System.Drawing.Size(138, 52);
            this.tbxGeneradoMes.TabIndex = 1;
            this.tbxGeneradoMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGeneradoMes
            // 
            this.lblGeneradoMes.AutoSize = true;
            this.lblGeneradoMes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeneradoMes.Location = new System.Drawing.Point(13, 109);
            this.lblGeneradoMes.Name = "lblGeneradoMes";
            this.lblGeneradoMes.Size = new System.Drawing.Size(205, 19);
            this.lblGeneradoMes.TabIndex = 0;
            this.lblGeneradoMes.Text = "Total generado en el mes";
            // 
            // tbxNeta
            // 
            this.tbxNeta.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxNeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNeta.Enabled = false;
            this.tbxNeta.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxNeta.Location = new System.Drawing.Point(274, 131);
            this.tbxNeta.Multiline = true;
            this.tbxNeta.Name = "tbxNeta";
            this.tbxNeta.ReadOnly = true;
            this.tbxNeta.Size = new System.Drawing.Size(138, 52);
            this.tbxNeta.TabIndex = 1;
            this.tbxNeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNeta
            // 
            this.lblNeta.AutoSize = true;
            this.lblNeta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNeta.Location = new System.Drawing.Point(262, 109);
            this.lblNeta.Name = "lblNeta";
            this.lblNeta.Size = new System.Drawing.Size(185, 19);
            this.lblNeta.TabIndex = 0;
            this.lblNeta.Text = "Estado de operaciones";
            // 
            // tbxGeneradoEspeciales
            // 
            this.tbxGeneradoEspeciales.BackColor = System.Drawing.SystemColors.Control;
            this.tbxGeneradoEspeciales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGeneradoEspeciales.Enabled = false;
            this.tbxGeneradoEspeciales.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGeneradoEspeciales.Location = new System.Drawing.Point(275, 34);
            this.tbxGeneradoEspeciales.Multiline = true;
            this.tbxGeneradoEspeciales.Name = "tbxGeneradoEspeciales";
            this.tbxGeneradoEspeciales.ReadOnly = true;
            this.tbxGeneradoEspeciales.Size = new System.Drawing.Size(138, 52);
            this.tbxGeneradoEspeciales.TabIndex = 1;
            this.tbxGeneradoEspeciales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMenosVendido
            // 
            this.lblMenosVendido.AutoSize = true;
            this.lblMenosVendido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenosVendido.Location = new System.Drawing.Point(262, 12);
            this.lblMenosVendido.Name = "lblMenosVendido";
            this.lblMenosVendido.Size = new System.Drawing.Size(205, 19);
            this.lblMenosVendido.TabIndex = 0;
            this.lblMenosVendido.Text = "Generado por especiales";
            // 
            // tbxGeneradoCorrientes
            // 
            this.tbxGeneradoCorrientes.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxGeneradoCorrientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGeneradoCorrientes.Enabled = false;
            this.tbxGeneradoCorrientes.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxGeneradoCorrientes.Location = new System.Drawing.Point(26, 34);
            this.tbxGeneradoCorrientes.Multiline = true;
            this.tbxGeneradoCorrientes.Name = "tbxGeneradoCorrientes";
            this.tbxGeneradoCorrientes.ReadOnly = true;
            this.tbxGeneradoCorrientes.Size = new System.Drawing.Size(138, 52);
            this.tbxGeneradoCorrientes.TabIndex = 1;
            this.tbxGeneradoCorrientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMasVendido
            // 
            this.lblMasVendido.AutoSize = true;
            this.lblMasVendido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasVendido.Location = new System.Drawing.Point(10, 12);
            this.lblMasVendido.Name = "lblMasVendido";
            this.lblMasVendido.Size = new System.Drawing.Size(197, 19);
            this.lblMasVendido.TabIndex = 0;
            this.lblMasVendido.Text = "Generado por corrientes";
            // 
            // pnlGrafica
            // 
            this.pnlGrafica.Controls.Add(this.graficaCrecimiento);
            this.pnlGrafica.Location = new System.Drawing.Point(582, 46);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(193, 180);
            this.pnlGrafica.TabIndex = 1;
            // 
            // graficaCrecimiento
            // 
            this.graficaCrecimiento.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.graficaCrecimiento.AnimationSpeed = 500;
            this.graficaCrecimiento.BackColor = System.Drawing.Color.Transparent;
            this.graficaCrecimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficaCrecimiento.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graficaCrecimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.graficaCrecimiento.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.graficaCrecimiento.InnerMargin = 2;
            this.graficaCrecimiento.InnerWidth = -1;
            this.graficaCrecimiento.Location = new System.Drawing.Point(0, 0);
            this.graficaCrecimiento.MarqueeAnimationSpeed = 2000;
            this.graficaCrecimiento.Name = "graficaCrecimiento";
            this.graficaCrecimiento.OuterColor = System.Drawing.Color.Gray;
            this.graficaCrecimiento.OuterMargin = -25;
            this.graficaCrecimiento.OuterWidth = 26;
            this.graficaCrecimiento.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.graficaCrecimiento.ProgressWidth = 7;
            this.graficaCrecimiento.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graficaCrecimiento.Size = new System.Drawing.Size(193, 180);
            this.graficaCrecimiento.StartAngle = 270;
            this.graficaCrecimiento.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.graficaCrecimiento.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.graficaCrecimiento.SubscriptText = "";
            this.graficaCrecimiento.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.graficaCrecimiento.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.graficaCrecimiento.SuperscriptText = "";
            this.graficaCrecimiento.TabIndex = 0;
            this.graficaCrecimiento.Text = "76%";
            this.graficaCrecimiento.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.graficaCrecimiento.Value = 50;
            // 
            // lblCrecimiento
            // 
            this.lblCrecimiento.AutoSize = true;
            this.lblCrecimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrecimiento.Location = new System.Drawing.Point(561, 0);
            this.lblCrecimiento.Name = "lblCrecimiento";
            this.lblCrecimiento.Size = new System.Drawing.Size(236, 19);
            this.lblCrecimiento.TabIndex = 2;
            this.lblCrecimiento.Text = "Indice de ganancia mensual";
            // 
            // pnlGraficaAnterior
            // 
            this.pnlGraficaAnterior.Controls.Add(this.lblGraficaAnterior);
            this.pnlGraficaAnterior.Controls.Add(this.diagramaIngresos);
            this.pnlGraficaAnterior.Location = new System.Drawing.Point(0, 0);
            this.pnlGraficaAnterior.Name = "pnlGraficaAnterior";
            this.pnlGraficaAnterior.Size = new System.Drawing.Size(566, 262);
            this.pnlGraficaAnterior.TabIndex = 1;
            // 
            // lblGraficaAnterior
            // 
            this.lblGraficaAnterior.AutoSize = true;
            this.lblGraficaAnterior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGraficaAnterior.Location = new System.Drawing.Point(173, 0);
            this.lblGraficaAnterior.Name = "lblGraficaAnterior";
            this.lblGraficaAnterior.Size = new System.Drawing.Size(186, 19);
            this.lblGraficaAnterior.TabIndex = 2;
            this.lblGraficaAnterior.Text = "Historico de ganancias";
            // 
            // diagramaIngresos
            // 
            this.diagramaIngresos.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(100)))), ((int)(((byte)(142)))));
            this.diagramaIngresos.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.diagramaIngresos.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.diagramaIngresos.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.diagramaIngresos.ChartArea.CursorReDraw = false;
            this.diagramaIngresos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diagramaIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramaIngresos.Enabled = false;
            this.diagramaIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagramaIngresos.IsWindowLess = false;
            // 
            // 
            // 
            this.diagramaIngresos.Legend.Location = new System.Drawing.Point(479, 10);
            this.diagramaIngresos.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.diagramaIngresos.Localize = null;
            this.diagramaIngresos.Location = new System.Drawing.Point(0, 0);
            this.diagramaIngresos.Name = "diagramaIngresos";
            this.diagramaIngresos.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.diagramaIngresos.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.diagramaIngresos.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.diagramaIngresos.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.diagramaIngresos.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.diagramaIngresos.PrimaryXAxis.Margin = true;
            this.diagramaIngresos.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.diagramaIngresos.PrimaryXAxis.PointOffset = 1D;
            this.diagramaIngresos.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.diagramaIngresos.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.diagramaIngresos.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagramaIngresos.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.Custom;
            this.diagramaIngresos.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.diagramaIngresos.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.diagramaIngresos.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.diagramaIngresos.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.diagramaIngresos.PrimaryYAxis.Margin = true;
            this.diagramaIngresos.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.diagramaIngresos.PrimaryYAxis.PointOffset = 1D;
            this.diagramaIngresos.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.diagramaIngresos.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.diagramaIngresos.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagramaIngresos.Series3D = true;
            this.diagramaIngresos.ShowToolbarInImage = false;
            this.diagramaIngresos.Size = new System.Drawing.Size(566, 262);
            this.diagramaIngresos.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.diagramaIngresos.Spacing = 50F;
            this.diagramaIngresos.SpacingBetweenSeries = 20F;
            this.diagramaIngresos.Style3D = true;
            this.diagramaIngresos.TabIndex = 0;
            this.diagramaIngresos.Tilt = 10F;
            // 
            // 
            // 
            this.diagramaIngresos.Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diagramaIngresos.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.diagramaIngresos.Title.Name = "Default";
            this.diagramaIngresos.ToolBar.EnableDefaultItems = false;
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarSplitter1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarSeries3dItem1);
            this.diagramaIngresos.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.diagramaIngresos.VisualTheme = "";
            // 
            // pnlInferior
            // 
            this.pnlInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInferior.Controls.Add(this.lblCrecimiento);
            this.pnlInferior.Controls.Add(this.pnlGraficaAnterior);
            this.pnlInferior.Controls.Add(this.pnlGrafica);
            this.pnlInferior.Location = new System.Drawing.Point(5, 222);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(811, 266);
            this.pnlInferior.TabIndex = 3;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 508);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlGrafica.ResumeLayout(false);
            this.pnlGraficaAnterior.ResumeLayout(false);
            this.pnlGraficaAnterior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlGrafica;
        private CircularProgressBar_NET5.CircularProgressBar graficaCrecimiento;
        private System.Windows.Forms.TextBox tbxInversion;
        private System.Windows.Forms.Label lblInversion;
        private System.Windows.Forms.TextBox tbxGeneradoMes;
        private System.Windows.Forms.Label lblGeneradoMes;
        private System.Windows.Forms.TextBox tbxNeta;
        private System.Windows.Forms.Label lblNeta;
        private System.Windows.Forms.TextBox tbxGeneradoEspeciales;
        private System.Windows.Forms.Label lblMenosVendido;
        private System.Windows.Forms.TextBox tbxGeneradoCorrientes;
        private System.Windows.Forms.Label lblMasVendido;
        private System.Windows.Forms.Label lblCrecimiento;
        private System.Windows.Forms.Panel pnlGraficaAnterior;
        private Syncfusion.Windows.Forms.Chart.ChartControl diagramaIngresos;
        private System.Windows.Forms.Label lblGraficaAnterior;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.TextBox tbxGasto;
        private System.Windows.Forms.Label lblGasto;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using Syncfusion.Windows.Forms.Chart;

namespace saborColombiano
{
    public partial class Estadisticas : Form
    {
        FacturaService facturaService = new FacturaService();

        
        public Estadisticas()
        {
            InitializeComponent();
            Modificaciones();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            tbxGeneradoMes.Text = facturaService.GananciaMensual().ToString();
            tbxInversion.Text = facturaService.InversionMensual().ToString();
            tbxGeneradoCorrientes.Text = facturaService.GananciasEnCorriente().ToString();
            tbxGeneradoEspeciales.Text = facturaService.GananciasEnEspeciales().ToString();
            tbxNeta.Text = facturaService.GananciaNeta().ToString();
            tbxGasto.Text = facturaService.GastoMensual().ToString();
            graficaCrecimiento.Text = facturaService.CrecimientoMensual().ToString()+"%";
            if (Convert.ToInt32(facturaService.CrecimientoMensual())>=100)
            {
                graficaCrecimiento.Value = 100;
            }
            else
            {
                if (Convert.ToInt32(facturaService.CrecimientoMensual()) <= 0)
                {
                    graficaCrecimiento.Value = 0;
                }
                else
                {
                    graficaCrecimiento.Value = Convert.ToInt32(facturaService.CrecimientoMensual());
                }
            }
            OrdenarDatos();
        }

        public void Modificaciones()
        {
            tbxGeneradoMes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxGeneradoMes.Width, tbxGeneradoMes.Height, 15, 15));
            tbxInversion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxInversion.Width, tbxInversion.Height, 15, 15));
            tbxGeneradoCorrientes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxGeneradoCorrientes.Width, tbxGeneradoCorrientes.Height, 15, 15));
            tbxGeneradoEspeciales.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxGeneradoEspeciales.Width, tbxGeneradoEspeciales.Height, 15, 15));
            tbxNeta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxNeta.Width, tbxNeta.Height, 15, 15));
            tbxGasto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tbxNeta.Width, tbxNeta.Height, 15, 15));
        }

        public void OrdenarDatos()
        {
            List<IngresoMensual> ingresos = new List<IngresoMensual>();
            for (int i=5; i>=0; i--)
            {
                IngresoMensual ingresoMensual = new IngresoMensual(DateTime.Now.AddMonths(-i-1).ToString("MMMM"), facturaService.GananciaNeta(DateTime.Now.AddMonths(-i).ToString("MM/yyyy")));
                ingresos.Add(ingresoMensual);
            }
            ingresos.Last().Ingreso = 0;

            ChartSeries series = new ChartSeries("Ingresos");
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(ingresos);
            dataSeriesModel.YNames = new string[] { "Ingreso" };
            series.Style.DisplayText = true;
            series.Style.TextOrientation = ChartTextOrientation.Up;
            
            series.SeriesModel = dataSeriesModel;
            ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(ingresos);
            dataLabelsModel.LabelName = "Mes";
            diagramaIngresos.Series.Add(series);
            diagramaIngresos.PrimaryXAxis.LabelsImpl = dataLabelsModel;
            

        }
    }

    public class IngresoMensual
    {
        public string Mes { get; set; }
        public double Ingreso { get; set; }

        public IngresoMensual()
        {

        }

        public IngresoMensual(string mes, double ingreso)
        {
            Mes = mes;
            Ingreso = ingreso;
        }
    }
}

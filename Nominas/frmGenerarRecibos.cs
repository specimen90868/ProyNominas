using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmGenerarRecibos : Form
    {
        public frmGenerarRecibos()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        int tipoNomina, periodo;
        string fechaInicio = String.Empty, fechaFin = String.Empty;
        #endregion

        private void frmGenerarRecibos_Load(object sender, EventArgs e)
        {
            rbtnOrdinario.Checked = true;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Periodos.Core.PeriodosHelper ph = new Periodos.Core.PeriodosHelper();
            ph.Command = cmd;

            Periodos.Core.Periodos periodo = new Periodos.Core.Periodos();
            periodo.idempresa = GLOBALES.IDEMPRESA;

            List<Periodos.Core.Periodos> lstPeriodos = new List<Periodos.Core.Periodos>();

            cnx.Open();
            lstPeriodos = ph.obtenerPeriodos(periodo);
            cnx.Close();
            cnx.Dispose();

            cmbPeriodo.DataSource = lstPeriodos.ToList();
            cmbPeriodo.DisplayMember = "pago";
            cmbPeriodo.ValueMember = "dias";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            CalculoNomina.Core.NominaHelper nh = new CalculoNomina.Core.NominaHelper();
            nh.Command = cmd;

            List<CalculoNomina.Core.tmpPagoNomina> lstPeriodos = new List<CalculoNomina.Core.tmpPagoNomina>();

            try
            {
                cnx.Open();
                //lstPeriodos = nh.obtenerPeriodosNomina(GLOBALES.IDEMPRESA, tipoNomina, int.Parse(cmbPeriodo.SelectedValue.ToString()));
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Al obtener los periodos de la empresa.", "Error");
                cnx.Dispose();
                return;
            }

            lstvPeriodos.Clear();
            lstvPeriodos.View = View.Details;
            lstvPeriodos.CheckBoxes = false;
            lstvPeriodos.GridLines = false;
            lstvPeriodos.Columns.Add("Inicio", 100, HorizontalAlignment.Left);
            lstvPeriodos.Columns.Add("Fin", 100, HorizontalAlignment.Left);

            for (int i = 0; i < lstPeriodos.Count; i++)
            {
                ListViewItem Lista;
                Lista = lstvPeriodos.Items.Add(lstPeriodos[i].fechainicio.ToShortDateString());
                Lista.SubItems.Add(lstPeriodos[i].fechafin.ToShortDateString());
            }
        }

        private void rbtnOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            tipoNomina = 0;
        }

        private void rbtnExtraordinario_CheckedChanged(object sender, EventArgs e)
        {
            tipoNomina = 2;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvPeriodos.SelectedItems.Count; i++)
            {
                fechaInicio = lstvPeriodos.SelectedItems[i].Text;
                fechaFin = lstvPeriodos.SelectedItems[i].SubItems[1].Text;
            }

            periodo = int.Parse(cmbPeriodo.SelectedValue.ToString());
            btnGenerar.Enabled = false;
            workGenerar.RunWorkerAsync();
        }

        private void workGenerar_DoWork(object sender, DoWorkEventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            try
            {
                cnx.Open();
                xh.eliminaCfdiMaster(GLOBALES.IDEMPRESA, DateTime.Parse(fechaInicio).Date, DateTime.Parse(fechaFin).Date, tipoNomina, periodo);
                cnx.Close();
                workGenerar.ReportProgress(0, "Eliminando Cabeceras...");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: Falló la eliminación de la Cabecera.\r\n\r\nDescripción del error:\r\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }

            try
            {
                cnx.Open();
                xh.insertaCfdiMaster(GLOBALES.IDEMPRESA, DateTime.Parse(fechaInicio).Date, DateTime.Parse(fechaFin).Date, periodo, tipoNomina);
                cnx.Close();
                workGenerar.ReportProgress(0, "Generando Cabeceras...");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: Falló la generación de la Cabecera.\r\n\r\nDescripción del error:\r\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }

            try
            {
                cnx.Open();
                xh.insertaCfdiDetalle(GLOBALES.IDEMPRESA, DateTime.Parse(fechaInicio).Date, DateTime.Parse(fechaFin).Date, periodo, tipoNomina);
                cnx.Close();
                workGenerar.ReportProgress(0, "Generando Detalle...");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: Falló la generación del detalle.\r\n\r\nDescripción del error:\r\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }

            cnx.Dispose();
        }

        private void workGenerar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolEtapa.Text = e.UserState.ToString();
        }

        private void workGenerar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGenerar.Enabled = true;
            toolEtapa.Text = "Proceso terminado.";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

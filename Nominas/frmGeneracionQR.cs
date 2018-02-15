using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmGeneracionQR : Form
    {
        public frmGeneracionQR()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        int tipoNomina;
        string fechaInicio = String.Empty, fechaFin = String.Empty;
        #endregion

        private void frmGeneracionQR_Load(object sender, EventArgs e)
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

        private void rbtnOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            tipoNomina = 0;
        }

        private void rbtnExtraordinario_CheckedChanged(object sender, EventArgs e)
        {
            tipoNomina = 2;
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvPeriodos.SelectedItems.Count; i++)
            {
                fechaInicio = lstvPeriodos.SelectedItems[i].Text;
                fechaFin = lstvPeriodos.SelectedItems[i].SubItems[1].Text;
            }
            workGenerar.RunWorkerAsync();
        }

        private void workGenerar_DoWork(object sender, DoWorkEventArgs e)
        {
            
            string codigoQR = "";
            string[] valores = null;
            string numero = "";
            string vEntero = "";
            string vDecimal = "";
            int progreso = 0;
            int totalRegistros = 0;

            List<Xml.Core.CodigoBidimensional> lstXmlQr = new List<Xml.Core.CodigoBidimensional>();
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            cnx.Open();
            lstXmlQr = xh.obtenerDatosCodigoQr(GLOBALES.IDEMPRESA, tipoNomina, DateTime.Parse(fechaInicio).Date, DateTime.Parse(fechaFin).Date);
            cnx.Close();

            totalRegistros = lstXmlQr.Count();

            for (int i = 0; i < lstXmlQr.Count; i++)
            {
                progreso = ((i + 1) * 100) / totalRegistros;
                workGenerar.ReportProgress(progreso, "Generando codigos QR.");

                numero = lstXmlQr[i].tt.ToString();
                valores = numero.Split('.');
                vEntero = valores[0];
                vDecimal = valores[1];
                codigoQR = string.Format("?re={0}&rr={1}&tt={2}.{3}&id={4}", lstXmlQr[i].re, lstXmlQr[i].rr,
                    vEntero.PadLeft(10, '0'), vDecimal.PadRight(6, '0'), lstXmlQr[i].uuid);
                var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                var qrCode = qrEncoder.Encode(codigoQR);
                var renderer = new GraphicsRenderer(new FixedModuleSize(2, QuietZoneModules.Two), Brushes.Black, Brushes.White);

                using (var stream = new FileStream(lstXmlQr[i].uuid + ".png", FileMode.Create))
                    renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);

                Bitmap bmp = new Bitmap(lstXmlQr[i].uuid + ".png");
                Byte[] qr = GLOBALES.IMAGEN_BYTES(bmp);
                bmp.Dispose();
                File.Delete(lstXmlQr[i].uuid + ".png");
                Xml.Core.XmlCabecera xml = new Xml.Core.XmlCabecera();
                xml.folio = lstXmlQr[i].folio;
                xml.codeqr = qr;

                try
                {
                    cnx.Open();
                    xh.actualizaXmlCodeQr(xml);
                    cnx.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Al actualizar el código QR.", "Error");
                    cnx.Dispose();
                    return;
                }
            }
        }

        private void workGenerar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolAvance.Text = e.ProgressPercentage.ToString() + "%";
            toolEtapa.Text = e.UserState.ToString();
        }

        private void workGenerar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolAvance.Text = "100%";
            toolEtapa.Text = "Generación terminada.";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

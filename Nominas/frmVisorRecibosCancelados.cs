using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmVisorRecibosCancelados : Form
    {
        public frmVisorRecibosCancelados()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string rutaCancelados = String.Empty;
        string directorioEmpresa = String.Empty;
        #endregion

        private void frmVisorRecibosCancelados_Load(object sender, EventArgs e)
        {
            dgvVisorRecibos.RowHeadersVisible = false;
            dgvVisorRecibos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            rbtnFechas.Checked = true;
            gbxFechas.Enabled = false;
            gbxFolios.Enabled = false;
            btnAcuse.Enabled = false;

            rbtnFechas_CheckedChanged(sender, e);

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Configuracion.Core.ConfiguracionHelper ch = new Configuracion.Core.ConfiguracionHelper();
            ch.Command = cmd;

            try
            {
                cnx.Open();
                rutaCancelados = ch.obtenerValorConfiguracion(11).ToString();
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener la configuración del sistema.\r\n\r\nEsta ventana se cerrará", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            directorioEmpresa = String.Format(@"{0}{1}\", rutaCancelados, GLOBALES.IDEMPRESA);

            if (!System.IO.Directory.Exists(directorioEmpresa))
            {
                System.IO.Directory.CreateDirectory(directorioEmpresa);
            }
        }

        private void rbtnFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFechas.Checked)
                gbxFechas.Enabled = true;
            else
                gbxFechas.Enabled = false;
        }

        private void rbtnFolioFiscal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFolioFiscal.Checked)
                gbxFolios.Enabled = true;
            else
                gbxFolios.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnFechas.Checked)
                ListaRecibos(0);
            if (rbtnFolioFiscal.Checked)
                ListaRecibos(1);
        }

        void ListaRecibos(int tipoBusqueda)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            List<Xml.Core.XmlCancelados> lstXml = new List<Xml.Core.XmlCancelados>();
            
            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            try
            {
                if (tipoBusqueda == 0)
                {
                    DateTime de = DateTime.Parse(String.Format("{0} 00:00:00", dtpDe.Value.ToString("yyyy-MM-dd")));
                    DateTime hasta = DateTime.Parse(String.Format("{0} 23:59:00", dtpHasta.Value.ToString("yyyy-MM-dd")));

                    cnx.Open();
                    lstXml = xh.obtenerCancelados(GLOBALES.IDEMPRESA, de, hasta);
                    cnx.Close();
                }

                if (tipoBusqueda == 1)
                {
                    cnx.Open();
                    lstXml = xh.obtenerCancelados(mtxtFolioFiscal.Text);
                    cnx.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener la lista de recibos cancelados.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            cnx.Dispose();

            var lista = from c in lstXml select new { c.uuid, c.fecha, c.respuesta, c.folio };

            dgvVisorRecibos.Columns["uuid"].DataPropertyName = "uuid";
            dgvVisorRecibos.Columns["fecha"].DataPropertyName = "fecha";
            dgvVisorRecibos.Columns["respuesta"].DataPropertyName = "respuesta";
            dgvVisorRecibos.Columns["folio"].DataPropertyName = "folio";

            dgvVisorRecibos.DataSource = lista.ToList();

            for (int i = 0; i < dgvVisorRecibos.Columns.Count; i++)
            {
                dgvVisorRecibos.AutoResizeColumn(i);
            }

            if (dgvVisorRecibos.Columns.Count > 0)
            {
                btnAcuse.Enabled = true;
            }
            else
            {
                btnAcuse.Enabled = false;
            }
        }

        private void btnAcuse_Click(object sender, EventArgs e)
        {
            int fila = dgvVisorRecibos.CurrentCell.RowIndex;
            string uuid = dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString();
            string acuse = String.Empty;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;
            
            try
            {
                cnx.Open();
                acuse = xh.obtenerAcuse(uuid);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener generar el acuse de cancelación.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            using (StreamWriter sw = new StreamWriter(String.Format(@"{0}\{1}.xml", directorioEmpresa, uuid), false, Encoding.UTF8))
            {
                sw.WriteLine(acuse);
            }

            MessageBox.Show("Información:\r\nEl acuse fue creado en: " + directorioEmpresa, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

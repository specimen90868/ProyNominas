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
    public partial class frmPreferencias : Form
    {
        public frmPreferencias()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        SqlConnection cnx;
        SqlCommand cmd;
        Configuracion.Core.ConfiguracionHelper ch;
        #endregion

        private void frmPreferencias_Load(object sender, EventArgs e)
        {
            int entero = 0;
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            ch = new Configuracion.Core.ConfiguracionHelper();
            ch.Command = cmd;

            try
            {
                cnx.Open();
                txtCorreoEmisor.Text = ch.obtenerValorConfiguracion(1).ToString();
                txtPassword.Text = ch.obtenerValorConfiguracion(2).ToString();
                txtPuerto.Text = ch.obtenerValorConfiguracion(3).ToString();
                entero = int.Parse(ch.obtenerValorConfiguracion(4).ToString());
                chkSsl.Checked = Convert.ToBoolean(entero);
                txtServidorEnvio.Text = ch.obtenerValorConfiguracion(5).ToString();
                txtRuta.Text = ch.obtenerValorConfiguracion(6).ToString();
                txtVsmdf.Text = ch.obtenerValorConfiguracion(7).ToString();
                txtRutaKeys.Text = ch.obtenerValorConfiguracion(8).ToString();
                txtRutaXslt.Text = ch.obtenerValorConfiguracion(9).ToString();
                txtNombreArchivoXslt.Text = ch.obtenerValorConfiguracion(10).ToString();
                txtDirectorioCancelados.Text = ch.obtenerValorConfiguracion(11).ToString();
                txtDirectorioSsl.Text = ch.obtenerValorConfiguracion(12).ToString();
                txtDirectorioPem.Text = ch.obtenerValorConfiguracion(13).ToString();
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: Al obtener alguna de las configuraciones.\r\n\r\n" + error.Message, "Error");
                cnx.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int entero = 0;
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            ch = new Configuracion.Core.ConfiguracionHelper();
            ch.Command = cmd;

            try
            {
                cnx.Open();
                ch.actualizarValorConfiguracion(1, txtCorreoEmisor.Text);
                ch.actualizarValorConfiguracion(2, txtPassword.Text);
                ch.actualizarValorConfiguracion(3, txtPuerto.Text);
                entero = Convert.ToInt32(chkSsl.Checked);
                ch.actualizarValorConfiguracion(4, entero.ToString());
                ch.actualizarValorConfiguracion(5, txtServidorEnvio.Text);
                ch.actualizarValorConfiguracion(6, txtRuta.Text);
                ch.actualizarValorConfiguracion(7, txtVsmdf.Text);
                ch.actualizarValorConfiguracion(8, txtRutaKeys.Text);
                ch.actualizarValorConfiguracion(9, txtRutaXslt.Text);
                ch.actualizarValorConfiguracion(10, txtNombreArchivoXslt.Text);
                ch.actualizarValorConfiguracion(11, txtDirectorioCancelados.Text);
                ch.actualizarValorConfiguracion(12, txtDirectorioSsl.Text);
                ch.actualizarValorConfiguracion(13, txtDirectorioPem.Text);
                cnx.Close();
                cnx.Dispose();
                this.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: Al obtener alguna de las configuraciones.\r\n\r\n" + error.Message, "Error");
                cnx.Dispose();
            }
        }

        private void btnDirectorioXslt_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Carpeta de xslt";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRutaXslt.Text = fbd.SelectedPath;
            }
        }

        private void btnDirectorioKeys_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Carpeta de sellos";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRutaKeys.Text = fbd.SelectedPath;
            }
        }

        private void btnDirectorio_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Carpeta de envio";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = fbd.SelectedPath;
            }
        }

        private void btnRutaCancelados_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Carpeta de cancelados";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDirectorioCancelados.Text = fbd.SelectedPath;
            }
        }

        private void btnRutaSSL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Carpeta de Ssl";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDirectorioSsl.Text = fbd.SelectedPath;
            }
        }

        private void btnRutaPem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Carpeta de Pem";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDirectorioPem.Text = fbd.SelectedPath;
            }
        }
    }
}

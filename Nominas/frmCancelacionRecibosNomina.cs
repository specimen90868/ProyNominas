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
using Microsoft.VisualBasic.FileIO;

//using Nominas.finkokDemoCancelacion;
using Nominas.finkokProdCancelacion;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Nominas
{
    public partial class frmCancelacionRecibosNomina : Form
    {
        public frmCancelacionRecibosNomina()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string directorioEmpresa = String.Empty;
        int totalRegistros = 0, tiponomina = 0;
        int totalNoCancelados = 0;
        List<Empresas.Core.Empresas> lstEmpresas;

        string rutaArchivosAcuse = String.Empty;
        string carpetaArchivoKeys = String.Empty;
        string rutaArchivoKey = String.Empty;
        string rutaArchivoCer = String.Empty;
        string rutaOpenSsl = String.Empty;
        string rutaArchivosPem = String.Empty;
        #endregion

        #region VARIABLES PUBLICAS
        public int _periodo;
        #endregion

        private void frmCancelacionRecibosNomina_Load(object sender, EventArgs e)
        {
            dgvVisorRecibos.RowHeadersVisible = false;
            dgvVisorRecibos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            rbtnOrdinaria.Checked = true;
            rbtnOrdinaria_CheckedChanged(sender, e);

            btnCancelar.Enabled = false;
            btnCancelarTodo.Enabled = false;
            btnErrores.Enabled = false;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Configuracion.Core.ConfiguracionHelper ch = new Configuracion.Core.ConfiguracionHelper();
            ch.Command = cmd;

            Empresas.Core.EmpresasHelper eh = new Empresas.Core.EmpresasHelper();
            eh.Command = cmd;

            lstEmpresas = new List<Empresas.Core.Empresas>();

            try
            {
                cnx.Open();
                rutaArchivosAcuse = ch.obtenerValorConfiguracion(11).ToString();
                carpetaArchivoKeys = ch.obtenerValorConfiguracion(8).ToString();
                rutaOpenSsl = ch.obtenerValorConfiguracion(12).ToString();
                rutaArchivosPem = ch.obtenerValorConfiguracion(13).ToString();
                lstEmpresas = eh.obtenerDatosCertPac(GLOBALES.IDEMPRESA);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener la configuración del sistema.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            directorioEmpresa = String.Format(@"{0}{1}\", rutaArchivosAcuse, GLOBALES.IDEMPRESA);
            rutaArchivoKey = String.Format(@"{0}{1}", carpetaArchivoKeys, lstEmpresas[0].archivokey);
            rutaArchivoCer = String.Format(@"{0}{1}", carpetaArchivoKeys, lstEmpresas[0].archivocer);

            if (!System.IO.Directory.Exists(directorioEmpresa))
            {
                System.IO.Directory.CreateDirectory(directorioEmpresa);
            }

            if (!System.IO.Directory.Exists(rutaArchivosPem))
            {
                System.IO.Directory.CreateDirectory(rutaArchivosPem);
            }
        }

        private void rbtnOrdinaria_CheckedChanged(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            List<Xml.Core.XmlCabecera> lstPeriodosXml = new List<Xml.Core.XmlCabecera>();

            try
            {
                cnx.Open();
                lstPeriodosXml = xh.obtenerPeriodosTimbrados(GLOBALES.IDEMPRESA, 0, _periodo);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener los periodos ordinarios.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            cmbPeriodos.DataSource = lstPeriodosXml.ToList();
            cmbPeriodos.DisplayMember = "xml";

            tiponomina = 0;
        }

        private void rbtnExtraordinario_CheckedChanged(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            List<Xml.Core.XmlCabecera> lstPeriodosXml = new List<Xml.Core.XmlCabecera>();

            try
            {
                cnx.Open();
                lstPeriodosXml = xh.obtenerPeriodosTimbrados(GLOBALES.IDEMPRESA, 2, _periodo);
                cnx.Close();
                cnx.Dispose();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener los periodos extraordinarios.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            cmbPeriodos.DataSource = lstPeriodosXml.ToList();
            cmbPeriodos.DisplayMember = "xml";

            tiponomina = 2;
        }

        void ListaRecibos()
        {
            int totalTimbrados = 0, totalPendientes = 0;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            List<Xml.Core.XmlCabecera> lstXml = new List<Xml.Core.XmlCabecera>();
            List<Empleados.Core.Empleados> lstEmpleados = new List<Empleados.Core.Empleados>();

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
            eh.Command = cmd;

            Empleados.Core.Empleados empleado = new Empleados.Core.Empleados();
            empleado.idempresa = GLOBALES.IDEMPRESA;

            string[] fechas = cmbPeriodos.Text.Split('/');

            try
            {
                cnx.Open();
                lstXml = xh.obtenerXmlPeriodo(GLOBALES.IDEMPRESA, DateTime.Parse(fechas[0]), DateTime.Parse(fechas[1]), 0);
                lstEmpleados = eh.obtenerEmpleadosBaja(empleado);
                cnx.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener el listado de los recibos.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            var visor = from x in lstXml
                        join e in lstEmpleados on x.idtrabajador equals e.idtrabajador
                        select new
                        {
                            x.idtrabajador,
                            emitido = (x.emitido == "N" || x.emitido == "T") ? false : true,
                            e.noempleado,
                            e.nombrecompleto,
                            x.uuid,
                            x.fechatimbrado,
                            x.periodoinicio,
                            x.periodofin,
                            x.folio,
                            x.error
                        };

            dgvVisorRecibos.Columns["idtrabajador"].DataPropertyName = "idtrabajador";
            dgvVisorRecibos.Columns["emitido"].DataPropertyName = "emitido";
            dgvVisorRecibos.Columns["noempleado"].DataPropertyName = "noempleado";
            dgvVisorRecibos.Columns["nombrecompleto"].DataPropertyName = "nombrecompleto";
            dgvVisorRecibos.Columns["uuid"].DataPropertyName = "uuid";
            dgvVisorRecibos.Columns["fechatimbrado"].DataPropertyName = "fechatimbrado";
            dgvVisorRecibos.Columns["periodoinicio"].DataPropertyName = "periodoinicio";
            dgvVisorRecibos.Columns["periodofin"].DataPropertyName = "periodofin";
            dgvVisorRecibos.Columns["folio"].DataPropertyName = "folio";
            dgvVisorRecibos.Columns["error"].DataPropertyName = "error";

            dgvVisorRecibos.DataSource = visor.ToList();

            for (int i = 0; i < dgvVisorRecibos.Columns.Count; i++)
            {
                dgvVisorRecibos.AutoResizeColumn(i);
            }
            bool timbrado = false;
            for (int i = 0; i < dgvVisorRecibos.Rows.Count; i++)
            {
                timbrado = bool.Parse(dgvVisorRecibos.Rows[i].Cells[1].Value.ToString());
                if (timbrado)
                    totalTimbrados++;
                else
                    totalPendientes++;
            }

            totalRegistros = dgvVisorRecibos.Rows.Count;
            

            if (totalRegistros > 0)
            {
                btnCancelarTodo.Enabled = true;
                btnCancelar.Enabled = true;
                btnErrores.Enabled = true;
            }
            else
            {
                btnCancelarTodo.Enabled = false;
                btnCancelar.Enabled = false;
                btnErrores.Enabled = false;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ListaRecibos();
        }

        void FabricaPEM(String cer, String key, String passFinkok, String passCSDoFIEL)
        {
            Dictionary<String, String> DicArchivos = new Dictionary<String, String>();
            String ConvierteCerAPem;
            String ConvierteKeyAPem;
            String EncriptaKey;
            String ArchivoCer = cer;
            String ArchivoKey = key;
            String NombreArchivoCertificado = Path.GetFileName(ArchivoCer);
            String NombreArchivoLlave = Path.GetFileName(ArchivoKey);
            
            String url;
            url = rutaArchivosPem;
            String ruta;
            ruta = rutaOpenSsl;//Esta ruta es donde tiene ubicado el .exe del OpenSSL
            ConvierteCerAPem = ruta + "openssl.exe x509 -inform DER -outform PEM -in " + ArchivoCer + " -pubkey -out " + url + NombreArchivoCertificado + ".pem";
            ConvierteKeyAPem = ruta + "openssl.exe pkcs8 -inform DER -in " + ArchivoKey + " -passin pass:" + passCSDoFIEL + " -out " + url + NombreArchivoLlave + ".pem";
            EncriptaKey = ruta + "openssl.exe rsa -in " + url + NombreArchivoLlave + ".pem" + " -des3 -out " + url + NombreArchivoLlave + ".enc -passout pass:" + passFinkok;

            //Crea el archivo Certificado.BAT
            System.IO.StreamWriter oSW = new System.IO.StreamWriter(url + "CERyKEY.bat");
            oSW.WriteLine(ConvierteCerAPem);
            oSW.WriteLine(ConvierteKeyAPem);
            oSW.WriteLine(EncriptaKey);
            oSW.Flush();
            oSW.Close();

            Process.Start(url + "CERyKEY.bat").WaitForExit();

        }

        public byte[] stringToBase64ByteArray(String input)
        {
            Byte[] ret = Encoding.UTF8.GetBytes(input);
            String s = Convert.ToBase64String(ret);
            ret = Convert.FromBase64String(s);
            return ret;
        }

        private void btnCancelarTodo_Click(object sender, EventArgs e)
        {
            btnCancelarTodo.Enabled = false;
            workCancelarTodo.RunWorkerAsync();
        }

 


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int fila = dgvVisorRecibos.CurrentCell.RowIndex;
            string[] uuid = new string[1];
            

            FabricaPEM(rutaArchivoCer, rutaArchivoKey, lstEmpresas[0].passwordpac, lstEmpresas[0].passwordkey);
            String cer;
            String key;

            using (TextFieldParser fileReader = new TextFieldParser(rutaArchivosPem + Path.GetFileName(rutaArchivoCer) + ".pem"))
                cer = fileReader.ReadToEnd();


            using (TextFieldParser fileReader = new TextFieldParser(rutaArchivosPem + Path.GetFileName(rutaArchivoKey) + ".enc"))
                key = fileReader.ReadToEnd();
            uuid[0] = dgvVisorRecibos.Rows[fila].Cells[4].Value.ToString();

            cancelacion(cer, key, uuid, int.Parse(dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString()));

            if (totalNoCancelados != 0)
            {
                MessageBox.Show(String.Format("{0} recibos no fueron cancelados. Verifique.", totalNoCancelados.ToString()), "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cancelación exitosa.", "Información",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ListaRecibos();
            }
        }

        private void cancelacion(string certificado, string llave, string[] uuidSat, int folio)
        {
            
            bool FLAG_CANCELADO = false;
            string xml = String.Empty;
            string acuseRecibido = String.Empty;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            CancelSOAP cancela = new CancelSOAP();
            cancel can = new cancel();
            UUIDS nim = new UUIDS();
            
            nim.uuids = uuidSat.ToArray();
            can.UUIDS = nim;
            can.username = lstEmpresas[0].usuariopac;
            can.password = lstEmpresas[0].passwordpac;
            can.taxpayer_id = lstEmpresas[0].rfc; 
            can.cer = stringToBase64ByteArray(certificado);
            can.key = stringToBase64ByteArray(llave);

            //String usuario;
            //usuario = Environment.UserName;
            //String url = rutaArchivosPem + usuario;
            //StreamWriter XML = new StreamWriter(url + "_SOAP_ENVELOPE.xml");     //Direccion donde guardaremos el SOAP Envelope
            //XmlSerializer soap = new XmlSerializer(can.GetType());    //Obtenemos los datos del SOAP de la variable Solicitud
            //soap.Serialize(XML, can);
            //XML.Close();

            cancelResponse cancelresponse = new cancelResponse();

            try
            {
                cancelresponse = cancela.cancel(can);
            }
            catch
            {
                MessageBox.Show("Error: Método Cancelar del PAC devolvió un error.\r\n\r\nPor favor verifique con su administrador que el password no se haya cambiado.\r\nEsta ventana se cerrará",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }

            if (cancelresponse.cancelResult.CodEstatus == null)
            {
                Xml.Core.XmlCancelados cancelado = new Xml.Core.XmlCancelados();
                cancelado.folio = folio;
                cancelado.idempresa = GLOBALES.IDEMPRESA;
                cancelado.uuid = uuidSat[0];
                cancelado.fecha = DateTime.Parse(cancelresponse.cancelResult.Fecha);

                switch (cancelresponse.cancelResult.Folios[0].EstatusUUID)
                {
                    case "201":
                        acuseRecibido = cancelresponse.cancelResult.Acuse;
                        cancelado.acuse = acuseRecibido.Replace("\\","");
                        cancelado.respuesta = cancelresponse.cancelResult.Folios[0].EstatusUUID + " - UUID Cancelado Exitosamente";
                        FLAG_CANCELADO = true;
                        break;
                    case "202":
                        cancelado.acuse = (cancelresponse.cancelResult.Acuse == null ? "-" : cancelresponse.cancelResult.Acuse);
                        cancelado.respuesta = cancelresponse.cancelResult.Folios[0].EstatusUUID + " - UUID Previamente Cancelado";
                        totalNoCancelados++;
                        FLAG_CANCELADO = true;
                        break;
                    case "203":
                        cancelado.acuse = (cancelresponse.cancelResult.Acuse == null ? "-" : cancelresponse.cancelResult.Acuse);
                        cancelado.respuesta = cancelresponse.cancelResult.Folios[0].EstatusUUID + " - No corresponde el RFC Emisor y de quien solicita la cancelación";
                        totalNoCancelados++;
                        FLAG_CANCELADO = true;
                        break;
                    case "205":
                        cancelado.acuse = (cancelresponse.cancelResult.Acuse == null ? "-" : cancelresponse.cancelResult.Acuse);
                        cancelado.respuesta = cancelresponse.cancelResult.Folios[0].EstatusUUID + " - UUID no existe";
                        totalNoCancelados++;
                        FLAG_CANCELADO = true;
                        break;
                }

                if (FLAG_CANCELADO)
                {
                    try
                    {
                        cnx.Open();
                        xml = xh.obtenerXml(folio);
                        cancelado.xml = xml;
                        xh.insertaCancelado(cancelado);
                        xh.actualizaXmlCabeceraCancelado(folio);
                        xh.eliminaCfdiMaster(GLOBALES.IDEMPRESA,
                            DateTime.Parse(dgvVisorRecibos.Rows[0].Cells[6].Value.ToString()).Date,
                            DateTime.Parse(dgvVisorRecibos.Rows[0].Cells[7].Value.ToString()).Date,
                            tiponomina);
                        cnx.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Advertencia: Es posible que una de las siguientes operaciones no se haya realizado:\r\n\r\n" + 
                                        "1. No se registró la cancelación del recibo.\r\n" + 
                                        "2. No se actualizó el el recibo de nómina en el XML.\r\n" +
                                        "3. No se eliminó el registro del CFDI Cabecera.\r\n\r\n" + 
                                        "Favor de verificar. Esta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cnx.Dispose();
                        this.Dispose();
                    }
                    
                }
                else
                {
                    Xml.Core.XmlCabecera xc = new Xml.Core.XmlCabecera();
                    xc.error = cancelado.respuesta;
                    xc.folio = folio;

                    cnx.Open();
                    xh.actualizaXmlCabeceraError(xc);
                    cnx.Close();
                }
                
            }
            else
            {
                Xml.Core.XmlCabecera xc = new Xml.Core.XmlCabecera();
                xc.error = cancelresponse.cancelResult.CodEstatus;
                xc.folio = folio;

                cnx.Open();
                xh.actualizaXmlCabeceraError(xc);
                cnx.Close();

                totalNoCancelados++;
            }
        }

        private void btnErrores_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();

            excel.Cells[1, 1] = GLOBALES.NOMBREEMPRESA;
            excel.Cells[2, 1] = "Errores en el timbrado.";
            excel.Cells[4, 1] = "No. Empleado";
            excel.Cells[4, 2] = "Periodo Inicio";
            excel.Cells[4, 3] = "Periodo Fin";
            excel.Cells[4, 4] = "Descripción del error";

            bool timbrado = false;
            int fila = 5;
            for (int i = 0; i < dgvVisorRecibos.Rows.Count; i++)
            {
                timbrado = bool.Parse(dgvVisorRecibos.Rows[i].Cells[1].Value.ToString());
                if (!timbrado)
                {
                    excel.Cells[fila, 1] = dgvVisorRecibos.Rows[i].Cells[2].Value.ToString();
                    excel.Cells[fila, 2] = dgvVisorRecibos.Rows[i].Cells[6].Value.ToString();
                    excel.Cells[fila, 3] = dgvVisorRecibos.Rows[i].Cells[7].Value.ToString();
                    excel.Cells[fila, 4] = dgvVisorRecibos.Rows[i].Cells[9].Value.ToString();
                    fila++;
                }
            }

            excel.Range["A1", "A2"].Font.Bold = true;
            excel.Range["A4", "D4"].Font.Bold = true;
            excel.Range["D:D"].EntireColumn.ColumnWidth = 250;
            excel.Range["D:D"].WrapText = false;
            excel.Visible = true;
        }

        private void workCancelarTodo_DoWork(object sender, DoWorkEventArgs e)
        {
            int progreso = 0;
            
            FabricaPEM(rutaArchivoCer, rutaArchivoKey, lstEmpresas[0].passwordpac, lstEmpresas[0].passwordkey);
            String cer;
            String key;
            string[] uuids = new string[dgvVisorRecibos.Rows.Count];

            using (TextFieldParser fileReader = new TextFieldParser(rutaArchivosPem + Path.GetFileName(rutaArchivoCer) + ".pem"))
                cer = fileReader.ReadToEnd();


            using (TextFieldParser fileReader = new TextFieldParser(rutaArchivosPem + Path.GetFileName(rutaArchivoKey) + ".enc"))
                key = fileReader.ReadToEnd();

            for (int i = 0; i < dgvVisorRecibos.Rows.Count; i++)
            {
                progreso = ((i + 1) * 100) / dgvVisorRecibos.Rows.Count;
                workCancelarTodo.ReportProgress(progreso, "Cancelando...");

                uuids[i] = dgvVisorRecibos.Rows[i].Cells[4].Value.ToString();
                cancelacion(cer, key, uuids, int.Parse(dgvVisorRecibos.Rows[i].Cells[8].Value.ToString()));
            }

            if (totalNoCancelados != 0)
            {
                MessageBox.Show(String.Format("{0} recibos no fueron cancelados. Verifique.", totalNoCancelados.ToString()), "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cancelación exitosa.", "Información",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        private void workCancelarTodo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolLabelAvance.Text = e.ProgressPercentage.ToString() + "%";
            toolLabelEtapa.Text = e.UserState.ToString();
        }

        private void workCancelarTodo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolLabelAvance.Text = "100%";
            toolLabelEtapa.Text = "Proceso de cancelación terminado.";
            btnCancelarTodo.Enabled = true;
            ListaRecibos();
        }
    }
}

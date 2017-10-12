using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;
using Nominas.finkokProd;
//using Nominas.finkokDemo;

namespace Nominas
{
    public partial class frmVisorReciboNomina : Form
    {
        public frmVisorReciboNomina()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string directorioEmpresa = String.Empty;
        int emitidoXml = 0,totalRegistros = 0;
        List<Empresas.Core.Empresas> lstEmpresas;

        string rutaArchivos = String.Empty;
        string carpetaArchivoKey = String.Empty;
        string carpetaArchivoXslt = String.Empty;
        string rutaArchivoKey = String.Empty;
        string archivoXslt = String.Empty;
        string rutaArchivoXslt = String.Empty;
        string strCadenaOriginal = String.Empty;
        string strSello = String.Empty;
        #endregion

        #region VARIABLES PUBLICAS
        public int _periodo;
        #endregion


        private void frmVisorReciboNomina_Load(object sender, EventArgs e)
        {
            dgvVisorRecibos.RowHeadersVisible = false;
            dgvVisorRecibos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            chkTimbrados.Checked = true;
            chkNoTimbrados.Checked = true;

            if (rbtnOrdinaria.Checked)
                rbtnOrdinaria_CheckedChanged(sender, e);

            btnSellarTodo.Enabled = false;
            btnTimbrarTodo.Enabled = false;

            btnSellar.Enabled = false;
            btnTimbrar.Enabled = false;

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
                rutaArchivos = ch.obtenerValorConfiguracion(6).ToString();
                carpetaArchivoKey = ch.obtenerValorConfiguracion(8).ToString();
                carpetaArchivoXslt = ch.obtenerValorConfiguracion(9).ToString();
                archivoXslt = ch.obtenerValorConfiguracion(10).ToString();
                lstEmpresas = eh.obtenerDatosCertPac(GLOBALES.IDEMPRESA);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener la configuración de la aplicación. \r\n\r\nLa ventana se cerrará.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }
            

            directorioEmpresa = String.Format(@"{0}{1}\", rutaArchivos, GLOBALES.IDEMPRESA);
            rutaArchivoKey = String.Format(@"{0}{1}", carpetaArchivoKey, lstEmpresas[0].archivokey);
            rutaArchivoXslt = String.Format(@"{0}{1}", carpetaArchivoXslt, archivoXslt);

            if (!System.IO.Directory.Exists(directorioEmpresa))
            {
                System.IO.Directory.CreateDirectory(directorioEmpresa);
            }
           
        }

        void ListaRecibos(int emitido) 
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
                lstXml = xh.obtenerXmlPeriodo(GLOBALES.IDEMPRESA, DateTime.Parse(fechas[0]), DateTime.Parse(fechas[1]), emitido);
                lstEmpleados = eh.obtenerEmpleadosBaja(empleado);
                cnx.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No fue posible obtener el listado de recibos a timbrar.\r\n\r\nEsta ventana se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Dispose();
                this.Dispose();
            }

            var visor = from x in lstXml join e in lstEmpleados on x.idtrabajador equals e.idtrabajador 
                        select new 
                        {
                            x.idtrabajador,
                            emitido = (x.emitido == "N" || x.emitido == "T") ? false: true,
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
            lblRegistros.Text = totalRegistros.ToString();
            lblTimbrados.Text = totalTimbrados.ToString();
            lblPendientes.Text = totalPendientes.ToString();

            if (totalRegistros > 0)
            {
                btnSellarTodo.Enabled = true;
                btnSellar.Enabled = true;

                btnTimbrarTodo.Enabled = false;
                btnTimbrar.Enabled = false;

                btnErrores.Enabled = true;
            }
            else
            {
                btnSellarTodo.Enabled = false;
                btnSellar.Enabled = false;

                btnTimbrarTodo.Enabled = false;
                btnTimbrar.Enabled = false;

                btnErrores.Enabled = false;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (workSellarTodo.IsBusy)
            {
                MessageBox.Show("Información: No es posible realizar la acción hay un proceso en curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (workTimbrarTodo.IsBusy)
            {
                MessageBox.Show("Información: No es posible realizar la acción hay un proceso en curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (workSello.IsBusy)
            {
                MessageBox.Show("Información: No es posible realizar la acción hay un proceso en curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (workTrimbrado.IsBusy)
            {
                MessageBox.Show("Información: No es posible realizar la acción hay un proceso en curso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (chkTimbrados.Checked && chkNoTimbrados.Checked)
                emitidoXml = 2;
            else if (chkTimbrados.Checked && !chkNoTimbrados.Checked)
                emitidoXml = 0;
            else if (!chkTimbrados.Checked && chkNoTimbrados.Checked)
                emitidoXml = 1;
            else if (!chkTimbrados.Checked && !chkNoTimbrados.Checked)
                emitidoXml = 3;


            ListaRecibos(emitidoXml);
        }     

        private void button2_Click(object sender, EventArgs e)
        {

            //Nomina pruebaNomina = new Nomina();
            //pruebaNomina.OtrosPagos = otrosPagos;
            //pruebaNomina.OtrosPagosSpecified = true;
            //pruebaNomina.Incapacidades = new Incapacidad[2];
            //pruebaNomina.IncapacidadesSpecified = true;
            
            //for (int i = 0; i < 2; i++)
            //{
            //    Incapacidad incapacidad = new Incapacidad();  
            //    incapacidad.TipoIncapacidad = "01";
            //    incapacidad.DiasIncapacidad = 5;
            //    pruebaNomina.Incapacidades[i] = incapacidad;
            //}

        }


        //FUNCION QUE GENERA EL SELLO
        private string sellado(DataTable datosNomina, DataTable catalogo, int idTrabajador, string noEmpleado, string folio, DateTime fechaIngresoReal)
        {
            decimal totalGravado = 0, totalExento = 0;
            decimal totalDeducciones = 0, totalOtrosPagos = 0;
            int cantidadPercepciones = 0, cantidadDeducciones = 0;

            #region COMPLEMENTO NOMINA

            MemoryStream stream = new MemoryStream();
            XmlSerializerNamespaces xmlNameSpaceNomina = new XmlSerializerNamespaces();
            xmlNameSpaceNomina.Add("nomina12", "http://www.sat.gob.mx/nomina12");

            Nomina nomina = new Nomina();

            NominaEmisor emisorNomina = new NominaEmisor();
            emisorNomina.RegistroPatronal = datosNomina.Rows[0]["registropatronal"].ToString();
            if (catalogo.Rows[0]["tipocontrato"].ToString() == "09" ||
                catalogo.Rows[0]["tipocontrato"].ToString() == "10" ||
                catalogo.Rows[0]["tipocontrato"].ToString() == "99")
            {
                emisorNomina.RegistroPatronalSpecified = false;
            }
            else
            {
                emisorNomina.RegistroPatronalSpecified = true;
            }

            NominaReceptor receptorNomina = new NominaReceptor();
            receptorNomina.Curp = datosNomina.Rows[0]["curp"].ToString();
            receptorNomina.TipoContrato = catalogo.Rows[0]["tipocontrato"].ToString();
            receptorNomina.TipoRegimen = catalogo.Rows[0]["tiporegimen"].ToString();
            receptorNomina.NumEmpleado = datosNomina.Rows[0]["noempleado"].ToString();

            if (datosNomina.Rows[0]["tiponomina"].ToString() == "O")
                receptorNomina.PeriodicidadPago = datosNomina.Rows[0]["periodicidad"].ToString();
            else
                receptorNomina.PeriodicidadPago = "99";

            receptorNomina.ClaveEntFed = catalogo.Rows[0]["estado"].ToString();
            receptorNomina.FechaInicioRelLaboral = fechaIngresoReal;
            receptorNomina.FechaInicioRelLaboralSpecified = true;
            receptorNomina.NumSeguridadSocial = datosNomina.Rows[0]["nss"].ToString();
            receptorNomina.NumSeguridadSocialSpecified = true;
            receptorNomina.RiesgoPuesto = int.Parse(catalogo.Rows[0]["riesgopuesto"].ToString());
            receptorNomina.RiesgoPuestoSpecified = true;
            receptorNomina.SalarioDiarioIntegrado = decimal.Parse(datosNomina.Rows[0]["sdi"].ToString());
            receptorNomina.SalarioDiarioIntegradoSpecified = true;

            //DateTime fechaIngreso = DateTime.Parse(datosNomina.Rows[0]["fechaingreso"].ToString());
            DateTime fechaActual = DateTime.Parse(datosNomina.Rows[0]["fechafin"].ToString());
            TimeSpan ts = fechaActual - fechaIngresoReal;
            int antiguedad = (ts.Days + 1) / 7;
            receptorNomina.Antiguedad = String.Format("P{0}W", antiguedad);
            receptorNomina.AntiguedadSpecified = true;

            for (int t = 0; t < datosNomina.Rows.Count; t++)
            {
                totalGravado += decimal.Parse(datosNomina.Rows[t]["gravado"].ToString());
                totalExento += decimal.Parse(datosNomina.Rows[t]["exento"].ToString());

                if (datosNomina.Rows[t]["tipoconcepto"].ToString().Equals("P"))
                {
                    cantidadPercepciones++;
                }

                if (datosNomina.Rows[t]["tipoconcepto"].ToString().Equals("D"))
                {
                    totalDeducciones += decimal.Parse(datosNomina.Rows[t]["cantidad"].ToString());
                    cantidadDeducciones++;
                }

                if (datosNomina.Rows[t]["tipoconcepto"].ToString().Equals("S"))
                {
                    totalOtrosPagos += decimal.Parse(datosNomina.Rows[t]["cantidad"].ToString());
                }

            }

            Percepciones percepciones = new Percepciones();
            percepciones.TotalGravado = totalGravado;
            percepciones.TotalExento = totalExento;
            percepciones.TotalSueldosSpecified = true;
            percepciones.TotalSueldos = totalGravado + totalExento;
            percepciones.Percepcion = new Percepcion[cantidadPercepciones];


            Deducciones deducciones = new Deducciones();
            deducciones.Deduccion = new Deduccion[cantidadDeducciones];
            deducciones.TotalOtrasDeduccionesSpecified = true;

            if (totalDeducciones != 0)
                deducciones.TotalOtrasDeducciones = totalDeducciones;
            else
                deducciones.TotalOtrasDeducciones = (decimal)0.01;

            deducciones.TotalImpuestosRetenidosSpecified = false;

            int posicionP = 0, posicionD = 0;
            for (int m = 0; m < datosNomina.Rows.Count; m++)
            {
                if (datosNomina.Rows[m]["tipoconcepto"].ToString().Equals("P"))
                {
                    Percepcion percepcion = new Percepcion();
                    percepcion.TipoPercepcion = datosNomina.Rows[m]["valorcatsat"].ToString();
                    percepcion.Clave = datosNomina.Rows[m]["noconcepto"].ToString();
                    percepcion.ImporteGravado = decimal.Parse(datosNomina.Rows[m]["gravado"].ToString());
                    percepcion.ImporteExento = decimal.Parse(datosNomina.Rows[m]["exento"].ToString());
                    percepcion.Concepto = datosNomina.Rows[m]["concepto"].ToString();

                    if (datosNomina.Rows[m]["noconcepto"].ToString().Equals("002"))
                    {
                        NominaHorasExtra he = new NominaHorasExtra();
                        he.Dias = 6;
                        he.TipoHoras = "01";
                        he.HorasExtra = 18;
                        he.ImportePagado = decimal.Parse(datosNomina.Rows[m]["cantidad"].ToString());
                        percepcion.HorasExtraSpecified = true;
                        percepcion.HorasExtra = he;
                    }

                    percepciones.Percepcion[posicionP] = percepcion;
                    posicionP++;
                }
                else if (datosNomina.Rows[m]["tipoconcepto"].ToString().Equals("D"))
                {
                    Deduccion deduccion = new Deduccion();
                    deduccion.TipoDeduccion = datosNomina.Rows[m]["valorcatsat"].ToString();
                    deduccion.Clave = datosNomina.Rows[m]["noconcepto"].ToString();
                    deduccion.Importe = decimal.Parse(datosNomina.Rows[m]["cantidad"].ToString());
                    deduccion.Concepto = datosNomina.Rows[m]["concepto"].ToString();
                    deducciones.Deduccion[posicionD] = deduccion;
                    posicionD++;
                }
                else if (datosNomina.Rows[m]["tipoconcepto"].ToString().Equals("S"))
                {
                    SubsidioAlEmpleo subsidioAlEmpleo = new SubsidioAlEmpleo();
                    subsidioAlEmpleo.SubsidioCausado = decimal.Parse(datosNomina.Rows[m]["cantidad"].ToString());

                    OtroPago otropago = new OtroPago();
                    otropago.TipoOtroPago = datosNomina.Rows[m]["valorcatsat"].ToString();
                    otropago.Clave = datosNomina.Rows[m]["noconcepto"].ToString();
                    otropago.Importe = decimal.Parse(datosNomina.Rows[m]["cantidad"].ToString());
                    otropago.Concepto = datosNomina.Rows[m]["concepto"].ToString();
                    otropago.SubsidioAlEmpleo = subsidioAlEmpleo;
                    otropago.SubsidioAlEmpleoSpecified = true;

                    OtrosPagos otrosPagos = new OtrosPagos();
                    otrosPagos.OtroPago = otropago;
                    nomina.OtrosPagos = otrosPagos;
                    nomina.OtrosPagosSpecified = true;
                    nomina.TotalOtrosPagos = totalOtrosPagos;
                    nomina.TotalOtrosPagosSpecified = true;

                }
            }


            nomina.TipoNomina = datosNomina.Rows[0]["tiponomina"].ToString();
            nomina.FechaPago = DateTime.Parse(datosNomina.Rows[0]["fechapago"].ToString());
            nomina.FechaInicialPago = DateTime.Parse(datosNomina.Rows[0]["fechainicio"].ToString());
            nomina.FechaFinalPago = DateTime.Parse(datosNomina.Rows[0]["fechafin"].ToString());

            if (decimal.Parse(datosNomina.Rows[0]["diaslaborados"].ToString()) == 0)
                nomina.NumDiasPagados = (decimal)0.001;
            else
                nomina.NumDiasPagados = decimal.Parse(datosNomina.Rows[0]["diaslaborados"].ToString());

            nomina.TotalPercepcionesSpecified = true;
            nomina.TotalPercepciones = totalGravado + totalExento;
            nomina.TotalDeduccionesSpecified = true;

            if(totalDeducciones != 0)
                nomina.TotalDeducciones = totalDeducciones;
            else
                nomina.TotalDeducciones = (decimal)0.01;

            nomina.Emisor = emisorNomina;
            nomina.Receptor = receptorNomina;
            nomina.Percepciones = percepciones;
            nomina.Deducciones = deducciones;

            XmlDocument docNomina = new XmlDocument();
            XmlSerializer xmlSerializeNomina = new XmlSerializer(typeof(Nomina));

            using (var writer = new XmlTextWriter(stream, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;

                xmlSerializeNomina.Serialize(writer, nomina, xmlNameSpaceNomina);

                stream.Seek(0, SeekOrigin.Begin);

                docNomina.Load(stream);
            }

            #endregion

            #region COMPROBANTE FISCAL

            XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
            xmlNameSpace.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            xmlNameSpace.Add("nomina12", "http://www.sat.gob.mx/nomina12");
            //xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            //xmlNameSpace.Add("schemaLocation", "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd");


            XmlSerializer xmlSerialize = new XmlSerializer(typeof(Comprobante));

            Emisor emisor = new Emisor();
            emisor.Rfc = datosNomina.Rows[0]["rfcempresa"].ToString();
            emisor.Nombre = datosNomina.Rows[0]["empresa"].ToString();
            emisor.RegimenFiscal = datosNomina.Rows[0]["regimenfiscal"].ToString();

            Receptor receptor = new Receptor();
            receptor.Rfc = datosNomina.Rows[0]["rfc"].ToString();
            receptor.Nombre = datosNomina.Rows[0]["nombrecompleto"].ToString();
            receptor.UsoCFDI = "P01";

            ComplementoConcepto concepto = new ComplementoConcepto();
            concepto.ValorUnitario = totalExento + totalGravado + totalOtrosPagos;
            concepto.Importe = totalExento + totalGravado + totalOtrosPagos;
            if(totalDeducciones != 0)
                concepto.Descuento = totalDeducciones;
            else
                concepto.Descuento = (decimal)0.01;

            ComplementoConceptos conceptos = new ComplementoConceptos();
            conceptos.Concepto = concepto;

            Complemento complemento = new Complemento();
            complemento.Any = new XmlElement[] { docNomina.ImportNode(docNomina.DocumentElement, true) as XmlElement };

            Comprobante comprobante = new Comprobante();
            comprobante.Fecha = String.Format("{0:s}", DateTime.Now);
            comprobante.NoCertificado = datosNomina.Rows[0]["nocertificado"].ToString();
            comprobante.Certificado = datosNomina.Rows[0]["certificado"].ToString();
            comprobante.SubTotal = totalExento + totalGravado + totalOtrosPagos;

            if (totalDeducciones != 0)
            {
                comprobante.Descuento = totalDeducciones;
                comprobante.Total = (totalExento + totalGravado + totalOtrosPagos) - totalDeducciones;
            }
            else
            {
                comprobante.Descuento = (decimal)0.01;
                comprobante.Total = (totalExento + totalGravado + totalOtrosPagos) - (decimal)0.01;
            }

            comprobante.LugarExpedicion = datosNomina.Rows[0]["codigopostal"].ToString();
            comprobante.Emisor = emisor;
            comprobante.Receptor = receptor;
            comprobante.Conceptos = conceptos;
            comprobante.Complemento = complemento;

            XmlTextWriter xmlTextWriter = new XmlTextWriter(String.Format(@"{0}{1}_{2}.xml", directorioEmpresa,
                                                            folio,
                                                            noEmpleado),
                                                            Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlSerialize.Serialize(xmlTextWriter, comprobante, xmlNameSpace);

            xmlTextWriter.Close();

            #endregion

            #region SELLADO

            string pathXsltCadenaOriginal = rutaArchivoXslt;
            string pathXml = String.Format(@"{0}{1}_{2}.xml", directorioEmpresa,
                                                            folio,
                                                            noEmpleado);

            string pathTxt = String.Format(@"{0}{1}_{2}.txt", directorioEmpresa,
                                                            folio,
                                                            noEmpleado);


            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(pathXsltCadenaOriginal); //Path del archivo cadenaoriginal_3_3.xslt
            xslt.Transform(pathXml, pathTxt);

            strCadenaOriginal = File.ReadAllText(pathTxt);

            //Lectura del Archivo .KEY
            System.Security.SecureString passwordSeguro = new System.Security.SecureString();
            passwordSeguro.Clear();
            foreach (char c in lstEmpresas[0].passwordkey.ToCharArray())
                passwordSeguro.AppendChar(c);
            byte[] llavePrivadaBytes = System.IO.File.ReadAllBytes(rutaArchivoKey);
            RSACryptoServiceProvider rsa = opensslkey.DecodeEncryptedPrivateKeyInfo(llavePrivadaBytes, passwordSeguro);
            SHA256CryptoServiceProvider hasher = new SHA256CryptoServiceProvider();
            byte[] bytesFirmados = rsa.SignData(System.Text.Encoding.UTF8.GetBytes(strCadenaOriginal), hasher);
            strSello = Convert.ToBase64String(bytesFirmados);  // Y aquí está el sello
            //Lectura del Archivo .KEY

            StreamReader leer = new StreamReader(pathXml);
            XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
            Comprobante xmlComprobante = (Comprobante)serializer.Deserialize(leer);
            leer.Close();

            xmlComprobante.Sello = strSello;

            using (XmlTextWriter xmlTextWriterSello = new XmlTextWriter(String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, folio, noEmpleado), Encoding.UTF8))
            {
                xmlTextWriterSello.Formatting = Formatting.Indented;

                xmlSerialize.Serialize(xmlTextWriterSello, xmlComprobante, xmlNameSpace);

                xmlTextWriter.Close();
            }

            return String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, folio, noEmpleado);

            #endregion
        }



        //SELLADO MASIVO

        private void btnSellarTodo_Click(object sender, EventArgs e)
        {
            workSellarTodo.RunWorkerAsync();
        }

        private void workSellarTodo_DoWork(object sender, DoWorkEventArgs e)
        {
            bool timbrado = false;
            int progreso = 0;
            DateTime fechaIngreso;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            Historial.Core.HistorialHelper hh = new Historial.Core.HistorialHelper();
            hh.Command = cmd;

            DataTable dtComponenteNomina = new DataTable();
            DataTable dtNominaCatalogo = new DataTable();

            totalRegistros = dgvVisorRecibos.Rows.Count;

            for (int i = 0; i < dgvVisorRecibos.Rows.Count; i++)
            {
                timbrado = bool.Parse(dgvVisorRecibos.Rows[i].Cells[1].Value.ToString());

                if (!timbrado)
                {
                    cnx.Open();
                    dtComponenteNomina = xh.obtenerComplementoNomina(GLOBALES.IDEMPRESA,
                                                                    int.Parse(dgvVisorRecibos.Rows[i].Cells[0].Value.ToString()),
                                                                    DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[6].Value.ToString()).Date,
                                                                    DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[7].Value.ToString()).Date,
                                                                    _periodo);
                    dtNominaCatalogo = xh.obtenerCatalogoNomina(int.Parse(dgvVisorRecibos.Rows[i].Cells[0].Value.ToString()));
                    fechaIngreso = DateTime.Parse(hh.obtenerFechaImss(int.Parse(dgvVisorRecibos.Rows[i].Cells[0].Value.ToString()), 
                        DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[7].Value.ToString()).Date).ToString()).Date;
                        
                    cnx.Close();


                    /**********************************************/
                    /* Los recibos en 0 no deben ir timbrados */
                    /**********************************************/
                    if (dtComponenteNomina.Rows.Count != 0)
                    {
                        sellado(dtComponenteNomina, dtNominaCatalogo, int.Parse(dgvVisorRecibos.Rows[i].Cells[0].Value.ToString()),
                            dgvVisorRecibos.Rows[i].Cells[2].Value.ToString(),
                            dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(), 
                            fechaIngreso);

                        #region COMPLEMENTO NOMINA

                        //MemoryStream stream = new MemoryStream();
                        //XmlSerializerNamespaces xmlNameSpaceNomina = new XmlSerializerNamespaces();
                        //xmlNameSpaceNomina.Add("nomina12", "http://www.sat.gob.mx/nomina12");

                        //Nomina nomina = new Nomina();

                        //NominaEmisor emisorNomina = new NominaEmisor();
                        //emisorNomina.RegistroPatronal = dtComponenteNomina.Rows[0]["registropatronal"].ToString();
                        //if (dtNominaCatalogo.Rows[0]["tipocontrato"].ToString() == "09" ||
                        //    dtNominaCatalogo.Rows[0]["tipocontrato"].ToString() == "10" ||
                        //    dtNominaCatalogo.Rows[0]["tipocontrato"].ToString() == "99")
                        //{
                        //    emisorNomina.RegistroPatronalSpecified = false;
                        //}
                        //else {
                        //    emisorNomina.RegistroPatronalSpecified = true;
                        //}

                        //NominaReceptor receptorNomina = new NominaReceptor();
                        //receptorNomina.Curp = dtComponenteNomina.Rows[0]["curp"].ToString();
                        //receptorNomina.TipoContrato = dtNominaCatalogo.Rows[0]["tipocontrato"].ToString();
                        //receptorNomina.TipoRegimen = dtNominaCatalogo.Rows[0]["tiporegimen"].ToString();
                        //receptorNomina.NumEmpleado = dtComponenteNomina.Rows[0]["noempleado"].ToString();
                        //receptorNomina.PeriodicidadPago = dtComponenteNomina.Rows[0]["periodicidad"].ToString();
                        //receptorNomina.ClaveEntFed = dtNominaCatalogo.Rows[0]["estado"].ToString();
                        //receptorNomina.FechaInicioRelLaboral = DateTime.Parse(dtComponenteNomina.Rows[0]["fechaingreso"].ToString());
                        //receptorNomina.FechaInicioRelLaboralSpecified = true;
                        //receptorNomina.NumSeguridadSocial = dtComponenteNomina.Rows[0]["nss"].ToString();
                        //receptorNomina.NumSeguridadSocialSpecified = true;
                        //receptorNomina.RiesgoPuesto = int.Parse(dtNominaCatalogo.Rows[0]["riesgopuesto"].ToString());
                        //receptorNomina.RiesgoPuestoSpecified = true;
                        //receptorNomina.SalarioDiarioIntegrado = decimal.Parse(dtComponenteNomina.Rows[0]["sdi"].ToString());
                        //receptorNomina.SalarioDiarioIntegradoSpecified = true;

                        //DateTime fechaIngreso = DateTime.Parse(dtComponenteNomina.Rows[0]["fechaingreso"].ToString());
                        //DateTime fechaActual = DateTime.Parse(dtComponenteNomina.Rows[0]["fechapago"].ToString());
                        //TimeSpan ts = fechaActual - fechaIngreso;
                        //int antiguedad = ts.Days / 7;
                        //receptorNomina.Antiguedad = String.Format("P{0}W", antiguedad);
                        //receptorNomina.AntiguedadSpecified = true;

                        //for (int t = 0; t < dtComponenteNomina.Rows.Count; t++)
                        //{
                        //    totalGravado += decimal.Parse(dtComponenteNomina.Rows[t]["gravado"].ToString());
                        //    totalExento += decimal.Parse(dtComponenteNomina.Rows[t]["exento"].ToString());

                        //    if (dtComponenteNomina.Rows[t]["tipoconcepto"].ToString().Equals("P"))
                        //    {
                        //        cantidadPercepciones++;
                        //    }

                        //    if (dtComponenteNomina.Rows[t]["tipoconcepto"].ToString().Equals("D"))
                        //    {
                        //        totalDeducciones += decimal.Parse(dtComponenteNomina.Rows[t]["cantidad"].ToString());
                        //        cantidadDeducciones++;
                        //    }

                        //    if (dtComponenteNomina.Rows[t]["tipoconcepto"].ToString().Equals("S"))
                        //    {
                        //        totalOtrosPagos += decimal.Parse(dtComponenteNomina.Rows[t]["cantidad"].ToString());
                        //    }

                        //}

                        //Percepciones percepciones = new Percepciones();
                        //percepciones.TotalGravado = totalGravado;
                        //percepciones.TotalExento = totalExento;
                        //percepciones.TotalSueldosSpecified = true;
                        //percepciones.TotalSueldos = totalGravado + totalExento;
                        //percepciones.Percepcion = new Percepcion[cantidadPercepciones];


                        //Deducciones deducciones = new Deducciones();
                        //deducciones.Deduccion = new Deduccion[cantidadDeducciones];
                        //deducciones.TotalOtrasDeduccionesSpecified = true;
                        //deducciones.TotalOtrasDeducciones = totalDeducciones;
                        //deducciones.TotalImpuestosRetenidosSpecified = false;

                        //int posicionP = 0, posicionD = 0;
                        //for (int m = 0; m < dtComponenteNomina.Rows.Count; m++)
                        //{
                        //    if (dtComponenteNomina.Rows[m]["tipoconcepto"].ToString().Equals("P"))
                        //    {
                        //        Percepcion percepcion = new Percepcion();
                        //        percepcion.TipoPercepcion = dtComponenteNomina.Rows[m]["valorcatsat"].ToString();
                        //        percepcion.Clave = dtComponenteNomina.Rows[m]["noconcepto"].ToString();
                        //        percepcion.ImporteGravado = decimal.Parse(dtComponenteNomina.Rows[m]["gravado"].ToString());
                        //        percepcion.ImporteExento = decimal.Parse(dtComponenteNomina.Rows[m]["exento"].ToString());
                        //        percepcion.Concepto = dtComponenteNomina.Rows[m]["concepto"].ToString();

                        //        if (dtComponenteNomina.Rows[m]["noconcepto"].ToString().Equals("002"))
                        //        {
                        //            NominaHorasExtra he = new NominaHorasExtra();
                        //            he.Dias = 6;
                        //            he.TipoHoras = "01";
                        //            he.HorasExtra = 18;
                        //            he.ImportePagado = decimal.Parse(dtComponenteNomina.Rows[m]["cantidad"].ToString());
                        //            percepcion.HorasExtraSpecified = true;
                        //            percepcion.HorasExtra = he;
                        //        }

                        //        percepciones.Percepcion[posicionP] = percepcion;
                        //        posicionP++;
                        //    }
                        //    else if (dtComponenteNomina.Rows[m]["tipoconcepto"].ToString().Equals("D"))
                        //    {
                        //        Deduccion deduccion = new Deduccion();
                        //        deduccion.TipoDeduccion = dtComponenteNomina.Rows[m]["valorcatsat"].ToString();
                        //        deduccion.Clave = dtComponenteNomina.Rows[m]["noconcepto"].ToString();
                        //        deduccion.Importe = decimal.Parse(dtComponenteNomina.Rows[m]["cantidad"].ToString());
                        //        deduccion.Concepto = dtComponenteNomina.Rows[m]["concepto"].ToString();
                        //        deducciones.Deduccion[posicionD] = deduccion;
                        //        posicionD++;
                        //    }
                        //    else if (dtComponenteNomina.Rows[m]["tipoconcepto"].ToString().Equals("S"))
                        //    {
                        //        SubsidioAlEmpleo subsidioAlEmpleo = new SubsidioAlEmpleo();
                        //        subsidioAlEmpleo.SubsidioCausado = decimal.Parse(dtComponenteNomina.Rows[m]["cantidad"].ToString());

                        //        OtroPago otropago = new OtroPago();
                        //        otropago.TipoOtroPago = dtComponenteNomina.Rows[m]["valorcatsat"].ToString();
                        //        otropago.Clave = dtComponenteNomina.Rows[m]["noconcepto"].ToString();
                        //        otropago.Importe = decimal.Parse(dtComponenteNomina.Rows[m]["cantidad"].ToString());
                        //        otropago.Concepto = dtComponenteNomina.Rows[m]["concepto"].ToString();
                        //        otropago.SubsidioAlEmpleo = subsidioAlEmpleo;
                        //        otropago.SubsidioAlEmpleoSpecified = true;

                        //        OtrosPagos otrosPagos = new OtrosPagos();
                        //        otrosPagos.OtroPago = otropago;
                        //        nomina.OtrosPagos = otrosPagos;
                        //        nomina.OtrosPagosSpecified = true;
                        //        nomina.TotalOtrosPagos = totalOtrosPagos;
                        //        nomina.TotalOtrosPagosSpecified = true;

                        //    }
                        //}


                        //nomina.TipoNomina = dtComponenteNomina.Rows[0]["tiponomina"].ToString();
                        //nomina.FechaPago = DateTime.Parse(dtComponenteNomina.Rows[0]["fechapago"].ToString());
                        //nomina.FechaInicialPago = DateTime.Parse(dtComponenteNomina.Rows[0]["fechainicio"].ToString());
                        //nomina.FechaFinalPago = DateTime.Parse(dtComponenteNomina.Rows[0]["fechafin"].ToString());
                        //nomina.NumDiasPagados = decimal.Parse(dtComponenteNomina.Rows[0]["diaslaborados"].ToString());
                        //nomina.TotalPercepcionesSpecified = true;
                        //nomina.TotalPercepciones = totalGravado + totalExento;
                        //nomina.TotalDeduccionesSpecified = true;
                        //nomina.TotalDeducciones = totalDeducciones;

                        //nomina.Emisor = emisorNomina;
                        //nomina.Receptor = receptorNomina;
                        //nomina.Percepciones = percepciones;
                        //nomina.Deducciones = deducciones;

                        //XmlDocument docNomina = new XmlDocument();
                        //XmlSerializer xmlSerializeNomina = new XmlSerializer(typeof(Nomina));

                        //using (var writer = new XmlTextWriter(stream, Encoding.UTF8))
                        //{
                        //    writer.Formatting = Formatting.Indented;

                        //    xmlSerializeNomina.Serialize(writer, nomina, xmlNameSpaceNomina);

                        //    stream.Seek(0, SeekOrigin.Begin);

                        //    docNomina.Load(stream);
                        //}

                        #endregion

                        #region COMPROBANTE FISCAL

                        //XmlSerializerNamespaces xmlNameSpace = new XmlSerializerNamespaces();
                        //xmlNameSpace.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
                        //xmlNameSpace.Add("nomina12", "http://www.sat.gob.mx/nomina12");
                        ////xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                        ////xmlNameSpace.Add("schemaLocation", "http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd");


                        //XmlSerializer xmlSerialize = new XmlSerializer(typeof(Comprobante));

                        //Emisor emisor = new Emisor();
                        //emisor.Rfc = dtComponenteNomina.Rows[0]["rfcempresa"].ToString();
                        //emisor.Nombre = dtComponenteNomina.Rows[0]["empresa"].ToString();
                        //emisor.RegimenFiscal = dtComponenteNomina.Rows[0]["regimenfiscal"].ToString();

                        //Receptor receptor = new Receptor();
                        //receptor.Rfc = dtComponenteNomina.Rows[0]["rfc"].ToString();
                        //receptor.Nombre = dtComponenteNomina.Rows[0]["nombrecompleto"].ToString();
                        //receptor.UsoCFDI = "P01";

                        //ComplementoConcepto concepto = new ComplementoConcepto();
                        //concepto.ValorUnitario = totalExento + totalGravado + totalOtrosPagos;
                        //concepto.Importe = totalExento + totalGravado + totalOtrosPagos;
                        //concepto.Descuento = totalDeducciones;

                        //ComplementoConceptos conceptos = new ComplementoConceptos();
                        //conceptos.Concepto = concepto;

                        //Complemento complemento = new Complemento();
                        //complemento.Any = new XmlElement[] { docNomina.ImportNode(docNomina.DocumentElement, true) as XmlElement };

                        //Comprobante comprobante = new Comprobante();
                        //comprobante.Fecha = String.Format("{0:s}", DateTime.Now);
                        //comprobante.NoCertificado = dtComponenteNomina.Rows[0]["nocertificado"].ToString();
                        //comprobante.Certificado = dtComponenteNomina.Rows[0]["certificado"].ToString();
                        //comprobante.SubTotal = totalExento + totalGravado + totalOtrosPagos;
                        //comprobante.Descuento = totalDeducciones;
                        //comprobante.Total = (totalExento + totalGravado + totalOtrosPagos) - totalDeducciones;
                        //comprobante.LugarExpedicion = dtComponenteNomina.Rows[0]["codigopostal"].ToString();
                        //comprobante.Emisor = emisor;
                        //comprobante.Receptor = receptor;
                        //comprobante.Conceptos = conceptos;
                        //comprobante.Complemento = complemento;

                        //XmlTextWriter xmlTextWriter = new XmlTextWriter(String.Format(@"{0}{1}_{2}.xml", directorioEmpresa,
                        //                                                dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(),
                        //                                                dgvVisorRecibos.Rows[i].Cells[2].Value.ToString()),
                        //                                                Encoding.UTF8);
                        //xmlTextWriter.Formatting = Formatting.Indented;
                        //xmlSerialize.Serialize(xmlTextWriter, comprobante, xmlNameSpace);

                        //xmlTextWriter.Close();

                        #endregion

                        #region SELLADO

                        //string pathXsltCadenaOriginal = rutaArchivoXslt;
                        //string pathXml = String.Format(@"{0}{1}_{2}.xml", directorioEmpresa,
                        //                                                dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(),
                        //                                                dgvVisorRecibos.Rows[i].Cells[2].Value.ToString());

                        //string pathTxt = String.Format(@"{0}{1}_{2}.txt", directorioEmpresa,
                        //                                                dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(),
                        //                                                dgvVisorRecibos.Rows[i].Cells[2].Value.ToString());


                        //XslCompiledTransform xslt = new XslCompiledTransform();
                        //xslt.Load(pathXsltCadenaOriginal); //Path del archivo cadenaoriginal_3_3.xslt
                        //xslt.Transform(pathXml, pathTxt);

                        //strCadenaOriginal = File.ReadAllText(pathTxt);

                        ////Lectura del Archivo .KEY
                        //System.Security.SecureString passwordSeguro = new System.Security.SecureString();
                        //passwordSeguro.Clear();
                        //foreach (char c in lstEmpresas[0].passwordkey.ToCharArray())
                        //    passwordSeguro.AppendChar(c);
                        //byte[] llavePrivadaBytes = System.IO.File.ReadAllBytes(rutaArchivoKey);
                        //RSACryptoServiceProvider rsa = opensslkey.DecodeEncryptedPrivateKeyInfo(llavePrivadaBytes, passwordSeguro);
                        //SHA256CryptoServiceProvider hasher = new SHA256CryptoServiceProvider();
                        //byte[] bytesFirmados = rsa.SignData(System.Text.Encoding.UTF8.GetBytes(strCadenaOriginal), hasher);
                        //strSello = Convert.ToBase64String(bytesFirmados);  // Y aquí está el sello
                        ////Lectura del Archivo .KEY

                        //StreamReader leer = new StreamReader(pathXml);
                        //XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                        //Comprobante xmlComprobante = (Comprobante)serializer.Deserialize(leer);
                        //leer.Close();

                        //xmlComprobante.Sello = strSello;

                        //XmlTextWriter xmlTextWriterSello = new XmlTextWriter(String.Format(@"{0}{1}_{2}.xml", directorioEmpresa,
                        //                                                dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(),
                        //                                                dgvVisorRecibos.Rows[i].Cells[2].Value.ToString()),
                        //                                                Encoding.UTF8);
                        //xmlTextWriter.Formatting = Formatting.Indented;
                        //xmlSerialize.Serialize(xmlTextWriterSello, xmlComprobante, xmlNameSpace);

                        //xmlTextWriter.Close();
                        //xmlTextWriter.Dispose();

                        #endregion

                    }
                }

                progreso = ((i + 1) * 100) / totalRegistros;
                workSellarTodo.ReportProgress(progreso, "Generacion y sellado.");
                
            }

            cnx.Dispose();
        }

        private void workSellarTodo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolLabelEtapa.Text = e.UserState.ToString();
            toolLabelAvance.Text = e.ProgressPercentage + "%";
        }

        private void workSellarTodo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolLabelEtapa.Text = "Sellado completado.";
            toolLabelAvance.Text = "100%";
            btnTimbrarTodo.Enabled = true;
        }




        //TIMBRADO MASIVO

        private void btnTimbrarTodo_Click(object sender, EventArgs e)
        {
            workTimbrarTodo.RunWorkerAsync();
        }

        private void workTimbrarTodo_DoWork(object sender, DoWorkEventArgs e)
        {
            string erroresXml = String.Empty, sello = String.Empty;
            int progreso = 0, noTimbrados = 0;
            bool timbrado = false;
            string rfcEmpresa = String.Empty, rfcTrabajador = String.Empty, totalXml = String.Empty;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            for (int i = 0; i < dgvVisorRecibos.Rows.Count; i++)
			{
                progreso = ((i + 1) * 100) / dgvVisorRecibos.Rows.Count;
                workTimbrarTodo.ReportProgress(progreso, "Timbrando.");

                timbrado = bool.Parse(dgvVisorRecibos.Rows[i].Cells[1].Value.ToString());

                rfcEmpresa = String.Empty;
                rfcTrabajador = String.Empty;
                totalXml = String.Empty;
                sello = String.Empty;

                if (!timbrado)
                {
                    if (File.Exists(String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(),
                                                   dgvVisorRecibos.Rows[i].Cells[2].Value.ToString())))
                    {
                        #region FINKOK
                        erroresXml = String.Empty;
                        //DLL FInkok
                        StampSOAP selloSOAP = new StampSOAP();
                        quick_stamp oStamp = new quick_stamp();
                        quick_stampResponse selloRespose = new quick_stampResponse();

                        Xml.Core.XmlCabecera cabecera = new Xml.Core.XmlCabecera();
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, dgvVisorRecibos.Rows[i].Cells[8].Value.ToString(),
                                                       dgvVisorRecibos.Rows[i].Cells[2].Value.ToString()));

                        byte[] byteXmlDocument = Encoding.UTF8.GetBytes(xmlDocument.OuterXml);
                        string stringByteXmlDocument = Convert.ToBase64String(byteXmlDocument);
                        byteXmlDocument = Convert.FromBase64String(stringByteXmlDocument);

                        oStamp.xml = byteXmlDocument;
                        oStamp.username = lstEmpresas[0].usuariopac;
                        oStamp.password = lstEmpresas[0].passwordpac;

                        try
                        {
                            selloRespose = selloSOAP.quick_stamp(oStamp);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Servicio Finkok: No es posible conectarte con el PAC.\r\n" + err, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                        //SI HAY ERROR EN EL TIMBRADO DEVUELVE NULO EN LA PROPIEDAD CODESTATUS
                        if (selloRespose.quick_stampResult.CodEstatus == null)
                        {
                            for (int j = 0; j < selloRespose.quick_stampResult.Incidencias.Length; j++)
                            {
                                erroresXml += String.Format("Codigo error: {0}, Descripcion {1}\r\n", selloRespose.quick_stampResult.Incidencias[j].CodigoError, selloRespose.quick_stampResult.Incidencias[j].MensajeIncidencia);
                            }

                            cabecera.folio = int.Parse(dgvVisorRecibos.Rows[i].Cells[8].Value.ToString());
                            cabecera.error = erroresXml;

                            noTimbrados++;

                            try
                            {
                                cnx.Open();
                                xh.actualizaXmlCabeceraError(cabecera);
                                cnx.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Error: No fue posible actualizar el timbre. La operación se detendrá.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cnx.Dispose();
                                return;
                            }
                            
                        }
                        //SI ES TIMBRADO CORRECTAMENTE DEVUELVE "Comprobante timbrado satisfactoriamente" EN LA PROPIEDAD CODESTATUS
                        else if (selloRespose.quick_stampResult.CodEstatus.Equals("Comprobante timbrado satisfactoriamente") || selloRespose.quick_stampResult.CodEstatus.Equals("Comprobante timbrado previamente"))
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.LoadXml(selloRespose.quick_stampResult.xml);


                            System.Xml.XmlNodeList timbreFiscal = doc.GetElementsByTagName("tfd:TimbreFiscalDigital");
                            foreach (System.Xml.XmlElement nodo in timbreFiscal)
                            {
                                cabecera.versiontimbrefiscal = nodo.GetAttribute("Version");
                                cabecera.sellocfd = nodo.GetAttribute("SelloCFD");
                            }

                            System.Xml.XmlNodeList comprobanteXml = doc.GetElementsByTagName("cfdi:Comprobante");
                            foreach (System.Xml.XmlElement nodo in comprobanteXml)
                            {
                                cabecera.nocertificado = nodo.GetAttribute("NoCertificado");
                                totalXml = nodo.GetAttribute("Total");
                            }

                            System.Xml.XmlNodeList emisorXml = doc.GetElementsByTagName("cfdi:Emisor");
                            foreach (System.Xml.XmlElement nodo in emisorXml)
                            {
                                rfcEmpresa = nodo.GetAttribute("Rfc");
                            }

                            System.Xml.XmlNodeList receptorXml = doc.GetElementsByTagName("cfdi:Receptor");
                            foreach (System.Xml.XmlElement nodo in receptorXml)
                            {
                                rfcTrabajador = nodo.GetAttribute("Rfc");
                            }

                            cabecera.emitido = "S";
                            cabecera.nocertificado = "";
                            cabecera.versiontimbrefiscal = "1.2";
                            cabecera.uuid = selloRespose.quick_stampResult.UUID;
                            cabecera.fechatimbrado = selloRespose.quick_stampResult.Fecha;
                            cabecera.nocertificadosat = selloRespose.quick_stampResult.NoCertificadoSAT;
                            cabecera.sellosat = selloRespose.quick_stampResult.SatSeal;
                            cabecera.xml = selloRespose.quick_stampResult.xml;
                            cabecera.folio = int.Parse(dgvVisorRecibos.Rows[i].Cells[8].Value.ToString());
                            cabecera.error = "Comprobante timbrado satisfactoriamente";
                            cabecera.codeqr = codigoQr(rfcEmpresa, rfcTrabajador, selloRespose.quick_stampResult.UUID, totalXml);

                            try
                            {
                                cnx.Open();
                                xh.actualizaXmlCabecera(cabecera);
                                xh.insertaCfdiMaster(GLOBALES.IDEMPRESA, int.Parse(dgvVisorRecibos.Rows[i].Cells[0].Value.ToString()),
                                                    DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[6].Value.ToString()).Date,
                                                    DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[7].Value.ToString()).Date);
                                xh.insertaCfdiDetalle(GLOBALES.IDEMPRESA, int.Parse(dgvVisorRecibos.Rows[i].Cells[0].Value.ToString()),
                                                    DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[6].Value.ToString()).Date,
                                                    DateTime.Parse(dgvVisorRecibos.Rows[i].Cells[7].Value.ToString()).Date);
                                cnx.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Error: No fue posible actualizar el timbre. La operación se detendrá.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cnx.Dispose();
                                return;
                            }
                            
                        }
                        #endregion
                    }
                }
			}

            cnx.Dispose();

            if (noTimbrados > 0)
            {
                MessageBox.Show(String.Format("Información: {0} registros no fueron timbrados. \r\n\r\n" +
                                              "Para visualizar los errores:\r\n" + 
                                              "1. Doble click sobre el registro.\r\n" +
                                              "2. Click botón \"Errores\"", noTimbrados),"Información", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                
            }
        }

        private void workTimbrarTodo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolLabelEtapa.Text = e.UserState.ToString();
            toolLabelAvance.Text = e.ProgressPercentage + "%";
        }

        private void workTimbrarTodo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolLabelEtapa.Text = "Timbrado completado.";
            toolLabelAvance.Text = "100%";

            if (chkTimbrados.Checked && chkNoTimbrados.Checked)
                emitidoXml = 2;
            else if (chkTimbrados.Checked && !chkNoTimbrados.Checked)
                emitidoXml = 0;
            else if (!chkTimbrados.Checked && chkNoTimbrados.Checked)
                emitidoXml = 1;
            else if (!chkTimbrados.Checked && !chkNoTimbrados.Checked)
                emitidoXml = 3;

            ListaRecibos(emitidoXml);
            btnErrores.Enabled = true;

            string[] archivos = System.IO.Directory.GetFiles(directorioEmpresa);
            foreach (string archivo in archivos)
            {
                File.Delete(archivo);
            }
        }




        //SELLO INDIVIDUAL

        private void btnSellar_Click(object sender, EventArgs e)
        {
            workSello.RunWorkerAsync();
        }

        private void workSello_DoWork(object sender, DoWorkEventArgs e)
        {
            bool timbrado = false;
            int fila = 0;
            string archivo = String.Empty;
            DateTime fechaIngreso;

            workSello.ReportProgress(0, "Sellando, por favor espere...");

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            Historial.Core.HistorialHelper hh = new Historial.Core.HistorialHelper();
            hh.Command = cmd;

            DataTable dtComponenteNomina = new DataTable();
            DataTable dtNominaCatalogo = new DataTable();

            fila = dgvVisorRecibos.CurrentCell.RowIndex;
            timbrado = bool.Parse(dgvVisorRecibos.Rows[fila].Cells[1].Value.ToString()); //Valor de celda de la columan Timbrado.

            if (!timbrado)
            {
                cnx.Open();
                dtComponenteNomina = xh.obtenerComplementoNomina(GLOBALES.IDEMPRESA,
                                                                int.Parse(dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString()),
                                                                DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[6].Value.ToString()).Date,
                                                                DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[7].Value.ToString()).Date,
                                                                _periodo);
                dtNominaCatalogo = xh.obtenerCatalogoNomina(int.Parse(dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString()));

                fechaIngreso = DateTime.Parse(hh.obtenerFechaImss(int.Parse(dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString()),
                        DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[7].Value.ToString()).Date).ToString()).Date;

                cnx.Close();


                /**********************************************/
                /* Los recibos en 0 no deben ir timbrados */
                /**********************************************/
                if (dtComponenteNomina.Rows.Count != 0)
                {
                    archivo = sellado(dtComponenteNomina, dtNominaCatalogo, int.Parse(dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString()),
                        dgvVisorRecibos.Rows[fila].Cells[2].Value.ToString(),
                        dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString(), 
                        fechaIngreso);

                }
                else
                {
                    MessageBox.Show("Información: El empleado no puede ser timbrado, recibo en 0.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            
            cnx.Dispose();
        }

        private void workSello_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolLabelEtapa.Text = e.UserState.ToString();
            toolLabelAvance.Text = "";
        }

        private void workSello_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolLabelEtapa.Text = "Sellado concluido.";
            toolLabelAvance.Text = "";
            btnTimbrar.Enabled = true;
            workSello.Dispose();
        }




        //TIMBRADO INDIVIDUAL

        private void btnTimbrar_Click(object sender, EventArgs e)
        {
            int fila = dgvVisorRecibos.CurrentCell.RowIndex;
            string archivo = String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString(),
                             dgvVisorRecibos.Rows[fila].Cells[2].Value.ToString());
            if (File.Exists(archivo))
                workTrimbrado.RunWorkerAsync();
            else
            {
                MessageBox.Show("Error: No se ha sellado el XML. Favor de sellar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void workTrimbrado_DoWork(object sender, DoWorkEventArgs e)
        {
            string erroresXml = String.Empty;
            int fila = dgvVisorRecibos.CurrentCell.RowIndex;
            string archivo = String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString(),
                             dgvVisorRecibos.Rows[fila].Cells[2].Value.ToString());
            string rfcEmpresa = String.Empty, rfcTrabajador = String.Empty, totalXml = String.Empty;

            workTrimbrado.ReportProgress(0, "Timbrando, por favor espere...");

            #region FINKOK

            //DLL FInkok
            
            StampSOAP selloSOAP = new StampSOAP();
            quick_stamp oStamp = new quick_stamp();
            quick_stampResponse selloRespose = new quick_stampResponse();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(archivo);

            byte[] byteXmlDocument = Encoding.UTF8.GetBytes(xmlDocument.OuterXml);
            string stringByteXmlDocument = Convert.ToBase64String(byteXmlDocument);
            byteXmlDocument = Convert.FromBase64String(stringByteXmlDocument);

            oStamp.xml = byteXmlDocument;
            oStamp.username = lstEmpresas[0].usuariopac;
            oStamp.password = lstEmpresas[0].passwordpac;

            try
            {
                selloRespose = selloSOAP.quick_stamp(oStamp);
            }
            catch (Exception err)
            {
                MessageBox.Show("Servicio Finkok: No es posible conectarte con el PAC.\r\n" + err, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            SqlConnection cnxTimbrado = new SqlConnection(cdn);
            SqlCommand cmdTimbrado = new SqlCommand();
            cmdTimbrado.Connection = cnxTimbrado;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmdTimbrado;

            Xml.Core.XmlCabecera cabecera = new Xml.Core.XmlCabecera();

            if (selloRespose.quick_stampResult.CodEstatus == null)
            {
                for (int j = 0; j < selloRespose.quick_stampResult.Incidencias.Length; j++)
                {
                    erroresXml += String.Format("Codigo error: {0}, Descripcion {1}\r\n", selloRespose.quick_stampResult.Incidencias[j].CodigoError, selloRespose.quick_stampResult.Incidencias[j].MensajeIncidencia);
                }

                cabecera.folio = int.Parse(dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString());
                cabecera.error = erroresXml;

                try
                {
                    cnxTimbrado.Open();
                    xh.actualizaXmlCabeceraError(cabecera);
                    cnxTimbrado.Close();
                }
                catch 
                {
                    MessageBox.Show("Error: No fue posible actualizar el timbre. La operación se detendrá.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnx.Dispose();
                    return;
                }
               

                MessageBox.Show("Información: Error al timbrar el XML. Verifique el motivo haciedo doble-click en el registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else if (selloRespose.quick_stampResult.CodEstatus.Equals("Comprobante timbrado satisfactoriamente") || selloRespose.quick_stampResult.CodEstatus.Equals("Comprobante timbrado previamente"))
            {
                
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(selloRespose.quick_stampResult.xml);


                System.Xml.XmlNodeList timbreFiscal = doc.GetElementsByTagName("tfd:TimbreFiscalDigital");
                foreach (System.Xml.XmlElement nodo in timbreFiscal)
                {
                    cabecera.versiontimbrefiscal = nodo.GetAttribute("Version");
                    cabecera.sellocfd = nodo.GetAttribute("SelloCFD");
                }

                System.Xml.XmlNodeList comprobanteXml = doc.GetElementsByTagName("cfdi:Comprobante");
                foreach (System.Xml.XmlElement nodo in comprobanteXml)
                {
                    cabecera.nocertificado = nodo.GetAttribute("NoCertificado");
                    totalXml = nodo.GetAttribute("Total");
                }

                System.Xml.XmlNodeList emisorXml = doc.GetElementsByTagName("cfdi:Emisor");
                foreach (System.Xml.XmlElement nodo in emisorXml)
                {
                    rfcEmpresa = nodo.GetAttribute("Rfc");
                }

                System.Xml.XmlNodeList receptorXml = doc.GetElementsByTagName("cfdi:Receptor");
                foreach (System.Xml.XmlElement nodo in receptorXml)
                {
                    rfcTrabajador = nodo.GetAttribute("Rfc");
                }

                cabecera.emitido = "S";
                cabecera.uuid = selloRespose.quick_stampResult.UUID;
                cabecera.fechatimbrado = selloRespose.quick_stampResult.Fecha;
                cabecera.nocertificadosat = selloRespose.quick_stampResult.NoCertificadoSAT;
                cabecera.sellosat = selloRespose.quick_stampResult.SatSeal;
                cabecera.xml = selloRespose.quick_stampResult.xml;
                cabecera.error = "Comprobante timbrado satisfactoriamente";
                cabecera.folio = int.Parse(dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString());
                cabecera.codeqr = codigoQr(rfcEmpresa, rfcTrabajador, selloRespose.quick_stampResult.UUID, totalXml);

                try
                {
                    cnxTimbrado.Open();
                    xh.actualizaXmlCabecera(cabecera);
                    xh.insertaCfdiMaster(GLOBALES.IDEMPRESA, int.Parse(dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString()),
                                                        DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[6].Value.ToString()).Date,
                                                        DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[7].Value.ToString()).Date);

                    xh.insertaCfdiDetalle(GLOBALES.IDEMPRESA, int.Parse(dgvVisorRecibos.Rows[fila].Cells[0].Value.ToString()),
                                        DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[6].Value.ToString()).Date,
                                        DateTime.Parse(dgvVisorRecibos.Rows[fila].Cells[7].Value.ToString()).Date);
                    cnxTimbrado.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: No fue posible actualizar el timbre. La operación se detendrá.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnx.Dispose();
                    return;
                }
                

                MessageBox.Show("Información: XML Timbrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cnxTimbrado.Dispose();
            #endregion
        }

        private void workTrimbrado_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolLabelEtapa.Text = e.UserState.ToString();
            toolLabelAvance.Text = "";
        }

        private void workTrimbrado_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolLabelEtapa.Text = "Timbrado concluido.";
            toolLabelAvance.Text = "";

            int fila = dgvVisorRecibos.CurrentCell.RowIndex;
            string archivo = String.Format(@"{0}{1}_{2}.xml", directorioEmpresa, dgvVisorRecibos.Rows[fila].Cells[8].Value.ToString(),
                             dgvVisorRecibos.Rows[fila].Cells[2].Value.ToString());
            File.Delete(archivo);
            
            if (chkTimbrados.Checked && chkNoTimbrados.Checked)
                emitidoXml = 2;
            else if (chkTimbrados.Checked && !chkNoTimbrados.Checked)
                emitidoXml = 0;
            else if (!chkTimbrados.Checked && chkNoTimbrados.Checked)
                emitidoXml = 1;
            else if (!chkTimbrados.Checked && !chkNoTimbrados.Checked)
                emitidoXml = 3;

            ListaRecibos(emitidoXml);
            btnErrores.Enabled = true;
            
        }





        private void dgvVisorRecibos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("Información de timbre. \r\n\r\n" +
                            "Empleado: " + dgvVisorRecibos.Rows[e.RowIndex].Cells[2].Value.ToString() + " \r\n" +
                            "Periodo: " + dgvVisorRecibos.Rows[e.RowIndex].Cells[6].Value.ToString() + " al " + dgvVisorRecibos.Rows[e.RowIndex].Cells[7].Value.ToString() + " \r\n" +
                            "Descripción: \r\n" +
                            dgvVisorRecibos.Rows[e.RowIndex].Cells[9].Value.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private Byte[] codigoQr(string re, string rr, string uuid, string tt) 
        {
            #region CODIGO QR

            string codigoQR = "";
            string[] valores = null;
            string vEntero = "";
            string vDecimal = "";

            valores = tt.Split('.');
            vEntero = valores[0];
            vDecimal = valores[1];
            codigoQR = string.Format("?re={0}&rr={1}&tt={2}.{3}&id={4}", re, rr,
                vEntero.PadLeft(10, '0'), vDecimal.PadRight(6, '0'), uuid);
            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrEncoder.Encode(codigoQR);
            var renderer = new GraphicsRenderer(new FixedModuleSize(2, QuietZoneModules.Two), Brushes.Black, Brushes.White);

            using (var stream = new FileStream(uuid + ".png", FileMode.Create))
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);

            Bitmap bmp = new Bitmap(uuid + ".png");
            Byte[] qr = GLOBALES.IMAGEN_BYTES(bmp);
            bmp.Dispose();
            File.Delete(uuid + ".png");

            return qr;
            #endregion
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

        private void rbtnOrdinaria_CheckedChanged(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            List<Xml.Core.XmlCabecera> lstPeriodosXml = new List<Xml.Core.XmlCabecera>();

            cnx.Open();
            lstPeriodosXml = xh.obtenerPeriodosSinTimbrar(GLOBALES.IDEMPRESA, 0, _periodo);
            cnx.Close();
            cnx.Dispose();

            cmbPeriodos.DataSource = lstPeriodosXml.ToList();
            cmbPeriodos.DisplayMember = "xml";
        }

        private void rbtnExtraordinario_CheckedChanged(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            List<Xml.Core.XmlCabecera> lstPeriodosXml = new List<Xml.Core.XmlCabecera>();

            cnx.Open();
            lstPeriodosXml = xh.obtenerPeriodosSinTimbrar(GLOBALES.IDEMPRESA, 2, _periodo);
            cnx.Close();
            cnx.Dispose();

            cmbPeriodos.DataSource = lstPeriodosXml.ToList();
            cmbPeriodos.DisplayMember = "xml";
        }
        
    }
}

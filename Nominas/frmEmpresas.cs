using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Nominas
{
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        Empresas.Core.EmpresasHelper eh;
        Direccion.Core.DireccionesHelper dh;
        Imagen.Core.ImagenesHelper ih;
        Bitmap bmp;
        DateTime inicioPeriodo, finPeriodo;
        bool ImagenAsignada = false;
        bool FLAG_KEY = false;
        bool FLAG_CERT = false;
        bool ERROR = false;
        string noCertificado = String.Empty;
        #endregion
        
        #region DELEGADOS
        public delegate void delOnNuevaEmpresa(int edicion);
        public event delOnNuevaEmpresa OnNuevaEmpresa;
        #endregion

        #region VARIABLES PUBLICAS
        public int _tipoOperacion;
        public int _idempresa;
        public int _iddireccion;
        public bool _lista;
        #endregion


        private void guardar(int tipoGuardar)
        {
            int existe = 0;
            string valorConfiguracion = String.Empty;
            string certificado = String.Empty;

            //SE VALIDA SI TODOS LOS TEXTBOX HAN SIDO LLENADOS.
            string control = GLOBALES.VALIDAR(tabEmpresa, typeof(TextBox));
            if (!control.Equals(""))
            {
                MessageBox.Show("Falta el campo: " + control, "Información");
                return;
            }

            control = GLOBALES.VALIDAR(tabEmpresa, typeof(MaskedTextBox));
            if (!control.Equals(""))
            {
                MessageBox.Show("Falta el campo: " + control, "Información");
                return;
            }

            control = GLOBALES.VALIDAR(tabDomicilio, typeof(TextBox));
            if (!control.Equals(""))
            {
                MessageBox.Show("Falta el campo: " + control, "Información");
                return;
            }

            control = GLOBALES.VALIDAR(tabDomicilio, typeof(MaskedTextBox));
            if (!control.Equals(""))
            {
                MessageBox.Show("Falta el campo: " + control, "Información");
                return;
            }

            int idempresa;

            cnx = new SqlConnection();
            cnx.ConnectionString = cdn;
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            eh = new Empresas.Core.EmpresasHelper();
            eh.Command = cmd;

            Configuracion.Core.ConfiguracionHelper ch = new Configuracion.Core.ConfiguracionHelper();
            ch.Command = cmd;

            cnx.Open();
            valorConfiguracion = ch.obtenerValorConfiguracion(8).ToString();
            cnx.Close();

            if (!System.IO.Directory.Exists(valorConfiguracion))
                System.IO.Directory.CreateDirectory(valorConfiguracion);

            Empresas.Core.Empresas em = new Empresas.Core.Empresas();
            em.nombre = txtNombre.Text;
            em.rfc = txtRfc.Text;
            em.registro = txtRegistroPatronal.Text;
            em.digitoverificador = int.Parse(txtDigitoVerificador.Text);
            em.representante = txtRepresentante.Text;
            em.estatus = 1;
            em.observacion = txtObservacion.Text;
            em.obracivil = chkObraCivil.Checked;
            em.idregimenfiscal = int.Parse(cmbRegimenFiscal.SelectedValue.ToString());
            em.codigopostal = txtCP.Text;
            em.usuariopac = txtUsuario.Text.Trim();
            em.passwordpac = txtPasswordPac.Text.Trim();
            em.passwordkey = txtPassword.Text;
            em.certificado = "";

            if (FLAG_KEY)
            {
                System.IO.File.Copy(txtPathArchivo.Text, String.Format("{0}{1}", valorConfiguracion, System.IO.Path.GetFileName(txtPathArchivo.Text)), true);
                em.archivokey = System.IO.Path.GetFileName(txtPathArchivo.Text);
            }
            else
            {
                em.archivokey = txtPathArchivo.Text;
            }

            if (FLAG_CERT)
            {
                System.IO.File.Copy(txtPathCert.Text, String.Format("{0}{1}", valorConfiguracion, System.IO.Path.GetFileName(txtPathCert.Text)), true);
                em.archivocer = System.IO.Path.GetFileName(txtPathCert.Text);

                X509Certificate cert = new X509Certificate(txtPathCert.Text);
                certificado = Convert.ToBase64String(cert.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks);
                em.certificado = certificado.Replace("\r\n", "");
                
                X509Certificate2 x509 = new X509Certificate2(txtPathCert.Text);
                //byte[] rawData = ReadFile(txtPathCert.Text);
                //x509.Import(rawData);
                //string noCertificado = x509.SerialNumber;

                string noCertificado = Encoding.Default.GetString(x509.GetSerialNumber());
                char[] s = noCertificado.ToCharArray();
                string b = String.Empty;
                for (int i = 0; i < s.Length; i++)
                {
                    b += s[s.Length - (i + 1)].ToString();
                }
                em.nocertificado = b;
            }
            else
            {
                em.archivocer = txtPathCert.Text;
                em.nocertificado = noCertificado;
            }
            

            dh = new Direccion.Core.DireccionesHelper();
            dh.Command = cmd;

            Direccion.Core.Direcciones d = new Direccion.Core.Direcciones();
            d.calle = txtCalle.Text;
            d.exterior = txtExterior.Text;
            d.interior = txtInterior.Text;
            d.colonia = txtColonia.Text;
            d.ciudad = txtMunicipio.Text;
            d.estado = txtEstado.Text;
            d.pais = txtPais.Text;
            d.cp = txtCP.Text;
            d.tipodireccion = GLOBALES.dFISCAL;
            d.tipopersona = GLOBALES.pEMPRESA;

            ih = new Imagen.Core.ImagenesHelper();
            ih.Command = cmd;

            Imagen.Core.Imagenes img = null;

            Periodos.Core.PeriodosHelper ph = new Periodos.Core.PeriodosHelper();
            ph.Command = cmd;

            Periodos.Core.Periodos periodo = new Periodos.Core.Periodos();
            periodo.dias = int.Parse(txtDias.Text);
            periodo.estatus = GLOBALES.ACTIVO;
            periodo.pago = cmbPago.Text;

            try
            {
                if (ImagenAsignada == true)
                {
                    img = new Imagen.Core.Imagenes();
                    img.imagen = GLOBALES.IMAGEN_BYTES(bmp);
                    img.tipopersona = GLOBALES.pEMPRESA;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message, "Error");
            }
            

            switch (_tipoOperacion)
            {
                case 0:
                    try
                    {
                        cnx.Open();
                        eh.insertaEmpresa(em);

                        idempresa = (int)eh.obtenerIdEmpresa(em);
                        d.idpersona = idempresa;
                        dh.insertaDireccion(d);
                        if (ImagenAsignada == true)
                        {
                            img.idpersona = idempresa;
                            ih.insertaImagen(img);
                        }
                        periodo.idempresa = idempresa;
                        ph.insertaPeriodo(periodo);

                        eh.actualizaCertificado(idempresa, certificado);
                        
                        cnx.Close();
                        cnx.Dispose();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error al ingresar la empresa. \r\n \r\n Error: " + error.Message);
                        ERROR = true;
                    }
                    break;
                case 2:
                    try
                    {
                        em.idempresa = _idempresa;
                        d.iddireccion = _iddireccion;
                        d.idpersona = _idempresa;

                        cnx.Open();
                        eh.actualizaEmpresa(em);
                        dh.actualizaDireccion(d);
                        if (ImagenAsignada == true)
                        {
                            img.idpersona = _idempresa;
                            img.tipopersona = GLOBALES.pEMPRESA;
                            existe = (int)ih.ExisteImagen(img);
                            if (existe != 0)
                                ih.actualizaImagen(img);
                            else
                                ih.insertaImagen(img);
                        }
                        cnx.Close();
                        cnx.Dispose();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error al actualizar la empresa. \r\n \r\n Error: " + error.Message);
                        ERROR = true;
                    }
                    break;
            }

            switch (tipoGuardar)
            {
                case 0:
                    if (!ERROR)
                    {
                        MessageBox.Show(String.Format("Información: Empresa {0} creada y/o actualizada con exito.", txtNombre.Text), "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GLOBALES.LIMPIAR(this, typeof(TextBox));
                        GLOBALES.LIMPIAR(this, typeof(MaskedTextBox));

                        if (OnNuevaEmpresa != null)
                            OnNuevaEmpresa(_tipoOperacion);
                    }
                    else 
                    {
                        MessageBox.Show(String.Format("Error: Empresa {0} no pudo ser creada y/o actualizada. \r\n\r\n Por favor verifique los datos.", txtNombre.Text), "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void txtRfc_Leave(object sender, EventArgs e)
        {
            string lsPatron = @"^[A-ZÑ&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9][A-Z,0-9][0-9A]$";
            Regex loRE = new Regex(lsPatron);
            if (!loRE.IsMatch(txtRfc.Text))
                MessageBox.Show("El RFC no es valido. Verifique","Error");
        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            CargaComboBox();

            if (!_lista)
                toolGuardarNuevo.Visible = false;
            /// _tipoOperacion CONSULTA = 1, EDICION = 2
            if (_tipoOperacion == GLOBALES.CONSULTAR || _tipoOperacion == GLOBALES.MODIFICAR)
            {
                cmbPago.Visible = false;
                txtDias.Visible = false;

                cnx = new SqlConnection();
                cnx.ConnectionString = cdn;
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                eh = new Empresas.Core.EmpresasHelper();
                eh.Command = cmd;

                dh = new Direccion.Core.DireccionesHelper();
                dh.Command = cmd;

                Direccion.Core.Direcciones d = new Direccion.Core.Direcciones();
                d.idpersona = _idempresa;
                d.tipopersona = GLOBALES.pEMPRESA; ///TIPO PERSONA 0 - Empresas
                List<Empresas.Core.Empresas> lstEmpresa;
                List<Direccion.Core.Direcciones> lstDireccion;

                try
                {
                    cnx.Open();
                    lstEmpresa = eh.obtenerEmpresa(_idempresa);
                    lstDireccion = dh.obtenerDireccion(d);
                    cnx.Close();
                    cnx.Dispose();

                    for (int i = 0; i < lstEmpresa.Count; i++)
                    {
                        txtNombre.Text = lstEmpresa[i].nombre;
                        txtRepresentante.Text = lstEmpresa[i].representante;
                        txtRfc.Text = lstEmpresa[i].rfc;
                        txtRegistroPatronal.Text = lstEmpresa[i].registro;
                        txtObservacion.Text = lstEmpresa[i].observacion;
                        txtDigitoVerificador.Text = lstEmpresa[i].digitoverificador.ToString();
                        chkObraCivil.Checked = lstEmpresa[i].obracivil;
                        cmbRegimenFiscal.SelectedValue = lstEmpresa[i].idregimenfiscal;
                        txtPathArchivo.Text = lstEmpresa[i].archivokey;
                        txtPathCert.Text = lstEmpresa[i].archivocer;
                        txtPassword.Text = lstEmpresa[i].passwordkey;
                        txtUsuario.Text = lstEmpresa[i].usuariopac;
                        txtPasswordPac.Text = lstEmpresa[i].passwordpac;
                        noCertificado = lstEmpresa[i].nocertificado;
                    }

                    for (int i = 0; i < lstDireccion.Count; i++)
                    {
                        _iddireccion = lstDireccion[i].iddireccion;
                        txtCalle.Text = lstDireccion[i].calle;
                        txtExterior.Text = lstDireccion[i].exterior;
                        txtInterior.Text = lstDireccion[i].interior;
                        txtColonia.Text = lstDireccion[i].colonia;
                        txtCP.Text = lstDireccion[i].cp;
                        txtMunicipio.Text = lstDireccion[i].ciudad;
                        txtEstado.Text = lstDireccion[i].estado;
                        txtPais.Text = lstDireccion[i].pais;
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                }

                if (_tipoOperacion == GLOBALES.CONSULTAR)
                {
                    ((Control)this.tabEmpresa).Enabled = false;
                    ((Control)this.tabPeriodo).Enabled = false;
                    ((Control)this.tabDomicilio).Enabled = false;
                    btnAsignar.Enabled = false;
                    toolGuardarNuevo.Enabled = false;
                    
                }
            }
            
                
            cmbPago.SelectedIndex = 0;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar imagen";
            ofd.Filter = "Archivo de Imagen (*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp";
            ofd.RestoreDirectory = false;

            if (DialogResult.OK == ofd.ShowDialog())
            {
                bmp = new Bitmap(ofd.FileName);
                ImagenAsignada = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmImagen i = new frmImagen();
            i._idpersona = _idempresa;
            i._tipopersona = GLOBALES.pEMPRESA;
            i.Show();
        }

        private void toolGuardarNuevo_Click(object sender, EventArgs e)
        {
            guardar(0);
        }

        private void toolCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPago.SelectedIndex.Equals(1))
            {
                txtDias.Text = "15";
            }
            else
            {
                txtDias.Text = "7";
            }
        }

        private void CargaComboBox()
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = cdn;
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            SatCatalogos.Core.satCatalogosHelper sch = new SatCatalogos.Core.satCatalogosHelper();
            sch.Command = cmd;
            List<SatCatalogos.Core.satRegimenFiscal> lstRegimenFiscal = new List<SatCatalogos.Core.satRegimenFiscal>();

            try
            {
                cnx.Open();
                lstRegimenFiscal = sch.obtenerRegimenes();
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Al obtener los datos del regimen fiscal", "Error");
                cnx.Dispose();
            }

            cmbRegimenFiscal.DataSource = lstRegimenFiscal.ToList();
            cmbRegimenFiscal.DisplayMember = "descripcion";
            cmbRegimenFiscal.ValueMember = "id";
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {       

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo key";
            ofd.Filter = "Archivo key (*.key)|*.key";
            ofd.RestoreDirectory = false;

            DialogResult respuesta = ofd.ShowDialog();

            if (DialogResult.OK == respuesta)
            {
                FLAG_KEY = true;
                txtPathArchivo.Text = ofd.FileName;
                //System.IO.File.Copy(txtPathArchivo.Text, valorConfiguracion, true);
            }
            else if (DialogResult.Cancel == respuesta)
            {
                FLAG_KEY = false;
            }
        }

        private void btnExaminarCer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo cer";
            ofd.Filter = "Archivo cer (*.cer)|*.cer";
            ofd.RestoreDirectory = false;

            DialogResult respuesta = ofd.ShowDialog();

            if (DialogResult.OK == respuesta)
            {
                FLAG_CERT = true;
                txtPathCert.Text = ofd.FileName;
            }
            else if (DialogResult.Cancel == respuesta)
            {
                FLAG_CERT = false;
            }
        }

        internal static byte[] ReadFile(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }
       
    }
}

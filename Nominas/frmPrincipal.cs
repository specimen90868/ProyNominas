using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Nominas
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        SqlConnection cnx;
        SqlCommand cmd;
        bool FLAG_SESIONACTIVA = false;
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MenuInicial(0);
        }

        private void mnuAbrirEmpresa_Click(object sender, EventArgs e)
        {
            if (GLOBALES.IDEMPRESA != 0)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Dispose();
                }
            }

            frmSeleccionarEmpresa frmEmpresa = new frmSeleccionarEmpresa();
            frmEmpresa.OnAbrirEmpresa += frmEmpresa_OnAbrirEmpresa;
            frmEmpresa.MdiParent = this;
            frmEmpresa.StartPosition = FormStartPosition.CenterScreen;
            frmEmpresa.Show();
        }

        void frmEmpresa_OnAbrirEmpresa()
        {
            this.Text = "Sistema de Nomina - [" + GLOBALES.NOMBREEMPRESA + "]";
            MenuPerfil();
            MenuInicial(2);
            Permisos();
            workAntiguedad.RunWorkerAsync();
        }

        private void Permisos()
        {
            cnx = new SqlConnection();
            cmd = new SqlCommand();

            cnx.ConnectionString = cdn;
            cmd.Connection = cnx;

            Autorizaciones.Core.AutorizacionHelper ah = new Autorizaciones.Core.AutorizacionHelper();
            ah.Command = cmd;

            cnx.Open();

            List<Autorizaciones.Core.Autorizaciones> lstAuth = ah.getAutorizacion(GLOBALES.IDUSUARIO);
            List<Autorizaciones.Core.Menus> lstMenu = ah.getMenus(GLOBALES.IDPERFIL.ToString());

            cnx.Close();
            cnx.Dispose();

            for (int i = 0; i < lstAuth.Count; i++)
            {
                switch (lstAuth[i].modulo.ToString())
                {
                    case "Recursos Humanos":
                        mnuRecursosHumanos.Enabled = lstAuth[i].acceso;
                        break;
                    case "Seguro Social":
                        mnuSeguroSocial.Enabled = lstAuth[i].acceso;
                        break;
                    case "Nominas":
                        mnuNominas.Enabled = lstAuth[i].acceso;
                        break;
                    case "Catálogos":
                        mnuCatalogos.Enabled = lstAuth[i].acceso;
                        break;
                    case "Configuración":
                        mnuConfiguracion.Enabled = lstAuth[i].acceso;
                        break;
                }
            }

            for (int i = 0; i < lstMenu.Count; i++)
            {
                switch (lstMenu[i].nombre.ToString())
                {
                    case "Empleados":
                        mnuEmpleados.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Empleados de nómina":
                        mnuEmpleadoNomina.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Complementos":
                        mnuComplementos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Registro de Bajas":
                        toolRegistroBajas.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Importar empleados":
                        toolImportarEmpleados.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Expedientes":
                        mnuExpedientes.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Infonavit":
                        mnuInfonavit.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Incapacidades":
                        toolIncapacidades.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Operaciones SUA":
                        toolSua.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Altas":
                        toolAltas.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Modificaciones":
                        toolModificaciones.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Reingresos":
                        toolReingresos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Bajas":
                        toolBajas.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Ausentismos":
                        toolAusentismos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Infonavit SUA":
                        toolInfonavit.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Operaciones Idse":
                        toolIdse.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Altas Idse":
                        toolAltasIdse.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Modificaciones Idse":
                        toolModificacionIdse.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Bajas Idse":
                        toolBajaIdse.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Cálculo de nómina":
                        toolCalculoNomina.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Ordinaria":
                        toolNominaNormal.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Extraordinaria":
                        toolExtraordinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Recibos de nómina":
                        toolRecibosNomina.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Impresión p. ordinario":
                        toolPeriodoOrdinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Impresión p. extraordinario":
                        toolPeriodoExtraOrdinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Emisión de recibos (Ordinario)":
                        toolEnvioCorreoOrdinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Emisión de recibos (Extraordiario)":
                        toolEnvioCorreoExtraordinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Reportes":
                        toolReportes.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Periodo ordinario":
                        toolReporteOrdinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Periodo extraordinario":
                        toolReporteExtraordinario.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Vacaciones":
                        toolVacaciones.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Bitácora":
                        toolBitacora.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Departamentos":
                        mnuDepartamentos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Puestos":
                        mnuPuestos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Periodos":
                        mnuPeriodos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Conceptos":
                        toolConceptos.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Conceptos - Empleado":
                        toolConceptoEmpleado.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Empresa":
                        mnuEmpresa.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Usuarios":
                        mnuUsuarios.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Perfiles":
                        mnuPerfiles.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Cambiar contraseña":
                        mnuCambiarContrasenia.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Preferencias":
                        mnuPreferencias.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Tablas":
                        mnuTablas.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Factores":
                        mnuFactores.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Salario mínimo":
                        mnuSalarioMinimo.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "ISR":
                        toolIsr.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Subsidio":
                        toolSubsidio.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "IMSS":
                        toolImss.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Factor de descuento":
                        toolFactorDescuento.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                    case "Empresas":
                        toolEmpresas.Enabled = Convert.ToBoolean(lstMenu[i].accion);
                        break;
                }
            }
        }

        private void MenuInicial(int sesion)
        {
            if (sesion == 0)
            {
                mnuRecursosHumanos.Visible = false;
                mnuSeguroSocial.Visible = false;
                mnuNominas.Visible = false;
                mnuCatalogos.Visible = false;
                mnuConfiguracion.Visible = false;
                /// MENUS DE SESION
                mnuAbrirEmpresa.Enabled = true;
                mnuCerrarEmpresa.Enabled = false;
                mnuCerrarSesion.Enabled = true;
                mnuIniciarSesion.Enabled = false;
                FLAG_SESIONACTIVA = false;
            }
            else if (sesion == 2)
            {
                mnuAbrirEmpresa.Enabled = false;
                mnuCerrarEmpresa.Enabled = true;
                mnuCerrarSesion.Enabled = true;
                mnuIniciarSesion.Enabled = false;
                FLAG_SESIONACTIVA = true;
            }
            else
            {
                mnuRecursosHumanos.Visible = false;
                mnuSeguroSocial.Visible = false;
                mnuNominas.Visible = false;
                mnuCatalogos.Visible = false;
                mnuConfiguracion.Visible = false;

                mnuAbrirEmpresa.Enabled = false;
                mnuCerrarEmpresa.Enabled = false;
                mnuCerrarSesion.Enabled = false;
                mnuIniciarSesion.Enabled = true;
                FLAG_SESIONACTIVA = true;
            }

        }

        private void MenuPerfil()
        {
            mnuRecursosHumanos.Visible = true;
            mnuSeguroSocial.Visible = true;
            mnuNominas.Visible = true;
            mnuCatalogos.Visible = true;
            mnuConfiguracion.Visible = true;
        }

        private void mniIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciaSesion();
        }

        void IniciaSesion()
        {
            frmLogIn login = new frmLogIn();
            login.ShowDialog();
            MenuInicial(0);
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            CierraSesion();
        }

        void CierraSesion()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }

            GLOBALES.IDUSUARIO = 0;
            GLOBALES.IDPERFIL = 0;
            GLOBALES.IDEMPRESA = 0;
            GLOBALES.NOMBREEMPRESA = null;
            this.Text = "Sistema de Nomina";
            mnuRecursosHumanos.Visible = false;
            mnuSeguroSocial.Visible = false;
            mnuNominas.Visible = false;
            mnuCatalogos.Visible = false;
            mnuConfiguracion.Visible = false;
            MenuInicial(1);
        }

        private void mnuCerrarEmpresa_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
            GLOBALES.NOMBREEMPRESA = null;
            GLOBALES.IDEMPRESA = 0;
            this.Text = "Sistema de Nomina";
            MenuInicial(0);
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuPerfiles_Click(object sender, EventArgs e)
        {
            frmListaPerfiles lp = new frmListaPerfiles();
            lp.MdiParent = this;
            lp.Show();
        }

        private void mnuDepartamentos_Click(object sender, EventArgs e)
        {
            frmListaDepartamentos ld = new frmListaDepartamentos();
            ld.MdiParent = this;
            ld.Show();
        }

        private void mnuPuestos_Click(object sender, EventArgs e)
        {
            frmListaPuestos lp = new frmListaPuestos();
            lp.MdiParent = this;
            lp.Show();
        }

        private void mnuPeriodos_Click(object sender, EventArgs e)
        {
            frmListaPeriodos lp = new frmListaPeriodos();
            lp.MdiParent = this;
            lp.Show();
        }

        private void mnuFactores_Click_1(object sender, EventArgs e)
        {
            frmListaFactores lf = new frmListaFactores();
            lf.MdiParent = this;
            lf.Show();
        }

        private void mnuSalarioMinimo_Click_1(object sender, EventArgs e)
        {
            frmListaSalario ls = new frmListaSalario();
            ls.MdiParent = this;
            ls.Show();
        }

        private void mnuEmpleadoNomina_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmListaEmpleados"))
                return;
            
            frmListaEmpleados le = new frmListaEmpleados();
            //le._empleadoAltaBaja = GLOBALES.ACTIVO;
            le.WindowState = FormWindowState.Maximized;
            le.MdiParent = this;
            le.Show();
        }

        private void mnuComplementos_Click(object sender, EventArgs e)
        {
            frmListaComplementos lc = new frmListaComplementos();
            lc.MdiParent = this;
            lc.Show();
        }

        private void mnuEmpresa_Click(object sender, EventArgs e)
        {
            //frmListaEmpresas le = new frmListaEmpresas();
            frmEmpresas empresa = new frmEmpresas();
            empresa.MdiParent = this;
            empresa._tipoOperacion = GLOBALES.MODIFICAR;
            empresa._idempresa = GLOBALES.IDEMPRESA;
            empresa._lista = true;
            empresa.StartPosition = FormStartPosition.CenterScreen;
            empresa.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmListaUsuarios lu = new frmListaUsuarios();
            lu.MdiParent = this;
            lu.WindowState = FormWindowState.Maximized;
            lu.Show();
        }

        private void mnuCambiarContrasenia_Click(object sender, EventArgs e)
        {
            frmCambioContrasena cp = new frmCambioContrasena();
            cp.MdiParent = this;
            cp.Show();
        }

        private void mnuPreferencias_Click(object sender, EventArgs e)
        {
            frmPreferencias p = new frmPreferencias();
            p.MdiParent = this;
            p.WindowState = FormWindowState.Normal;
            p.Show();
        }

        private void toolProcesoSalarial_Click(object sender, EventArgs e)
        {
            frmListaProcesoSalarial lps = new frmListaProcesoSalarial();
            lps.MdiParent = this;
            lps.Show();
        }

        private void mnuExpedientes_Click(object sender, EventArgs e)
        {
            frmListaExpedientes le = new frmListaExpedientes();
            le.MdiParent = this;
            le.Show();
        }

        private void mnuInfonavit_Click(object sender, EventArgs e)
        {
            frmListaInfonavit li = new frmListaInfonavit();
            li.MdiParent = this;
            li.Show();
        }

        private void toolAltas_Click(object sender, EventArgs e)
        {
            frmListaAltasSua las = new frmListaAltasSua();
            las.MdiParent = this;
            las.Show();
        }

        private void toolBajas_Click(object sender, EventArgs e)
        {
            frmListaBajasSua lbs = new frmListaBajasSua();
            lbs.MdiParent = this;
            lbs.Show();
        }

        private void toolAusentismos_Click(object sender, EventArgs e)
        {
            frmListaAusentimosSua las = new frmListaAusentimosSua();
            las.MdiParent = this;
            las.Show();
        }

        private void toolModificaciones_Click(object sender, EventArgs e)
        {
            frmListaModificacionesSua lms = new frmListaModificacionesSua();
            lms.MdiParent = this;
            lms.Show();
        }

        private void toolReingresos_Click(object sender, EventArgs e)
        {
            frmListaReingresosSua lrs = new frmListaReingresosSua();
            lrs.MdiParent = this;
            lrs.Show();
        }

        private void toolInfonavit_Click(object sender, EventArgs e)
        {
            frmListaInfonavitSua lis = new frmListaInfonavitSua();
            lis.MdiParent = this;
            lis.Show();
        }

        private void toolAltasIdse_Click(object sender, EventArgs e)
        {
            frmListaOperacionesIdse loi = new frmListaOperacionesIdse();
            loi.MdiParent = this;
            loi._tipoOperacion = 0;
            loi.Show();
        }

        private void toolModificacionIdse_Click(object sender, EventArgs e)
        {
            frmListaOperacionesIdse loi = new frmListaOperacionesIdse();
            loi.MdiParent = this;
            loi._tipoOperacion = 1;
            loi.Show();
        }

        private void toolBaja_Click(object sender, EventArgs e)
        {
            frmListaOperacionesIdse loi = new frmListaOperacionesIdse();
            loi.MdiParent = this;
            loi._tipoOperacion = 2;
            loi.Show();
        }

        private void toolIsr_Click(object sender, EventArgs e)
        {
            frmListaIsr li = new frmListaIsr();
            li.MdiParent = this;
            li.Show();
        }

        private void toolSubsidio_Click(object sender, EventArgs e)
        {
            frmListaSubsidio ls = new frmListaSubsidio();
            ls.MdiParent = this;
            ls.Show();
        }

        private void toolConceptos_Click(object sender, EventArgs e)
        {
            frmListaConceptos lc = new frmListaConceptos();
            lc.MdiParent = this;
            lc.Show();
        }

        private void toolImss_Click(object sender, EventArgs e)
        {
            frmListaImss li = new frmListaImss();
            li.MdiParent = this;
            li.Show();
        }

        private void toolNominaNormal_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.NORMAL;
            sp._Ventana = 0; //NOMINAS
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolReportes_Click(object sender, EventArgs e)
        {
            

            
        }

        private void toolIncapacidades_Click(object sender, EventArgs e)
        {
            frmListaIncapacidad i = new frmListaIncapacidad();
            i.MdiParent = this;
            i.Show();
        }

        private void toolConceptoEmpleado_Click_1(object sender, EventArgs e)
        {
            frmListaConceptoEmpleado lce = new frmListaConceptoEmpleado();
            lce.MdiParent = this;
            lce.Show();
        }

        private void toolExtraordinario_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.EXTRAORDINARIO_NORMAL;
            sp._Ventana = 0; //NOMINAS
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.MdiParent = this;
            sp.Show();
        }

        private void workAntiguedad_DoWork(object sender, DoWorkEventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
            eh.Command = cmd;

            try
            {
                cnx.Open();
                eh.actualizaAntiguedad(GLOBALES.IDEMPRESA);
                cnx.Close();
            }
            catch
            {
                cnx.Dispose();
                return;
            }
        }

        private void workAntiguedad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolPorcentaje.Text = e.ProgressPercentage + "%";
        }

        private void workAntiguedad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolPorcentaje.Text = "Terminado.";
        }

        private void toolImportarEmpleados_Click(object sender, EventArgs e)
        {
            frmListaCargaEmpleados lce = new frmListaCargaEmpleados();
            lce.MdiParent = this;
            lce.Show();
        }

        private void toolRegistroBajas_Click(object sender, EventArgs e)
        {
            frmListaBajasSua lbs = new frmListaBajasSua();
            lbs.MdiParent = this;
            lbs.Show();
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (!FLAG_SESIONACTIVA)
                if (e.KeyData == Keys.F1)
                {
                    IniciaSesion();
                }
                else if (e.KeyData == Keys.F3)
                {
                    CierraSesion();
                }
        }

        private void toolFactorDescuento_Click(object sender, EventArgs e)
        {
            frmListaFactorDescuento lfd = new frmListaFactorDescuento();
            lfd.MdiParent = this;
            lfd.Show();
        }

        private void toolEmpresas_Click(object sender, EventArgs e)
        {
            frmListaEmpresas le = new frmListaEmpresas();
            le.MdiParent = this;
            le.WindowState = FormWindowState.Maximized;
            le.Show();
        }

        private void toolPeriodoOrdinario_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.NORMAL;
            sp._Ventana = 1; //CFDI
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolPeriodoExtraOrdinario_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.EXTRAORDINARIO_NORMAL;
            sp._Ventana = 1; //CFDI
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolEnvioCorreo_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.NORMAL;
            sp._Ventana = 2; //CFDI
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolEnvioCorreoExtraordinario_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.EXTRAORDINARIO_NORMAL;
            sp._Ventana = 2; //CFDI
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolReporteOrdinario_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.NORMAL;
            sp._Ventana = 3; //REPORTES
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolReporteExtraordinario_Click(object sender, EventArgs e)
        {
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._TipoNomina = GLOBALES.EXTRAORDINARIO_NORMAL;
            sp._Ventana = 3; //REPORTES
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolVacaciones_Click(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Complementos.Core.ComplementoHelper ch = new Complementos.Core.ComplementoHelper();
            ch.Command = cmd;

            DataTable dt = new DataTable();
            try
            {
                cnx.Open();
                dt = ch.obtenerObservaciones(GLOBALES.IDEMPRESA);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: \r\n \r\n" + error.Message, "Error");
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No es posible generar el reporte. \r\n \r\n Verifique los parametros del reporte.", "Error");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();

            Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;

            excel.Cells[1, 1] = dt.Rows[0][0];
            excel.Cells[2, 1] = "RFC:";
            excel.Cells[3, 1] = "REG. PAT:";

            excel.Cells[2, 2] = dt.Rows[0][1];
            excel.Cells[3, 2] = dt.Rows[0][2];

            //SE COLOCAN LOS TITULOS DE LAS COLUMNAS
            int iCol = 1;
            for (int i = 3; i < dt.Columns.Count; i++)
            {
                excel.Cells[5, iCol] = dt.Columns[i].ColumnName;
                iCol++;
            }
            //SE COLOCAN LOS DATOS
            int contadorDt = dt.Rows.Count;
            int contador = 0;
            int progreso = 0;
            iCol = 1;
            int iFil = 6;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                progreso = (contador * 100) / contadorDt;
                toolPorcentaje.Text = progreso.ToString() + "%";
                contador++;
                if (i != dt.Rows.Count - 1)
                {
                    for (int j = 3; j < dt.Columns.Count; j++)
                    {
                        excel.Cells[iFil, iCol] = dt.Rows[i][j];
                        iCol++;
                    }
                    iFil++;
                }
                else
                {
                    for (int j = 3; j < dt.Columns.Count; j++)
                    {
                        excel.Cells[iFil, iCol] = dt.Rows[i][j];
                        iCol++;
                    }
                }

                iCol = 1;

            }

            excel.Range["B:C"].EntireColumn.AutoFit();
            excel.Range["B:C"].EntireRow.AutoFit();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Guardar como";
            sfd.Filter = "Archivo de excel (*.xlsx)|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workSheet.SaveAs(sfd.FileName);
                excel.Visible = true;
            }
        }

        private void toolBitacora_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmListaBitacora"))
                return;
            frmListaBitacora lb = new frmListaBitacora();
            lb.Show();
        }

        private void toolVisorRecibosNomina_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmSeleccionPeriodo"))
                return;
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._Ventana = 4; //CFDI
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            //string curp = "";
            //string rfc = "";
            string nombre = "";
            string numempleado = "";
            string fechainicio = "";
            string fechafin = "";
            string ImporteExento = "", ImporteGravado = "", Concepto = "", Clave = "", TipoPercepcion = "", TipoDeduccion = "",
                OtroPago = "", Importe = "";
            //string sello = "";
            //string noCertificado = "";
            int fila = 1;

            List<Xml.Core.XmlCabecera> xmls = new List<Xml.Core.XmlCabecera>();
            Xml.Core.XmlCabeceraHelper xh = new Xml.Core.XmlCabeceraHelper();
            xh.Command = cmd;

            cnx.Open();
            xmls = xh.obtenerXml(GLOBALES.IDEMPRESA, 2, 15, new DateTime(2017, 05, 01).Date, new DateTime(2017, 05, 31).Date);
            cnx.Close();
            //cnx.Dispose();

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();

            for (int i = 0; i < xmls.Count; i++)
            {
                //using (StreamWriter sw = new StreamWriter(String.Format(@"C:\Temp\xmls_nomina\{0}_{1}.xml", xmls[i].idtrabajador,i), false, Encoding.UTF8))
                //{
                //    sw.WriteLine(xmls[i].xml);
                //    sw.Flush();
                //    sw.Close();
                //}
                if (xmls[i].xml != "")
                {
                    System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                    doc.LoadXml(xmls[i].xml);
                    //String xml = File.ReadAllText(String.Format(@"C:\Temp\xmls_nomina\{0}_{1}.xml", xmls[i].idtrabajador, i), Encoding.UTF8);
                    //doc.LoadXml(xml);

                    //System.Xml.XmlNodeList Comprobante = doc.GetElementsByTagName("cfdi:Comprobante");
                    //foreach (System.Xml.XmlElement nodo in Comprobante)
                    //{
                    //    noCertificado = nodo.GetAttribute("NoCertificado");
                    //    sello = nodo.GetAttribute("Sello");
                    //}

                    //if (noCertificado == String.Empty && sello == String.Empty)
                    //{
                    //    foreach (System.Xml.XmlElement nodo in Comprobante)
                    //    {
                    //        noCertificado = nodo.GetAttribute("noCertificado");
                    //        sello = nodo.GetAttribute("sello");
                    //    }
                    //}

                    //cnx.Open();
                    //xh.actualizaXmlCertificado(xmls[i].folio, noCertificado, sello);
                    //cnx.Close();

                    System.Xml.XmlNodeList fechas = doc.GetElementsByTagName("nomina12:Nomina");
                    foreach (System.Xml.XmlElement fecha in fechas)
                    {
                        fechainicio = fecha.GetAttribute("FechaInicialPago");
                        fechafin = fecha.GetAttribute("FechaFinalPago");
                    }

                    System.Xml.XmlNodeList Receptor = doc.GetElementsByTagName("cfdi:Receptor");
                    foreach (System.Xml.XmlElement nodo in Receptor)
                    {
                    //    rfc = nodo.GetAttribute("rfc");
                        nombre = nodo.GetAttribute("nombre");
                    }

                    System.Xml.XmlNodeList empleado = doc.GetElementsByTagName("nomina12:Receptor");
                    foreach (System.Xml.XmlElement nodo in empleado)
                    {
                        numempleado = nodo.GetAttribute("NumEmpleado");
                        //curp = nodo.GetAttribute("CURP");

                    }

                    //excel.Cells[fila, 1] = numempleado;
                    //excel.Cells[fila, 2] = nombre;
                    //excel.Cells[fila, 3] = rfc;

                    System.Xml.XmlNodeList percepciones = doc.GetElementsByTagName("nomina12:Percepciones");
                    foreach (System.Xml.XmlElement nodo in percepciones)
                    {
                        System.Xml.XmlNodeList percepcion = nodo.GetElementsByTagName("nomina12:Percepcion");
                        foreach (System.Xml.XmlElement xe in percepcion)
                        {
                            ImporteExento = xe.GetAttribute("ImporteExento");
                            ImporteGravado = xe.GetAttribute("ImporteGravado");
                            Concepto = xe.GetAttribute("Concepto");
                            Clave = xe.GetAttribute("Clave");
                            TipoPercepcion = xe.GetAttribute("TipoPercepcion");

                            excel.Cells[fila, 1] = (decimal.Parse(ImporteExento) + decimal.Parse(ImporteGravado)).ToString();
                            excel.Cells[fila, 2] = Concepto;
                            excel.Cells[fila, 3] = Clave;
                            excel.Cells[fila, 4] = TipoPercepcion;
                            excel.Cells[fila, 5] = "Percepcion";
                            excel.Cells[fila, 6] = numempleado;
                            excel.Cells[fila, 7] = nombre;
                            excel.Cells[fila, 8] = fechainicio;
                            excel.Cells[fila, 9] = fechafin;
                            fila++;
                        }
                        //curp = nodo.GetAttribute("CURP");
                    }

                    System.Xml.XmlNodeList deducciones = doc.GetElementsByTagName("nomina12:Deducciones");
                    foreach (System.Xml.XmlElement nodo in deducciones)
                    {
                        System.Xml.XmlNodeList deduccion = nodo.GetElementsByTagName("nomina12:Deduccion");
                        foreach (System.Xml.XmlElement xe in deduccion)
                        {
                            Importe = xe.GetAttribute("Importe");
                            Concepto = xe.GetAttribute("Concepto");
                            Clave = xe.GetAttribute("Clave");
                            TipoDeduccion = xe.GetAttribute("TipoDeduccion");

                            excel.Cells[fila, 1] = Importe;
                            excel.Cells[fila, 2] = Concepto;
                            excel.Cells[fila, 3] = Clave;
                            excel.Cells[fila, 4] = TipoDeduccion;
                            excel.Cells[fila, 5] = "Deduccion";
                            excel.Cells[fila, 6] = numempleado;
                            excel.Cells[fila, 7] = nombre;
                            excel.Cells[fila, 8] = fechainicio;
                            excel.Cells[fila, 9] = fechafin;
                            fila++;
                        }
                        //curp = nodo.GetAttribute("CURP");
                    }

                    System.Xml.XmlNodeList otrospagos = doc.GetElementsByTagName("nomina12:OtrosPagos");
                    foreach (System.Xml.XmlElement nodo in otrospagos)
                    {
                        System.Xml.XmlNodeList otropago = nodo.GetElementsByTagName("nomina12:OtroPago");
                        foreach (System.Xml.XmlElement xe in otropago)
                        {
                            Importe = xe.GetAttribute("Importe");
                            Concepto = xe.GetAttribute("Concepto");
                            Clave = xe.GetAttribute("Clave");
                            OtroPago = xe.GetAttribute("TipoOtroPago");

                            excel.Cells[fila, 1] = Importe;
                            excel.Cells[fila, 2] = Concepto;
                            excel.Cells[fila, 3] = Clave;
                            excel.Cells[fila, 4] = OtroPago;
                            excel.Cells[fila, 5] = "OtroPago";
                            excel.Cells[fila, 6] = numempleado;
                            excel.Cells[fila, 7] = nombre;
                            excel.Cells[fila, 8] = fechainicio;
                            excel.Cells[fila, 9] = fechafin;
                            fila++;
                        }
                        //curp = nodo.GetAttribute("CURP");
                    }
                }
            }
            excel.Visible = true;
            cnx.Dispose();
        }

        private void mnuGeneracionQR_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmGeneracionQR"))
                return;
            frmGeneracionQR gqr = new frmGeneracionQR();
            gqr.Show();
        }

        private void toolCancelacionRecibos_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmSeleccionPeriodo"))
                return;
            frmSeleccionPeriodo sp = new frmSeleccionPeriodo();
            sp._Ventana = 5; //CFDI CANCELACION
            sp.MdiParent = this;
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.Show();
        }

        private void mnuGenerarRecibo_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmGenerarRecibos"))
                return;
            frmGenerarRecibos gr = new frmGenerarRecibos();
            gr.Show();
        }

        private void toolVisorRecibosCancelados_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmVisorRecibosCancelados"))
                return;
            frmVisorRecibosCancelados vrc = new frmVisorRecibosCancelados();
            vrc.StartPosition = FormStartPosition.CenterScreen;
            vrc.Show();
        }
    }
}


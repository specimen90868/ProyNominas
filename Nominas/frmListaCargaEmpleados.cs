using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aExcel = Microsoft.Office.Interop.Excel;

namespace Nominas
{
    public partial class frmListaCargaEmpleados : Form
    {
        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string ruta;
        string ExcelConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;'";
        int idEmpresa;
        Periodos.Core.PeriodosHelper ph;
        Factores.Core.FactoresHelper fh;
        Empleados.Core.EmpleadosHelper emph;
        Departamento.Core.DeptoHelper dh;
        Puestos.Core.PuestosHelper puestoh;
        int idPeriodo = 0, iddepto = 0, idpuesto = 0;
        #endregion

        public frmListaCargaEmpleados()
        {
            InitializeComponent();
        }

        private void toolCargar_Click(object sender, EventArgs e)
        {
            string conStr;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar Excel";
            ofd.RestoreDirectory = false;
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Documentos de Excel|*.xls; *.xlsx";

            if (DialogResult.OK == ofd.ShowDialog())
            {
                ruta = ofd.FileName;
                conStr = string.Empty;
                conStr = string.Format(ExcelConString, ruta);

                try
                {
                    aExcel.Application xlApp = new aExcel.Application();
                    aExcel.Workbook xlWorkbook = xlApp.Workbooks.Open(ruta);
                    aExcel._Worksheet xlWorkSheet = xlWorkbook.Sheets[1];
                    aExcel.Range xlRange = xlWorkSheet.UsedRange;
                    String nombreHoja = xlWorkSheet.Name;

                    if (nombreHoja.Equals("Trabajadores"))
                    {
                        int rowCount = xlRange.Rows.Count;

                        var ie = xlRange.Cells[1, 4].Value2;
                        idEmpresa = int.Parse(ie.ToString());
                        if (GLOBALES.IDEMPRESA != idEmpresa)
                        {
                            MessageBox.Show("Información:\r\n" +
                                            "Los datos a ingresar pertenecen a otra empresa. Verifique. \r\n \r\n La ventana se cerrara.",
                                            "Información",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            this.Dispose();
                        }

                        for (int i = 4; i < rowCount; i++)
                        {
                            if (xlRange.Cells[i, 1].Value != null)
                            {
                                dgvCargaEmpleados.Rows.Add(
                                    xlRange.Cells[i, 1].Value, //no empleado
                                    xlRange.Cells[i, 2].Value.ToString().ToUpper(), //nombres
                                    xlRange.Cells[i, 3].Value.ToString().ToUpper(), //paterno
                                    xlRange.Cells[i, 4].Value.ToString().ToUpper(), //materno
                                    xlRange.Cells[i, 5].Value, //fecha ingreso
                                    xlRange.Cells[i, 6].Value, //fecha nacimiento
                                    xlRange.Cells[i, 7].Value.ToString().ToUpper(), //rfc
                                    xlRange.Cells[i, 8].Value.ToString().ToUpper(), //curp
                                    xlRange.Cells[i, 9].Value, //nss
                                    xlRange.Cells[i, 10].Value, //periodo
                                    xlRange.Cells[i, 11].Value, //sdi
                                    xlRange.Cells[i, 12].Value, //cuenta
                                    xlRange.Cells[i, 13].Value, //clabe
                                    xlRange.Cells[i, 14].Value.ToString().ToUpper(), //depto
                                    xlRange.Cells[i, 15].Value.ToString().ToUpper()); //puesto
                            }
                        }

                        Marshal.ReleaseComObject(xlRange);
                        Marshal.ReleaseComObject(xlWorkSheet);

                        xlWorkbook.Close();
                        Marshal.ReleaseComObject(xlWorkbook);

                        xlApp.Quit();
                        Marshal.ReleaseComObject(xlApp);

                        for (int i = 0; i < dgvCargaEmpleados.Columns.Count; i++)
                        {
                            dgvCargaEmpleados.AutoResizeColumn(i);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Información:\r\n" +
                                        "El layout elegido no corresponde al layout de trabajadores.\r\n" +
                                        "Verifique por favor, la ventana se cerrará", "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        this.Dispose();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: \r\n \r\n Verifique que el archivo este cerrado. \r\n \r\n Descripcion: " + error.Message);
                }
            }
        }

        private void toolAplicar_Click(object sender, EventArgs e)
        {
            
            if (dgvCargaEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("No se puede aplicar verifique.", "Error");
                return;
            }

            workerImporta.RunWorkerAsync();
        }

        private int ObtieneEdad(DateTime fecha)
        {
            DateTime fechaNacimiento = fecha;
            int edad = (DateTime.Now.Subtract(fechaNacimiento).Days / 365);
            return edad;
        }

        private decimal ObtieneSD(decimal sdi)
        {
            int DiasDePago = 0;
            decimal FactorDePago = 0;
            decimal sd = 0;
            cnx = new SqlConnection();
            cnx.ConnectionString = cdn;
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            ph = new Periodos.Core.PeriodosHelper();
            Periodos.Core.Periodos p = new Periodos.Core.Periodos();

            fh = new Factores.Core.FactoresHelper();
            Factores.Core.Factores f = new Factores.Core.Factores();

            ph.Command = cmd;
            fh.Command = cmd;

            p.idperiodo = idPeriodo;
            f.anio = 0;

            try
            {
                cnx.Open();
                DiasDePago = (int)ph.DiasDePago(p);
                FactorDePago = decimal.Parse(fh.FactorDePago(f).ToString());
                cnx.Close();

                sd = (sdi / FactorDePago);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: \r\n \r\n Al obtener los dias de pago y/o factor de pago. \r\n" + error.Message, "Error");
                this.Dispose();
            }
            return sd;
        }

        private decimal ObtieneSueldo(decimal sd)
        {
            int DiasDePago = 0;
            decimal sueldo = 0;
            cnx = new SqlConnection();
            cnx.ConnectionString = cdn;
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            ph = new Periodos.Core.PeriodosHelper();
            Periodos.Core.Periodos p = new Periodos.Core.Periodos();

            ph.Command = cmd;

            p.idperiodo = idPeriodo;

            try
            {
                cnx.Open();
                DiasDePago = (int)ph.DiasDePago(p);
                cnx.Close();

                sueldo = sd * DiasDePago;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: \r\n \r\n Al obtener los dias de pago y/o factor de pago. \r\n" + error.Message, "Error");
                this.Dispose();
            }
            return sueldo;
        }

               
        private void workerImporta_DoWork(object sender, DoWorkEventArgs e)
        {
            int contador = dgvCargaEmpleados.Rows.Count;
            int progreso = 0;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            foreach (DataGridViewRow fila in dgvCargaEmpleados.Rows)
            {

                workerImporta.ReportProgress((progreso * 100) / contador);
                progreso++;

                ph = new Periodos.Core.PeriodosHelper();
                ph.Command = cmd;

                dh = new Departamento.Core.DeptoHelper();
                dh.Command = cmd;

                puestoh = new Puestos.Core.PuestosHelper();
                puestoh.Command = cmd;

                try
                {
                    cnx.Open();
                    idPeriodo = int.Parse(ph.obtenerIdPeriodo(fila.Cells["periodo"].Value.ToString(), GLOBALES.IDEMPRESA).ToString());
                    iddepto = int.Parse(dh.obtenerIdDepartamento(fila.Cells["departamento"].Value.ToString(), GLOBALES.IDEMPRESA).ToString());
                    idpuesto = int.Parse(puestoh.obtenerIdPuesto(fila.Cells["puesto"].Value.ToString(), GLOBALES.IDEMPRESA).ToString());
                    cnx.Close();
                }
                catch {
                    MessageBox.Show(String.Format("Error: Al obtener del Empleado: {0}. Periodo, Departamento yo/ Puesto.\r\nVerifique que el periodo, depto y/o puesto de la empresa existan.\r\n\r\nSe cerrará esta ventana.",
                        fila.Cells["noempleado"].Value.ToString()), "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    cnx.Dispose();
                    workerImporta.CancelAsync();
                    if (workerImporta.CancellationPending == true) {
                        e.Cancel = true;
                        return;
                    }
                }
                
                Empleados.Core.Empleados empleado = new Empleados.Core.Empleados();
                empleado.noempleado = fila.Cells["noempleado"].Value.ToString();
                empleado.nombres = fila.Cells["nombre"].Value.ToString();
                empleado.paterno = fila.Cells["paterno"].Value.ToString();
                empleado.materno = fila.Cells["materno"].Value.ToString();
                empleado.nombrecompleto = String.Format("{0} {1} {2}", empleado.paterno, empleado.materno, empleado.nombres);
                empleado.idempresa = GLOBALES.IDEMPRESA;
                empleado.idperiodo = idPeriodo;
                empleado.idsalario = 0;
                empleado.fechaingreso = DateTime.Parse(fila.Cells["fechaingreso"].Value.ToString()).Date;
                empleado.antiguedad = 0;
                empleado.fechaantiguedad = DateTime.Parse(fila.Cells["fechaingreso"].Value.ToString()).Date;
                empleado.antiguedadmod = 0;
                empleado.fechanacimiento = DateTime.Parse(fila.Cells["fechanacimiento"].Value.ToString()).Date;
                empleado.edad = ObtieneEdad(empleado.fechanacimiento);
                empleado.rfc = fila.Cells["rfc"].Value.ToString();
                empleado.curp = fila.Cells["curp"].Value.ToString();
                empleado.nss = fila.Cells["nss"].Value.ToString().Substring(0, 9);
                empleado.digitoverificador = int.Parse(fila.Cells["nss"].Value.ToString().Substring(fila.Cells["nss"].Value.ToString().Length - 1, 1));
                empleado.tiposalario = 19;
                empleado.sdi = decimal.Parse(fila.Cells["sdi"].Value.ToString());
                empleado.sd = ObtieneSD(decimal.Parse(fila.Cells["sdi"].Value.ToString()));
                empleado.sueldo = ObtieneSueldo(empleado.sd);
                empleado.estatus = GLOBALES.ACTIVO;
                empleado.idusuario = GLOBALES.IDUSUARIO;
                empleado.cuenta = fila.Cells["cuenta"].Value.ToString(); ;
                empleado.clabe = fila.Cells["clabe"].Value.ToString(); ;
                empleado.idbancario = "0000";
                empleado.metodopago = "TRANSFERENCIA";
                empleado.tiporegimen = 60;
                empleado.iddepartamento = iddepto;
                empleado.idpuesto = idpuesto;

                emph = new Empleados.Core.EmpleadosHelper();
                emph.Command = cmd;

                Empleados.Core.Empleados nss = new Empleados.Core.Empleados();
                nss.nss = empleado.nss;
                nss.digitoverificador = empleado.digitoverificador;

                int existeEmpleado = 0;
                try
                {
                    cnx.Open();
                    existeEmpleado = (int)emph.existeEmpleado(nss);
                    cnx.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Al obtener la existencia del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnx.Dispose();
                    return;
                }

                if (existeEmpleado == 0)
                {
                    try
                    {
                        cnx.Open();
                        emph.insertaEmpleado(empleado);
                        cnx.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: Al ingresar al empleado. No. empleado: " + fila.Cells["noempleado"].Value.ToString(), "Error");
                        cnx.Dispose();
                        return;
                    }
                }
            }
            cnx.Dispose();
        }

        private void workerImporta_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblPorcentaje.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void workerImporta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblPorcentaje.Text = "Completada.";
            dgvCargaEmpleados.Rows.Clear();
            this.Dispose();
        }

        private void toolLimpiar_Click(object sender, EventArgs e)
        {
            dgvCargaEmpleados.Rows.Clear();
        }

        private void frmListaCargaEmpleados_Load(object sender, EventArgs e)
        {
            CargaPerfil("Importar empleados");
        }

        private void CargaPerfil(string nombre)
        {
            List<Autorizaciones.Core.Ediciones> lstEdiciones = GLOBALES.PERFILEDICIONES(nombre);

            for (int i = 0; i < lstEdiciones.Count; i++)
            {
                switch (lstEdiciones[i].permiso.ToString())
                {
                    case "Cargar": toolCargar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Aplicar": toolAplicar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                }
            }
        }
    }
}

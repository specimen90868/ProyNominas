using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aExcel = Microsoft.Office.Interop.Excel;

namespace Nominas
{
    public partial class frmListaCargaFaltas : Form
    {
        public frmListaCargaFaltas()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string ruta, nombreEmpresa;
        string ExcelConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;'";
        int idEmpresa;
        Empleados.Core.EmpleadosHelper emph;
        Faltas.Core.FaltasHelper fh;
        DateTime inicio, fin;
        #endregion

        #region VARIABLES PUBLICAS
        public int _tipoNomina;
        public DateTime _inicioPeriodo;
        public DateTime _finPeriodo;
        #endregion

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

                    if (nombreHoja.Equals("Faltas"))
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
                        var fi = xlRange.Cells[3, 4].Value2;
                        var ff = xlRange.Cells[4, 4].Value2;
                        double dfi = double.Parse(fi.ToString());
                        double dff = double.Parse(ff.ToString());
                        inicio = DateTime.FromOADate(dfi);
                        fin = DateTime.FromOADate(dff);

                        if (inicio != _inicioPeriodo && fin != _finPeriodo)
                        {
                            MessageBox.Show("Los datos a ingresar pertenecen a otro periodo. Verifique. \r\n \r\n La ventana se cerrara.", "Error");
                            this.Dispose();
                        }

                        for (int i = 7; i < rowCount; i++)
                        {
                            if (xlRange.Cells[i, 1].Value != null)
                            {
                                dgvCargaFaltas.Rows.Add(
                                    xlRange.Cells[i, 1].Value, //no empleado
                                    xlRange.Cells[i, 2].Value, //faltas
                                    xlRange.Cells[3, 4].Value, //fechainicio
                                    xlRange.Cells[4, 4].Value); //fechafin
                            }
                        }

                        Marshal.ReleaseComObject(xlRange);
                        Marshal.ReleaseComObject(xlWorkSheet);

                        xlWorkbook.Close();
                        Marshal.ReleaseComObject(xlWorkbook);

                        xlApp.Quit();
                        Marshal.ReleaseComObject(xlApp);

                        for (int i = 0; i < dgvCargaFaltas.Columns.Count; i++)
                        {
                            dgvCargaFaltas.AutoResizeColumn(i);
                        }
                    }
                    else {
                        MessageBox.Show("Información:\r\n" +
                                        "El layout elegido no corresponde al layout de faltas.\r\n" +
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
            if (dgvCargaFaltas.Rows.Count == 0)
            {
                MessageBox.Show("No se puede aplicar verifique.", "Error");
                return;
            }

            int idEmpleado = 0;
            bool EsAlta = false, EsReingreso = false, EsBaja = false;

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            
            fh = new Faltas.Core.FaltasHelper();
            fh.Command = cmd;

            emph = new Empleados.Core.EmpleadosHelper();
            emph.Command = cmd;

            Altas.Core.AltasHelper ah = new Altas.Core.AltasHelper();
            ah.Command = cmd;

            Reingreso.Core.ReingresoHelper rh = new Reingreso.Core.ReingresoHelper();
            rh.Command = cmd;

            Bajas.Core.BajasHelper bh = new Bajas.Core.BajasHelper();
            bh.Command = cmd;

            Periodos.Core.PeriodosHelper ph = new Periodos.Core.PeriodosHelper();
            ph.Command = cmd;


            List<Altas.Core.Altas> lstAlta;
            List<Reingreso.Core.Reingresos> lstReingreso;
            List<Bajas.Core.Bajas> lstBaja;

            foreach (DataGridViewRow fila in dgvCargaFaltas.Rows)
            {
                try
                {
                    cnx.Open();
                    idEmpleado = (int)emph.obtenerIdTrabajador(fila.Cells["noempleado"].Value.ToString(), idEmpresa);
                    cnx.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: Obtener ID del empleado. \r\n \r\n" + error.Message, "Error");
                    return;
                }

                int idperiodo = 0;
                try
                {
                    cnx.Open();
                    idperiodo = (int)emph.obtenerIdPeriodo(idEmpleado);
                    cnx.Close();
                }
                catch
                {
                    MessageBox.Show("Error: al obtener el Id del Periodo.", "Error");
                    cnx.Dispose();
                    return;
                }

                Altas.Core.Altas alta = new Altas.Core.Altas();
                alta.idempresa = GLOBALES.IDEMPRESA;
                alta.idtrabajador = idEmpleado;
                alta.periodoInicio = _inicioPeriodo.Date;
                alta.periodoFin = _finPeriodo.Date;

                Reingreso.Core.Reingresos reingreso = new Reingreso.Core.Reingresos();
                reingreso.idempresa = GLOBALES.IDEMPRESA;
                reingreso.idtrabajador = idEmpleado;
                reingreso.periodoinicio = _inicioPeriodo.Date;
                reingreso.periodofin = _finPeriodo.Date;

                Bajas.Core.Bajas baja = new Bajas.Core.Bajas();
                baja.idempresa = GLOBALES.IDEMPRESA;
                baja.idtrabajador = idEmpleado;
                baja.periodoinicio = _inicioPeriodo.Date;
                baja.periodofin = _finPeriodo.Date;

                lstAlta = new List<Altas.Core.Altas>();
                lstReingreso = new List<Reingreso.Core.Reingresos>();
                lstBaja = new List<Bajas.Core.Bajas>();

                Periodos.Core.Periodos p = new Periodos.Core.Periodos();
                p.idperiodo = idperiodo;

                int periodo = 0;
                try
                {
                    cnx.Open();
                    periodo = (int)ph.DiasDePago(p);

                    lstAlta = ah.obtenerAlta(alta);
                    lstReingreso = rh.obtenerReingreso(reingreso);
                    lstBaja = bh.obtenerBaja(baja);
                    cnx.Close();
                }
                catch
                {
                    MessageBox.Show("Error: al obtener los dias de pago.", "Error");
                    cnx.Dispose();
                    return;
                }

                if (lstAlta.Count != 0)
                    EsAlta = true;
                if (lstBaja.Count != 0)
                    EsBaja = true;
                if (lstReingreso.Count != 0)
                    EsReingreso = true;

                int falta = int.Parse(fila.Cells["faltas"].Value.ToString());
                DateTime fecha = DateTime.Parse(fila.Cells["fechainicio"].Value.ToString());

                if (falta > 15)
                    falta = 15;

                for (int i = 0; i < falta; i++)
                {
                    int existe = 0;
                    int existeFalta = 0;
                    int existeVacacion = 0;
                    try
                    {
                        cnx.Open();
                        existeFalta = (int)fh.existeFalta(idEmpleado, fecha.AddDays(i).Date);
                        cnx.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Al verificar existencia de falta.", "Error");
                        cnx.Dispose();
                        return;
                    }

                    if (existeFalta == 0)
                    {
                        Incidencias.Core.IncidenciasHelper ih = new Incidencias.Core.IncidenciasHelper();
                        ih.Command = cmd;

                        Vacaciones.Core.VacacionesHelper vh = new Vacaciones.Core.VacacionesHelper();
                        vh.Command = cmd;

                        bool FLAG_FALTAS = false;

                        if (EsAlta)
                        {
                            if (fecha.AddDays(i).Date < lstAlta[0].fechaingreso.Date)
                            {
                                MessageBox.Show("Información: Alta del empleado: " + 
                                    fila.Cells["noempleado"].Value.ToString() + 
                                    ", Fecha de Ingreso = " + lstAlta[0].fechaingreso.Date.ToShortDateString() + 
                                    "\r\n Fecha de la falta es menor.", "Información",
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Exclamation);
                                FLAG_FALTAS = true;
                            }
                            else
                                FLAG_FALTAS = false;
                        }

                        if (EsReingreso)
                        {
                            if (fecha.AddDays(i).Date < lstReingreso[0].fechaingreso.Date)
                            {
                                MessageBox.Show("Información: Reingreso del empleado: " + 
                                    fila.Cells["noempleado"].Value.ToString() + 
                                    ", Fecha de Reingreso = " + lstReingreso[0].fechaingreso.Date.ToShortDateString() +
                                    "\r\n Fecha de la falta es menor.", "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                FLAG_FALTAS = true;
                            }
                            else
                                FLAG_FALTAS = false;
                        }

                        if (EsBaja)
                        {
                            if (fecha.AddDays(i).Date > lstBaja[0].fecha.Date)
                            {
                                MessageBox.Show("Información: Baja del empleado " + 
                                    fila.Cells["noempleado"].Value.ToString() + 
                                    ", Fecha de Reingreso = " + lstBaja[0].fecha.Date.ToShortDateString() +
                                    "\r\n Fecha de la falta es mayor.", "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                FLAG_FALTAS = true;
                            }
                            else
                                FLAG_FALTAS = false;
                        }

                        if (!FLAG_FALTAS)
                        {
                            try
                            {
                                cnx.Open();
                                existe = (int)ih.existeIncidenciaEnFalta(idEmpleado, fecha.AddDays(i).Date);
                                existeVacacion = (int)vh.existeVacacionEnFalta(idEmpleado, fecha.AddDays(i).Date);
                                cnx.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Error: Al guardar la falta.", "Error");
                                cnx.Dispose();
                                return;
                            }

                            if (existe == 0 && existeVacacion == 0)
                                try
                                {
                                    Faltas.Core.Faltas f = new Faltas.Core.Faltas();
                                    f.idempresa = GLOBALES.IDEMPRESA;
                                    f.idtrabajador = idEmpleado;
                                    f.periodo = periodo;
                                    f.faltas = 1;
                                    f.fechainicio = inicio;
                                    f.fechafin = fin;
                                    f.fecha = fecha.AddDays(i).Date;

                                    cnx.Open();
                                    fh.insertaFalta(f);
                                    cnx.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("Error: Al guardar la falta.", "Error");
                                    cnx.Dispose();
                                }
                            else
                                MessageBox.Show("No. de Empleado: " + fila.Cells["noempleado"].Value.ToString() + 
                                    "La falta ingresada: " + fecha.AddDays(i).Date.ToShortDateString() + 
                                    ", se empalma con una incapacidad y/o dia de vacación del trabajador.", "Información", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                        }
                    }
                }
                EsAlta = false; EsReingreso = false; EsBaja = false;
            }
            MessageBox.Show("Faltas importadas", "Confirmación");
            cnx.Dispose();
            dgvCargaFaltas.Rows.Clear();

        }

        private void toolLimpiar_Click(object sender, EventArgs e)
        {
            dgvCargaFaltas.Rows.Clear();
        }

        private void frmListaCargaFaltas_Load(object sender, EventArgs e)
        {
            dgvCargaFaltas.RowHeadersVisible = false;
        }
    }
}

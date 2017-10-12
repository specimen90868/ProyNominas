using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmListaCargaVacaciones : Form
    {
        public frmListaCargaVacaciones()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        SqlBulkCopy bulk;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string ruta, nombreEmpresa = "";
        string ExcelConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;'";
        int idEmpresa;
        Empleados.Core.EmpleadosHelper emph;
        Vacaciones.Core.VacacionesHelper vh;
        Periodos.Core.PeriodosHelper ph;
        Complementos.Core.ComplementoHelper ch;
        #endregion

        #region VARIABLES PUBLICA
        public int _tipoNomina;
        public DateTime _inicioPeriodo;
        public DateTime _finPeriodo;
        public int _periodo;
        #endregion

        private void toolCargar_Click(object sender, EventArgs e)
        {
             string conStr, sheetName;
            DateTime inicio, fin;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar Excel";
            ofd.RestoreDirectory = false;
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Documentos de Excel|*.xls;*.xlsx";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                ruta = ofd.FileName;
                conStr = string.Empty;
                conStr = string.Format(ExcelConString, ruta);

                try
                {

                    using (OleDbConnection con = new OleDbConnection(conStr))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = con;
                            con.Open();
                            DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                            con.Close();
                        }
                    }

                    if (sheetName == "Vacaciones$")
                    {
                        using (OleDbConnection con = new OleDbConnection(conStr))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                using (OleDbDataAdapter oda = new OleDbDataAdapter())
                                {
                                    DataTable dt = new DataTable();
                                    cmd.CommandText = "SELECT * From [" + sheetName + "]";
                                    cmd.Connection = con;
                                    con.Open();
                                    oda.SelectCommand = cmd;
                                    oda.Fill(dt);
                                    con.Close();

                                    nombreEmpresa = dt.Columns[1].ColumnName;
                                    idEmpresa = int.Parse(dt.Columns[3].ColumnName.ToString());
                                    inicio = DateTime.Parse(dt.Rows[1][1].ToString());
                                    fin = DateTime.Parse(dt.Rows[2][1].ToString());

                                    if (GLOBALES.IDEMPRESA != idEmpresa)
                                    {
                                        MessageBox.Show("Los datos a ingresar pertenecen a otra empresa. Verifique. \r\n \r\n La ventana se cerrara.", "Error");
                                        this.Dispose();
                                    }

                                    if (inicio != _inicioPeriodo && fin != _finPeriodo)
                                    {
                                        MessageBox.Show("Los datos a ingresar pertenecen a otro periodo. Verifique. \r\n \r\n La ventana se cerrara.", "Error");
                                        this.Dispose();
                                    }

                                    for (int i = 5; i < dt.Rows.Count; i++)
                                    {
                                        if (dt.Rows[i][0].ToString() != "")
                                            dgvCargaVacaciones.Rows.Add(
                                                dt.Rows[i][0].ToString(), //NO EMPLEADO
                                                dt.Rows[i][1].ToString(), //CONCEPTO
                                                dt.Rows[i][2].ToString(), //DIAS
                                                dt.Rows[1][1].ToString(), //FECHA INICIO
                                                dt.Rows[2][1].ToString(), //FECHA FIN
                                                dt.Rows[i][3].ToString(),
                                                dt.Rows[i][4].ToString(),
                                                dt.Rows[i][5].ToString(),
                                                dt.Rows[i][6].ToString()); //FECHA INICIO VACACIONES
                                    }

                                    for (int i = 0; i < dgvCargaVacaciones.Columns.Count; i++)
                                    {
                                        dgvCargaVacaciones.AutoResizeColumn(i);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Información:\r\n" +
                                        "El layout elegido no corresponde al layout de vacaciones.\r\n" +
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
            if (dgvCargaVacaciones.Rows.Count == 0)
            {
                MessageBox.Show("No se puede aplicar verifique.", "Error");
                return;
            }

            workVacaciones.RunWorkerAsync();
            
        }

        private void toolLimpiar_Click(object sender, EventArgs e)
        {
            dgvCargaVacaciones.Rows.Clear();
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            //frmVacaciones v = new frmVacaciones();
            //v.OnVacacion += v_OnVacacion;
            //v._tipoNomina = _tipoNomina;
            //v._ventana = "Carga";
            //v.MdiParent = this.MdiParent;
            //v.Show();
        }

        void v_OnVacacion(string noempleado, string nombre, string paterno, string materno, bool prima, bool pago, int diaspagopv, bool vacacion, int diaspago, DateTime fechainicio, DateTime fechafin)
        {
            dgvCargaVacaciones.Rows.Add(noempleado,nombre,paterno,materno,prima,pago,diaspagopv,vacacion,diaspago,fechainicio,fechafin);
        }

        private void workVacaciones_DoWork(object sender, DoWorkEventArgs e)
        {
            int idEmpleado = 0;
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            List<Vacaciones.Core.VacacionesPrima> lstMovimientos = new List<Vacaciones.Core.VacacionesPrima>();

            vh = new Vacaciones.Core.VacacionesHelper();
            vh.Command = cmd;

            emph = new Empleados.Core.EmpleadosHelper();
            emph.Command = cmd;

            ph = new Periodos.Core.PeriodosHelper();
            ph.Command = cmd;

            ch = new Complementos.Core.ComplementoHelper();
            ch.Command = cmd;

            object objObservaciones = null;
            string observaciones = null;
            string nuevaObservacion = null;
            DateTime fechaIngreso;
            int anios = 0;

            foreach (DataGridViewRow fila in dgvCargaVacaciones.Rows)
            {
                if (!fila.Cells["noempleado"].Value.ToString().Equals(""))
                {
                    try
                    {
                        cnx.Open();
                        idEmpleado = (int)emph.obtenerIdTrabajador(fila.Cells["noempleado"].Value.ToString(), idEmpresa);
                        cnx.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: \r\n" +
                                        "No se pudo obtener el ID del empleado: " + fila.Cells["noempleado"].Value.ToString() + ".\r\n\r\n" + 
                                        "Mensaje: " + error.Message + "\r\n" +
                                        "Se cerrará la conexión.", "Error", 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);
                        cnx.Dispose();
                        this.Dispose();
                    }

                    Empleados.Core.Empleados empleado = new Empleados.Core.Empleados();
                    empleado.idtrabajador = idEmpleado;

                    Complementos.Core.Complemento complemento = new Complementos.Core.Complemento();
                    complemento.idtrabajador = idEmpleado;

                    List<Empleados.Core.Empleados> lstEmpleado = new List<Empleados.Core.Empleados>();
                    
                    try
                    {
                        cnx.Open();
                        lstEmpleado = emph.obtenerEmpleado(empleado);
                        objObservaciones = ch.obtenerObservacionesTrabajador(complemento);
                        cnx.Close();
                        observaciones = objObservaciones == null ? "" : objObservaciones.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Al obtener los datos del empleado.", "Error");
                        cnx.Dispose();
                        this.Dispose();
                    }

                    fechaIngreso = lstEmpleado[0].fechaingreso;
                    anios = (DateTime.Now.Subtract(fechaIngreso).Days / 365);


                    if (anios > 0)
                    {
                        Vacaciones.Core.DiasDerecho dd = new Vacaciones.Core.DiasDerecho();
                        //dd.anio = lstEmpleado[0].antiguedad;
                        dd.anio = int.Parse(fila.Cells["aniversario"].Value.ToString());

                        int dias = 0;
                        try
                        {
                            cnx.Open();
                            dias = (int)vh.diasDerecho(dd);
                            cnx.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Error: Al obtener los dias por derecho del empleado.", "Error");
                            cnx.Dispose();
                            return;
                        }

                        Faltas.Core.FaltasHelper fh = new Faltas.Core.FaltasHelper();
                        fh.Command = cmd;

                        Faltas.Core.Faltas falta = new Faltas.Core.Faltas();
                        falta.idempresa = GLOBALES.IDEMPRESA;
                        falta.idtrabajador = idEmpleado;
                        falta.fechainicio = DateTime.Parse(dgvCargaVacaciones.Rows[0].Cells["inicio"].Value.ToString());
                        falta.fechafin = DateTime.Parse(dgvCargaVacaciones.Rows[0].Cells["fin"].Value.ToString());

                        int existeFaltas = 0;
                        try
                        {
                            cnx.Open();
                            existeFaltas = (int)fh.existeFalta(falta);
                            cnx.Close();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error: Al obtener las faltas del trabajador. \r\n" + error.Message, "Error");
                            cnx.Dispose();
                            return;
                        }

                        Incidencias.Core.IncidenciasHelper ih = new Incidencias.Core.IncidenciasHelper();
                        ih.Command = cmd;

                        int existeIncapacidad = 0;
                        try
                        {
                            cnx.Open();
                            existeIncapacidad = int.Parse(ih.diasIncidencia(idEmpleado, 
                                DateTime.Parse(dgvCargaVacaciones.Rows[0].Cells["inicio"].Value.ToString()).Date,
                                DateTime.Parse(dgvCargaVacaciones.Rows[0].Cells["fin"].Value.ToString()).Date).ToString());
                            cnx.Close();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error: Al obtener los dias de incidencia del trabajador. \r\n" + error.Message, "Error");
                            cnx.Dispose();
                            return;
                        }


                        int idperiodo = 0;
                        try
                        {
                            cnx.Open();
                            idperiodo = (int)emph.obtenerIdPeriodo(idEmpleado);
                            cnx.Close();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error: Al obtener el id del periodo. \r\n" + error.Message, "Error");
                            cnx.Dispose();
                            return;
                        }
                        Periodos.Core.Periodos p = new Periodos.Core.Periodos();
                        p.idperiodo = idperiodo;

                        int diasPeriodo = 0;
                        try
                        {
                            cnx.Open();
                            diasPeriodo = (int)ph.DiasDePago(p);
                            cnx.Close();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Error: Al obtener los dias del periodo. \r\n" + error.Message, "Error");
                            cnx.Dispose();
                            return;
                        }

                        Vacaciones.Core.VacacionesPrima vp = new Vacaciones.Core.VacacionesPrima();
                        vp.idtrabajador = idEmpleado;
                        vp.idempresa = GLOBALES.IDEMPRESA;
                        vp.periodoinicio = DateTime.Parse(dgvCargaVacaciones.Rows[0].Cells["inicio"].Value.ToString());
                        vp.periodofin = DateTime.Parse(dgvCargaVacaciones.Rows[0].Cells["fin"].Value.ToString());
                        vp.diasderecho = dias;
                        vp.fechapago = DateTime.Now.Date;
                        vp.vacacionesprima = fila.Cells["concepto"].Value.ToString() == "Prima Vacacional" ? "P" : "V";
                        vp.aniversario = int.Parse(fila.Cells["aniversario"].Value.ToString());

                        if (fila.Cells["concepto"].Value.ToString().Equals("Prima Vacacional"))
                        {
                            vp.diaspago = dias;
                            vp.diaspendientes = 0;
                            vp.fechainicio = DateTime.Now.Date;
                            vp.fechafin = DateTime.Now.Date;

                            cnx.Open();
                            nuevaObservacion = observaciones + "\r\n" + "Pago de Prima Vacacional; " + (_periodo == 7 ? "Semana: " : "Quincena: ") +
                                fila.Cells["noperiodo"].Value.ToString() + "-" + DateTime.Now.Year.ToString() + "; Aniversario: " + fila.Cells["aniversario"].Value.ToString() + "; " +
                                fila.Cells["observaciones"].Value.ToString();
                            complemento.observaciones = nuevaObservacion;
                            ch.actualizaObservacionesTrabajador(complemento);
                            cnx.Close();

                        }
                        else
                        {
                            int diasPagoReales = int.Parse(fila.Cells["diaspago"].Value.ToString()) + existeFaltas + existeIncapacidad;

                            if (diasPagoReales > diasPeriodo)
                            {
                                diasPagoReales = diasPeriodo - existeFaltas - existeIncapacidad;
                                MessageBox.Show("Existen faltas del trabajador, se ajustaron las vacaciones a: " + diasPagoReales.ToString() + " dia(s).", "Información",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                diasPagoReales = int.Parse(fila.Cells["diaspago"].Value.ToString());
                            }

                            vp.diaspago = diasPagoReales;
                            vp.diaspendientes = dias - diasPagoReales;
                            vp.fechainicio = DateTime.Parse(fila.Cells["fechaaplicacion"].Value.ToString());
                            vp.fechafin = DateTime.Parse(fila.Cells["fechaaplicacion"].Value.ToString()).AddDays(diasPagoReales - 1);


                            cnx.Open();
                            nuevaObservacion = observaciones + "\r\n" + "Pago de Vacaciones; " + (_periodo == 7 ? "Semana: " : "Quincena: ") +
                                fila.Cells["noperiodo"].Value.ToString() + "-" + DateTime.Now.Year.ToString() + "; Aniversario: " + fila.Cells["aniversario"].Value.ToString() + "; " +
                                "Días disfrutados: " + diasPagoReales.ToString() + "; Días pendientes: " + (dias - diasPagoReales).ToString() + "; " + fila.Cells["observaciones"].Value.ToString();
                            complemento.observaciones = nuevaObservacion;
                            ch.actualizaObservacionesTrabajador(complemento);
                            cnx.Close();
                            lstMovimientos.Add(vp);
                        }
                    }
                }
            }

            bulk = new SqlBulkCopy(cnx);
            vh.bulkCommand = bulk;

            DataTable dt = new DataTable();
            DataRow dtFila;
            dt.Columns.Add("id", typeof(Int32));
            dt.Columns.Add("idtrabajador", typeof(Int32));
            dt.Columns.Add("idempresa", typeof(Int32));
            dt.Columns.Add("periodoinicio", typeof(DateTime));
            dt.Columns.Add("periodofin", typeof(DateTime));
            dt.Columns.Add("diasderecho", typeof(Int32));
            dt.Columns.Add("diaspago", typeof(Int32));
            dt.Columns.Add("diaspendientes", typeof(Int32));
            dt.Columns.Add("fechapago", typeof(DateTime));
            dt.Columns.Add("vacacionesprima", typeof(String));
            dt.Columns.Add("fechainicio", typeof(DateTime));
            dt.Columns.Add("fechafin", typeof(DateTime));
            dt.Columns.Add("aniversario", typeof(Int32));

            int index = 1;
            for (int i = 0; i < lstMovimientos.Count; i++)
            {
                dtFila = dt.NewRow();
                dtFila["id"] = i + 1;
                dtFila["idtrabajador"] = lstMovimientos[i].idtrabajador;
                dtFila["idempresa"] = lstMovimientos[i].idempresa;
                dtFila["periodoinicio"] = lstMovimientos[i].periodoinicio;
                dtFila["periodofin"] = lstMovimientos[i].periodofin;
                dtFila["diasderecho"] = lstMovimientos[i].diasderecho;
                dtFila["diaspago"] = lstMovimientos[i].diaspago;
                dtFila["diaspendientes"] = lstMovimientos[i].diaspendientes;
                dtFila["fechapago"] = lstMovimientos[i].fechapago;
                dtFila["vacacionesprima"] = lstMovimientos[i].vacacionesprima;
                dtFila["fechainicio"] = lstMovimientos[i].fechainicio;
                dtFila["fechafin"] = lstMovimientos[i].fechafin;
                dtFila["aniversario"] = lstMovimientos[i].aniversario;
                dt.Rows.Add(dtFila);
                index++;
            }

            try
            {
                cnx.Open();
                vh.bulkVacaciones(dt, "tmpVacacionesPrima");
                vh.stpVacaciones();
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error (DataTable): \r\n \r\n" + error.Message, "Error");
            }

        }

        private void workVacaciones_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Vacación aplicada.", "Confirmación");
            dgvCargaVacaciones.Rows.Clear();
        }

        private void frmListaCargaVacaciones_Load(object sender, EventArgs e)
        {
            CargaPerfil();
        }

        private void CargaPerfil()
        {
            List<Autorizaciones.Core.Ediciones> lstEdiciones = GLOBALES.PERFILEDICIONES("Carga Vacaciones");

            for (int i = 0; i < lstEdiciones.Count; i++)
            {
                switch (lstEdiciones[i].permiso.ToString())
                {
                    case "Cargar": toolCargar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion);
                        break;
                    case "Aplicar": toolAplicar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion);
                        break;
                }
            }
        }
    }
}

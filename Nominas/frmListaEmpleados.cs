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

namespace Nominas
{
    public partial class frmListaEmpleados : Form
    {
        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        List<Empleados.Core.CatalogoEmpleado> lstEmpleados;
        #endregion

        #region VARIABLES PUBLICAS
        public int _empleadoAltaBaja;
        #endregion

        private void frmListaEmpleados_Load(object sender, EventArgs e) 
        {
            dgvEmpleados.RowHeadersVisible = false;
            ListaEmpleados("", 0, "T", "", "", "");
            CargaPerfil(GLOBALES.ACTIVO, "Empleados de nómina");
        }

        private void ListaEmpleados(string criterio, int indice, string tipocriterio, string nombre, string paterno, string materno)
        {
            string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            
            Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
            eh.Command = cmd;
            
            dgvEmpleados.DataSource = null;

            try
            {
                cnx.Open();
                if (tipocriterio == "T")
                    lstEmpleados = eh.obtenerEmpleados(GLOBALES.IDEMPRESA, criterio, indice);
                else
                    lstEmpleados = eh.obtenerEmpleados(GLOBALES.IDEMPRESA, nombre, paterno, materno);
                cnx.Close();
                cnx.Dispose();

                var em = from e in lstEmpleados orderby e.noempleado ascending
                         select new
                         {
                             NoFila = e.rownumber,
                             IdTrabajador = e.idtrabajador,
                             NoEmpleado = e.noempleado,
                             Nombre = e.nombrecompleto,
                             Ingreso = e.fechaingreso,
                             Antiguedad = e.antiguedad + " AÑOS",
                             SDI = e.sdi,
                             SD = e.sd,
                             Sueldo = e.sueldo,
                             Cuenta = e.cuenta,
                             Estado = e.estatus,
                             Departamento = e.departamento,
                             Puesto = e.puesto,
                             FechaBaja = e.fechabaja
                         };

                dgvEmpleados.DataSource = em.ToList();

                for (int i = 0; i < dgvEmpleados.Columns.Count; i++)
                {
                    dgvEmpleados.AutoResizeColumn(i);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
            }

            DataGridViewCellStyle estilo = new DataGridViewCellStyle();
            estilo.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEmpleados.Columns[6].DefaultCellStyle = estilo;
            dgvEmpleados.Columns[7].DefaultCellStyle = estilo;
            dgvEmpleados.Columns[8].DefaultCellStyle = estilo;

            dgvEmpleados.Columns["IdTrabajador"].Visible = false;
        }

        private void CargaPerfil(int activo_inactivo, string nombre)
        {
            List<Autorizaciones.Core.Ediciones> lstEdiciones = GLOBALES.PERFILEDICIONES(nombre);

            for (int i = 0; i < lstEdiciones.Count; i++)
            {
                switch (lstEdiciones[i].permiso.ToString())
                {
                    case "Crear": toolNuevo.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Consular": toolConsultar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Editar": toolEditar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Baja": toolBaja.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Historial": toolHistorial.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Reingreso": toolReingreso.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Eliminar": toolEliminar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Incrementar Salario": toolIncrementoSalario.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Depto/Puesto": toolDeptoPuesto.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Periodo": toolCambioPeriodo.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Nomina Digital": toolNominaDigital.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Exportar": toolExportar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                }
            }
        }

        private void Seleccion(int edicion)
        {
            if (GLOBALES.FORMISOPEN("frmEmpleados"))
                return;

            frmEmpleados empleado = new frmEmpleados();
            //empleado.MdiParent = this.MdiParent;
            empleado.OnNuevoEmpleado += e_OnNuevoEmpleado;
            if (!edicion.Equals(GLOBALES.NUEVO))
            {
                if (dgvEmpleados.Rows.Count != 0)
                {
                    int fila = 0;
                    fila = dgvEmpleados.CurrentCell.RowIndex;
                    empleado._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                }
                else
                {
                    MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            empleado._tipoOperacion = edicion;
            empleado.StartPosition = FormStartPosition.CenterScreen;
            empleado.Show();
            
        }

        void e_OnNuevoEmpleado(int edicion)
        {
            if (edicion == GLOBALES.NUEVO || edicion == GLOBALES.MODIFICAR)
                ListaEmpleados("", 0, "T", "", "", "");
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccion(GLOBALES.CONSULTAR);
        }

        private void toolModificarSalario_Click(object sender, EventArgs e)
        {
            //int fila = dgvEmpleados.CurrentCell.RowIndex;
            //frmModificaSalarioImss msi = new frmModificaSalarioImss();
            //msi.MdiParent = this.MdiParent;
            //msi._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[0].Value.ToString());
            //msi._nombreCompleto = dgvEmpleados.Rows[fila].Cells[1].Value.ToString();
            //msi.Show();
        }

        private void frmListaEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void toolIncrementoSalario_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                if (GLOBALES.FORMISOPEN("frmIncrementoSalarial"))
                    return;

                int fila = dgvEmpleados.CurrentCell.RowIndex;
                frmIncrementoSalarial isal = new frmIncrementoSalarial();
                isal.OnIncrementoSalarial += isal_OnIncrementoSalarial;
                isal.StartPosition = FormStartPosition.CenterScreen;
                isal._nombreEmpleado = dgvEmpleados.Rows[fila].Cells[3].Value.ToString();
                isal._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                isal.Show();
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        void isal_OnIncrementoSalarial()
        {
            ListaEmpleados("", 0, "T", "", "", "");
        }

        private void toolHistorial_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                if (GLOBALES.FORMISOPEN("frmListaHistorial"))
                    return;

                int fila = dgvEmpleados.CurrentCell.RowIndex;
                frmListaHistorial lh = new frmListaHistorial();
                //lh.MdiParent = this.MdiParent;
                lh.StartPosition = FormStartPosition.CenterScreen;
                lh._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                lh.Show();
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                //int estatus = 0;
                string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
                int fila = dgvEmpleados.CurrentCell.RowIndex;
                int idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());

                cnx = new SqlConnection(cdn);
                cmd = new SqlCommand();
                cmd.Connection = cnx;

                Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
                eh.Command = cmd;

                Empleados.Core.Empleados empleado = new Empleados.Core.Empleados();
                empleado.idtrabajador = idempleado;
                empleado.idempresa = GLOBALES.IDEMPRESA;
                empleado.idusuario = GLOBALES.IDUSUARIO;
                empleado.noempleado = dgvEmpleados.Rows[fila].Cells[2].Value.ToString();
                empleado.nombrecompleto = dgvEmpleados.Rows[fila].Cells[3].Value.ToString();

                //try
                //{
                //    cnx.Open();
                //    estatus = (int)eh.obtenerEstatus(empleado);
                //    cnx.Close();
                //    cnx.Dispose();
                //}
                //catch (Exception error)
                //{
                //    MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                //}

                //if (estatus.Equals(1)) {}
                //else { MessageBox.Show("El empleado no puede ser eliminado. Ya tiene movimientos registrados.", "Confirmación"); }

                DialogResult respuesta = MessageBox.Show("¿Quiere eliminar la trabajador?. \r\n \r\n CUIDADO. Esta acción eliminará permanentemente el Empleado.", "Confirmación", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        cnx.Open();
                        eh.insertaBitacora(GLOBALES.IDUSUARIO, idempleado, GLOBALES.IDEMPRESA, "Trabajadores", "DELETE", String.Format("IDEMPLEADO: {0}", idempleado));
                        eh.eliminarEmpleado(empleado);
                        cnx.Close();
                        cnx.Dispose();
                        ListaEmpleados("", 0, "T", "", "", "");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        void b_OnBajaEmpleado(int baja)
        {
            _empleadoAltaBaja = baja;
            ListaEmpleados("", 0, "T", "", "", "");
        }

        void r_OnReingreso(int edicion)
        {
            if (edicion == GLOBALES.NUEVO)
                ListaEmpleados("", 0, "T", "", "", "");
        }

        private void toolExportar_Click(object sender, EventArgs e)
        {
            
        }

        private void toolActualizar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.RowHeadersVisible = false;
            ListaEmpleados("", 0, "T", "", "", "");
        }

        private void toolCatNomina_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmExportaEmpleado"))
                return;
            frmExportarEmpleado ee = new frmExportarEmpleado();
            ee._tipoReporte = GLOBALES.EXPORTACATALOGO_NOMINA;
            ee.StartPosition = FormStartPosition.CenterScreen;
            ee.Show();
        }

        private void toolCatGeneral_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmExportaEmpleado"))
                return;

            frmExportarEmpleado ee = new frmExportarEmpleado();
            ee._tipoReporte = GLOBALES.EXPORTACATALOGO_GENERAL;
            ee.StartPosition = FormStartPosition.CenterScreen;
            ee.Show();
        }

        private void toolDepartamento_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                if (GLOBALES.FORMISOPEN("frmDeptoPuesto"))
                    return;

                int fila = dgvEmpleados.CurrentCell.RowIndex;
                frmDeptoPuesto dp = new frmDeptoPuesto();
                dp._deptopuesto = 0;
                dp.StartPosition = FormStartPosition.CenterScreen;
                dp._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                dp.Show();
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void toolPuesto_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                if (GLOBALES.FORMISOPEN("frmDeptoPuesto"))
                    return;

                int fila = dgvEmpleados.CurrentCell.RowIndex;
                frmDeptoPuesto dp = new frmDeptoPuesto();
                dp._deptopuesto = 1;
                dp.StartPosition = FormStartPosition.CenterScreen;
                dp._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                dp.Show();
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void toolCambioPeriodo_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0) 
            {
                if (GLOBALES.FORMISOPEN("frmPeriodoTrabajador"))
                    return;
                int fila = dgvEmpleados.CurrentCell.RowIndex;
                frmPeriodoTrabajador pt = new frmPeriodoTrabajador();
                pt.StartPosition = FormStartPosition.CenterScreen;
                pt._idEmpleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                pt.Show();
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void toolBusqueda_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolNominaDigital_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                int fila = dgvEmpleados.CurrentCell.RowIndex;
                frmTrabajadorNominaDigital tnd = new frmTrabajadorNominaDigital();
                tnd.StartPosition = FormStartPosition.CenterScreen;
                tnd._idEmpleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                tnd.Show();
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void toolNuevo_Click(object sender, EventArgs e)
        {
            Seleccion(GLOBALES.NUEVO);
        }

        private void toolConsultar_Click(object sender, EventArgs e)
        {
            Seleccion(GLOBALES.CONSULTAR);
        }

        private void toolEditar_Click(object sender, EventArgs e)
        {
            Seleccion(GLOBALES.MODIFICAR);
        }

        private void toolBaja_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count != 0)
            {
                if (GLOBALES.FORMISOPEN("frmBaja"))
                    return;

                int fila = dgvEmpleados.CurrentCell.RowIndex;

                string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
                cnx = new SqlConnection(cdn);
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
                eh.Command = cmd;

                Empleados.Core.Empleados empleado = new Empleados.Core.Empleados();
                empleado.idtrabajador = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());

                int estatus = 0;
                try
                {
                    cnx.Open();
                    estatus = (int)eh.obtenerEstatus(empleado);
                    cnx.Close();
                    cnx.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Al obtener el estatus de trabajador.", "Error");
                    cnx.Dispose();
                    return;
                }

                if (estatus == 1 || estatus == 2)
                {
                    frmBaja b = new frmBaja();
                    b.OnBajaEmpleado += b_OnBajaEmpleado;
                    //b.MdiParent = this.MdiParent;
                    b.StartPosition = FormStartPosition.CenterScreen;
                    b._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                    b._nombreEmpleado = dgvEmpleados.Rows[fila].Cells[3].Value.ToString();
                    b.Show();
                }
                else
                {
                    MessageBox.Show("El trabajador actualmente en baja.", "Información");
                }
            }
            else
            {
                MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private void toolReingreso_Click(object sender, EventArgs e)
        {
            if (GLOBALES.FORMISOPEN("frmReingresoEmpleado"))
                return;

            int fila = dgvEmpleados.CurrentCell.RowIndex;
            string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
            eh.Command = cmd;

            Empleados.Core.Empleados empleado = new Empleados.Core.Empleados();
            empleado.idtrabajador = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());

            int estatus = 0;
            try
            {
                cnx.Open();
                estatus = (int)eh.obtenerEstatus(empleado);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Al obtener el estatus de trabajador.", "Error");
                cnx.Dispose();
                return;
            }

            if (estatus == 0)
            {
                frmReingresoEmpleado r = new frmReingresoEmpleado();
                r.OnReingreso += r_OnReingreso;
                r.StartPosition = FormStartPosition.CenterScreen;
                r._idempleado = int.Parse(dgvEmpleados.Rows[fila].Cells[1].Value.ToString());
                r._nombreEmpleado = dgvEmpleados.Rows[fila].Cells[3].Value.ToString();
                r.Show();
            }
            else
            {
                MessageBox.Show("El trabajador no puede ser reingresado. Estatus: Alta", "Información");
            }
        }

        private void toolAtras_Click(object sender, EventArgs e)
        {
            if (!toolAdelante.Enabled)
                toolAdelante.Enabled = true;

            int indice = int.Parse(dgvEmpleados.Rows[0].Cells[0].Value.ToString());
            if (indice != 1)
            {
                ListaEmpleados("", (indice - 101), "T", "", "", "");
            }
            else
            {
                toolAtras.Enabled = false;
            }
                
        }

        private void toolAdelante_Click(object sender, EventArgs e)
        {
            if (!toolAtras.Enabled)
                toolAtras.Enabled = true;

            int tamGrid = dgvEmpleados.Rows.Count;
            int indice = 0;
            if (tamGrid == 100)
            {
                indice = int.Parse(dgvEmpleados.Rows[99].Cells[0].Value.ToString());
                ListaEmpleados("", indice, "T", "", "", "");
            }
            else if (tamGrid < 100)
                toolAdelante.Enabled = false;
        }

        private void txtNoEmpleado_Click(object sender, EventArgs e)
        {
            txtNoEmpleado.Clear();
        }

        private void txtPaterno_Click(object sender, EventArgs e)
        {
            txtPaterno.Clear();
        }

        private void txtMaterno_Click(object sender, EventArgs e)
        {
            txtMaterno.Clear();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
        }

        private void toolMostrarTodos_Click(object sender, EventArgs e)
        {
            ListaEmpleados("", 0, "T", "", "", "");
        }

        private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                ListaEmpleados(txtNoEmpleado.Text, 0, "T", "", "", "");
            }
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                ListaEmpleados(txtPaterno.Text, 0, "P", txtNombre.Text, txtPaterno.Text, txtMaterno.Text);
            }
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                ListaEmpleados(txtMaterno.Text, 0, "M", txtNombre.Text, txtPaterno.Text, txtMaterno.Text);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                ListaEmpleados(txtNombre.Text, 0, "N", txtNombre.Text, txtPaterno.Text, txtMaterno.Text);
            }
        }

        private void txtNoEmpleado_MouseEnter(object sender, EventArgs e)
        {
            //txtNoEmpleado.ReadOnly = false;
        }

        private void txtNoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            //txtNoEmpleado.ReadOnly = true;
        }

        private void txtNoEmpleado_ReadOnlyChanged(object sender, EventArgs e)
        {
            
            //txtNoEmpleado.Text = "NO. DE EMPLEADO...";
        }

        private void txtPaterno_MouseEnter(object sender, EventArgs e)
        {
            //txtPaterno.ReadOnly = false;
        }

        private void txtPaterno_MouseLeave(object sender, EventArgs e)
        {
            //txtPaterno.ReadOnly = true;
        }

        private void txtPaterno_ReadOnlyChanged(object sender, EventArgs e)
        {
            //txtPaterno.Text = "PATERNO...";
        }

        private void txtMaterno_MouseEnter(object sender, EventArgs e)
        {
            //txtMaterno.ReadOnly = false;
        }

        private void txtMaterno_MouseLeave(object sender, EventArgs e)
        {
            //txtMaterno.ReadOnly = true;
        }

        private void txtMaterno_ReadOnlyChanged(object sender, EventArgs e)
        {
            //txtMaterno.Text = "MATERNO...";
        }

        private void txtNombre_MouseEnter(object sender, EventArgs e)
        {
            //txtNombre.ReadOnly = false;
        }

        private void txtNombre_MouseLeave(object sender, EventArgs e)
        {
            //txtNombre.ReadOnly = true;
        }

        private void txtNombre_ReadOnlyChanged(object sender, EventArgs e)
        {
            //txtNombre.Text = "NOMBRE(S)...";
        }
    }
}

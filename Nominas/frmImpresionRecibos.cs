using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmImpresionRecibos : Form
    {
        public frmImpresionRecibos()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        private SqlConnection cnx;
        private SqlCommand cmd;
        private string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        string idDepartamentos = "";
        string idEmpleados = "";
        string fecha = "";
        string fechafin = "";
        bool todos = false;
        List<Empleados.Core.Empleados> lstEmp;      
        #endregion

        #region VARIABLES PUBLICAS
        public int _tiponomina;
        public int _periodo;
        #endregion

        private void frmImpresionRecibos_Load(object sender, EventArgs e)
        {
            
            if (_tiponomina == GLOBALES.NORMAL)
                this.Text = "Impresión de recibos - Ordinaria";
            else
                this.Text = "Impresión de recibos - Extraordinaria";

            nudAnio.Value = DateTime.Now.Year;
            nudMes.Value = DateTime.Now.Month;

            lstvPeriodos.View = View.Details;
            lstvPeriodos.CheckBoxes = false;
            lstvPeriodos.GridLines = false;
            lstvPeriodos.Columns.Add("Inicio", 100, HorizontalAlignment.Left);
            lstvPeriodos.Columns.Add("Fin", 100, HorizontalAlignment.Left);

            lstvDepartamentos.View = View.Details;
            lstvDepartamentos.CheckBoxes = true;
            lstvDepartamentos.GridLines = false;
            lstvDepartamentos.Columns.Add("Id", 60, HorizontalAlignment.Left);
            lstvDepartamentos.Columns.Add("Departamento", 150, HorizontalAlignment.Left);

            lstvEmpleados.View = View.Details;
            lstvEmpleados.CheckBoxes = true;
            lstvEmpleados.GridLines = false;
            lstvEmpleados.Columns.Add("", 20, HorizontalAlignment.Left);
            lstvEmpleados.Columns.Add("No. Empleado", 75, HorizontalAlignment.Left);
            lstvEmpleados.Columns.Add("Nombre", 250, HorizontalAlignment.Left);
            
        }

        private void lstvDepartamentos_ItemChecked(object sender, ItemCheckedEventArgs e)
        {   
            idDepartamentos = "";
            for (int i = 0; i < lstvDepartamentos.Items.Count; i++)
            {
                if (lstvDepartamentos.Items[i].Checked)
                {
                    idDepartamentos += lstvDepartamentos.Items[i].Text + ",";
                }
            }

            if (idDepartamentos != "")
            {
                for (int i = 0; i < lstvPeriodos.SelectedItems.Count; i++)
                    fecha = lstvPeriodos.SelectedItems[i].Text;

                if (fecha != "")
                {
                    lstvEmpleados.Items.Clear();
                    cnx = new SqlConnection(cdn);
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;

                    Empleados.Core.EmpleadosHelper eh = new Empleados.Core.EmpleadosHelper();
                    eh.Command = cmd;

                    lstEmp = new List<Empleados.Core.Empleados>();
                    idDepartamentos = idDepartamentos.Substring(0, idDepartamentos.Length - 1);
                    try
                    {
                        cnx.Open();
                        lstEmp = eh.obtenerEmpleadoPorDepto(GLOBALES.IDEMPRESA, idDepartamentos, DateTime.Parse(fecha).Date, _tiponomina, false, _periodo);
                        cnx.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Al obtener el listado de los empleados.", "Error");
                        cnx.Dispose();
                        return;
                    }

                    for (int i = 0; i < lstEmp.Count; i++)
                    {
                        ListViewItem Lista;
                        Lista = lstvEmpleados.Items.Add(lstEmp[i].idtrabajador.ToString());
                        Lista.SubItems.Add(lstEmp[i].noempleado);
                        Lista.SubItems.Add(lstEmp[i].nombrecompleto);
                    }
                }
                else
                    lstvEmpleados.Items.Clear();
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Font = new Font("Arial", 9);
            txtBuscar.ForeColor = System.Drawing.Color.Black;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lstvEmpleados.Items.Clear();
                if (string.IsNullOrEmpty(txtBuscar.Text) || string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    for (int i = 0; i < lstEmp.Count; i++)
                    {
                        ListViewItem Lista;
                        Lista = lstvEmpleados.Items.Add(lstEmp[i].idtrabajador.ToString());
                        Lista.SubItems.Add(lstEmp[i].noempleado);
                        Lista.SubItems.Add(lstEmp[i].nombrecompleto);
                    }
                }
                else
                {
                    var busqueda = from b in lstEmp
                                   where b.noempleado.Contains(txtBuscar.Text.ToUpper())
                                   select new
                                   {
                                       b.idtrabajador,
                                       b.noempleado,
                                       b.nombrecompleto
                                   };
                    foreach (var emp in busqueda)
                    {
                        ListViewItem Lista;
                        Lista = lstvEmpleados.Items.Add(emp.idtrabajador.ToString());
                        Lista.SubItems.Add(emp.noempleado);
                        Lista.SubItems.Add(emp.nombrecompleto);
                    }
                }
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "No. de empleado";
            txtBuscar.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Italic);
            txtBuscar.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnTodosDeptos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvDepartamentos.Items.Count; i++)
                lstvDepartamentos.Items[i].Checked = true;
        }

        private void btnLimpiarDeptos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvDepartamentos.Items.Count; i++)
                lstvDepartamentos.Items[i].Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstvPeriodos.SelectedItems.Count; i++)
            {
                fecha = lstvPeriodos.SelectedItems[i].Text;
                fechafin = lstvPeriodos.SelectedItems[i].SubItems[1].Text;
            }

            for (int i = 0; i < lstvEmpleados.Items.Count; i++)
            {
                if (todos)
                {
                    GLOBALES.GENERA_QR(GLOBALES.IDEMPRESA, _tiponomina, int.Parse(lstvEmpleados.Items[i].Text),
                            DateTime.Parse(fecha).Date, DateTime.Parse(fechafin).Date);
                    GLOBALES.GENERA_CFDI(GLOBALES.IDEMPRESA, _tiponomina, int.Parse(lstvEmpleados.Items[i].Text),
                        DateTime.Parse(fecha).Date, DateTime.Parse(fechafin).Date, _periodo);
                }
                else {
                    if (lstvEmpleados.Items[i].Checked)
                    {
                        GLOBALES.GENERA_QR(GLOBALES.IDEMPRESA, _tiponomina, int.Parse(lstvEmpleados.Items[i].Text),
                            DateTime.Parse(fecha).Date, DateTime.Parse(fechafin).Date);
                        GLOBALES.GENERA_CFDI(GLOBALES.IDEMPRESA, _tiponomina, int.Parse(lstvEmpleados.Items[i].Text),
                            DateTime.Parse(fecha).Date, DateTime.Parse(fechafin).Date, _periodo);

                    }
                }
            }

            if (todos)
            {
                idEmpleados = "";
                frmVisorReportes vr = new frmVisorReportes();
                vr._tipoNomina = _tiponomina;
                vr._departamentos = idDepartamentos;
                vr._empleados = idEmpleados;
                vr._todos = todos;
                vr._noReporte = 10;
                vr._inicioPeriodo = DateTime.Parse(fecha).Date;
                vr._finPeriodo = DateTime.Parse(fechafin).Date;
                vr._periodo = _periodo;
                vr.WindowState = FormWindowState.Maximized;
                vr.Show();
            }
            else
            {
                idEmpleados = "";
                for (int i = 0; i < lstvEmpleados.Items.Count; i++)
                {
                    if (lstvEmpleados.Items[i].Checked)
                        idEmpleados += lstvEmpleados.Items[i].Text + ",";
                }

                if (idEmpleados != "")
                {
                    idEmpleados = idEmpleados.Substring(0, idEmpleados.Length - 1);
                    frmVisorReportes vr = new frmVisorReportes();
                    vr._tipoNomina = _tiponomina;
                    vr._departamentos = idDepartamentos;
                    vr._empleados = idEmpleados;
                    vr._todos = todos;
                    vr._noReporte = 10;
                    vr._periodo = _periodo;
                    vr._inicioPeriodo = DateTime.Parse(fecha).Date;
                    vr._finPeriodo = DateTime.Parse(fechafin).Date;
                    vr.Show();
                }
            }
        }

        private void lstvPeriodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvPeriodos.SelectedItems.Count; i++)
            {
                fecha = lstvPeriodos.SelectedItems[i].Text;
                fechafin = lstvPeriodos.SelectedItems[i].SubItems[1].Text;
            }

            lstvDepartamentos.Items.Clear();
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Departamento.Core.DeptoHelper dh = new Departamento.Core.DeptoHelper();
            dh.Command = cmd;

            List<Departamento.Core.Depto> lstDeptos = new List<Departamento.Core.Depto>();

            try
            {
                cnx.Open();
                lstDeptos = dh.obtenerDepartamentos(GLOBALES.IDEMPRESA, DateTime.Parse(fecha), _tiponomina, false);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Al obtener los departamentos de la empresa.", "Error");
                cnx.Dispose();
                return;
            }

            for (int i = 0; i < lstDeptos.Count; i++)
            {
                ListViewItem Lista;
                Lista = lstvDepartamentos.Items.Add(lstDeptos[i].id.ToString());
                Lista.SubItems.Add(lstDeptos[i].descripcion.ToString());
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                for (int i = 0; i < lstvEmpleados.Items.Count; i++)
                    lstvEmpleados.Items[i].Checked = true;
            }
            else
            {
                for (int i = 0; i < lstvEmpleados.Items.Count; i++)
                    lstvEmpleados.Items[i].Checked = false;
            }
        }

        private void chkImprimirTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImprimirTodos.Checked)
            {
                lstvDepartamentos.Enabled = false;
                lstvEmpleados.Enabled = false;
                todos = true;
            }
            else
            {
                lstvDepartamentos.Enabled = true;
                lstvEmpleados.Enabled = true;
                todos = false;
            }
        }

        private void btnPeriodos_Click(object sender, EventArgs e)
        {
            lstvPeriodos.Items.Clear();

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            CalculoNomina.Core.NominaHelper nh = new CalculoNomina.Core.NominaHelper();
            nh.Command = cmd;

            List<CalculoNomina.Core.PagoNomina> lstPeriodos = new List<CalculoNomina.Core.PagoNomina>();

            try
            {
                cnx.Open();
                lstPeriodos = nh.obtenerPeriodosNomina(GLOBALES.IDEMPRESA, int.Parse(nudAnio.Value.ToString()), int.Parse(nudMes.Value.ToString()), _tiponomina, _periodo);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Al obtener los periodos de la empresa.", "Error");
                cnx.Dispose();
                return;
            }

            for (int i = 0; i < lstPeriodos.Count; i++)
            {
                ListViewItem Lista;
                Lista = lstvPeriodos.Items.Add(lstPeriodos[i].fechainicio.ToShortDateString());
                Lista.SubItems.Add(lstPeriodos[i].fechafin.ToShortDateString());
            }
        }

    }
}

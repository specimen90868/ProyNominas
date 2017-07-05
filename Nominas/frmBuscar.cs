using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        #region DELEGADOS
        public delegate void delOnBuscar(int id, string nombre);
        public event delOnBuscar OnBuscar;
        #endregion

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        Empleados.Core.EmpleadosHelper eh;
        List<Empleados.Core.Empleados> lstEmpleados;
        #endregion

        #region VARIABLES PUBLICAS
        public int _catalogo;
        public int _tipoNomina;
        public bool _obracivil;
        public int _periodo;
        public int _busqueda;
        #endregion

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            dgvCatalogo.RowHeadersVisible = false;
            txtBuscar.Select();
        }

        private void toolCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.Font = new Font("Arial", 9);
            txtBuscar.ForeColor = System.Drawing.Color.Black;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar empleado...";
            txtBuscar.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            txtBuscar.ForeColor = System.Drawing.Color.Gray;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnx = new SqlConnection();
            cmd = new SqlCommand();
            cnx.ConnectionString = cdn;
            cmd.Connection = cnx;
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                eh = new Empleados.Core.EmpleadosHelper();
                eh.Command = cmd;

                Empleados.Core.Empleados em = new Empleados.Core.Empleados();
                em.idempresa = GLOBALES.IDEMPRESA;
                em.noempleado = txtBuscar.Text.Trim();

                if (_tipoNomina == GLOBALES.NORMAL)
                    em.estatus = GLOBALES.ACTIVO;

                try
                {
                    cnx.Open();
                    if(_busqueda == GLOBALES.NOMINA)
                        lstEmpleados = eh.buscarEmpleado(em, _periodo);
                    if (_busqueda == GLOBALES.FORMULARIOS)
                        lstEmpleados = eh.buscarEmpleado(em);
                    cnx.Close();
                    cnx.Dispose();

                    dgvCatalogo.DataSource = null;
                    var empleados = from t in lstEmpleados select new { t.idtrabajador, t.noempleado, t.nombrecompleto };
                    dgvCatalogo.DataSource = empleados.ToList();
                    dgvCatalogo.Columns[0].Visible = false;
                    dgvCatalogo.Columns[1].HeaderText = "No. Empleado";
                    dgvCatalogo.Columns[2].HeaderText = "Empleado";

                    for (int i = 0; i < dgvCatalogo.Columns.Count; i++)
                    {
                        dgvCatalogo.AutoResizeColumn(i);
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                }
            }
        }

        private void toolAceptar_Click(object sender, EventArgs e)
        {
            Seleccion();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccion();
        }

        private void Seleccion()
        {
            if (OnBuscar != null)
            {
                try
                {
                    int fila = dgvCatalogo.CurrentCell.RowIndex;
                    OnBuscar(int.Parse(dgvCatalogo.Rows[fila].Cells[0].Value.ToString()), dgvCatalogo.Rows[fila].Cells[2].Value.ToString());
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Por favor selecciona el registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void frmBuscar_Shown(object sender, EventArgs e)
        {
            txtBuscar_Click(sender, e);
            txtBuscar.Focus();
        }
    }
}

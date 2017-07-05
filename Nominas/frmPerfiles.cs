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
    public partial class frmPerfiles : Form
    {
        public frmPerfiles()
        {
            InitializeComponent();
        }

        #region VARIABLES PUBLICAS
        public int _tipoOperacion;
        public int _idperfil;
        #endregion

        #region VARIABLES GLOBALES
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        SqlConnection cnx;
        SqlCommand cmd;
        Perfil.Core.PerfilesHelper ph;
        Autorizaciones.Core.AutorizacionHelper auth;
        #endregion

        #region DELEGADOS
        public delegate void delOnNuevoPerfil(int edicion);
        public event delOnNuevoPerfil OnNuevoPerfil;
        #endregion

        
        private void toolGuardarNuevo_Click(object sender, EventArgs e)
        {
            Guardar(0);
        }

        private void Guardar(int tipoGuardar)
        {
            if (txtNombre.Text.Equals("") || txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Información: \r\n" + "El nombre del perfil no puede ir vacío.", "Información", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                return; 
            }

            int idperfil;

            cnx = new SqlConnection();
            cnx.ConnectionString = cdn;
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            ph = new Perfil.Core.PerfilesHelper();
            ph.Command = cmd;

            auth = new Autorizaciones.Core.AutorizacionHelper();
            auth.Command = cmd;

            ///ASIGNACION DEL NOMBRE DEL PERFIL A LA CLASE PERFILES
            Perfil.Core.Perfiles p = new Perfil.Core.Perfiles();
            p.nombre = txtNombre.Text;

            Autorizaciones.Core.PermisosOperaciones permisos = new Autorizaciones.Core.PermisosOperaciones();

            ///ASIGNACION DE LOS CHECKBOXES A LA CLASE AUTORIZACION
            List<Autorizaciones.Core.Autorizacion> lstAutorizacion = new List<Autorizaciones.Core.Autorizacion>();
            
            var controls = this.Controls.Cast<Control>();
            foreach (Control c in controls.Where(c => c.GetType() == typeof(CheckBox)))
            {
                Autorizaciones.Core.Autorizacion a = new Autorizaciones.Core.Autorizacion();
                switch ((c as CheckBox).Text)
                {
                    case "Recursos Humanos":
                        a.idacceso = 1;
                        a.acceso = chkRecursosHumanos.Checked;
                        break;
                    case "Seguro Social":
                        a.idacceso = 2;
                        a.acceso = chkSeguroSocial.Checked;
                        break;
                    case "Nominas":
                        a.idacceso = 3;
                        a.acceso = chkNominas.Checked;
                        break;
                    case "Catálogos":
                        a.idacceso = 4;
                        a.acceso = chkCatalogos.Checked;
                        break;
                    case "Configuración":
                        a.idacceso = 5;
                        a.acceso = chkConfiguracion.Checked;
                        break;
                }
                lstAutorizacion.Add(a);
            }

            switch (_tipoOperacion)
            {
                case 0:
                    try
                    {
                        cnx.Open();
                        ph.insertaPerfil(p);
                        idperfil = (int)ph.obtenerIdPerfil(p);
                        auth.insertaAutorizacion(idperfil, lstAutorizacion);
                        permisos.idperfil = idperfil;
                        auth.insertarPermiso(permisos);
                        cnx.Close();
                        cnx.Dispose();

                        if (OnNuevoPerfil != null)
                            OnNuevoPerfil(0);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                    }
                    break;
                case 2:
                    try
                    {
                        cnx.Open();
                        p.idperfil = _idperfil;
                        ph.actualizaPerfil(p);
                        auth.actualizaAutorizacion(_idperfil, lstAutorizacion);
                        cnx.Close();
                        cnx.Dispose();

                        if (OnNuevoPerfil != null)
                            OnNuevoPerfil(2);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                    }
                    break;
            }

            switch (tipoGuardar)
            {
                case 0:
                    limpiar(this, typeof(TextBox));
                    break;
                case 1:
                    this.Dispose();
                    break;
            }
        }

        #region FUNCION LIMPIAR TEXTBOX E INHABILITAR CONTROLES
        private void limpiar(Control control, Type tipo)
        {
            var controls = control.Controls.Cast<Control>();
            foreach (Control c in controls.Where(c => c.GetType() == tipo))
            {
                (c as TextBox).Clear();
            }
        }

        private void inhabilitar(Control control, Type tipo)
        {
            var controls = control.Controls.Cast<Control>();
            foreach (Control c in controls.Where(c => c.GetType() == tipo))
            {
                (c as TextBox).Enabled = false;
            }
            
            toolGuardarNuevo.Enabled = false;
        }
        #endregion

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            if (_tipoOperacion == GLOBALES.CONSULTAR || _tipoOperacion == GLOBALES.MODIFICAR)
            {
                cnx = new SqlConnection();
                cnx.ConnectionString = cdn;
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                ph = new Perfil.Core.PerfilesHelper();
                ph.Command = cmd;

                Perfil.Core.Perfiles p = new Perfil.Core.Perfiles();
                p.idperfil = _idperfil;
                List<Perfil.Core.Perfiles> lstPerfil;

                Autorizaciones.Core.AutorizacionHelper ah = new Autorizaciones.Core.AutorizacionHelper();
                ah.Command = cmd;

                List<Autorizaciones.Core.Autorizacion> lstAuth = new List<Autorizaciones.Core.Autorizacion>();
                List<Autorizaciones.Core.Permisos> lstPermisos = new List<Autorizaciones.Core.Permisos>();

                try
                {
                    cnx.Open();
                    lstPerfil = ph.obtenerPerfile(p);
                    lstAuth = ah.obtenerModulos(_idperfil);
                    lstPermisos = ah.obtenerPermisos(_idperfil);
                    cnx.Close();
                    cnx.Dispose();

                    for (int i = 0; i < lstPerfil.Count; i++)
                    {
                        txtNombre.Text = lstPerfil[i].nombre;
                    }

                    for (int i = 0; i < lstAuth.Count; i++)
                    {
                        switch (lstAuth[i].idacceso)
                        {
                            case 1:
                                chkRecursosHumanos.Checked = lstAuth[i].acceso;
                                break; 
                            case 2:
                                chkSeguroSocial.Checked = lstAuth[i].acceso;
                                break;
                            case 3:
                                chkNominas.Checked = lstAuth[i].acceso;
                                break;
                            case 4:
                                chkCatalogos.Checked = lstAuth[i].acceso;
                                break;
                            case 5:
                                chkConfiguracion.Checked = lstAuth[i].acceso;
                                break;
                        } 
                    }

                    DataTable dt = new DataTable();
                    DataRow dtFila;
                    dt.Columns.Add("id", typeof(Int32));
                    dt.Columns.Add("idperfil", typeof(Int32));
                    dt.Columns.Add("nombre", typeof(String));
                    dt.Columns.Add("permiso", typeof(String));
                    dt.Columns.Add("accion", typeof(Boolean));

                    for (int i = 0; i < lstPermisos.Count; i++)
                    {
                        dtFila = dt.NewRow();
                        dtFila["id"] = lstPermisos[i].id;
                        dtFila["idperfil"] = lstPermisos[i].idperfil;
                        dtFila["nombre"] = lstPermisos[i].nombre;
                        dtFila["permiso"] = lstPermisos[i].permiso;
                        dtFila["accion"] = lstPermisos[i].accion;
                        dt.Rows.Add(dtFila);
                    }

                    dgvPermisos.Columns["id"].DataPropertyName = "id";
                    dgvPermisos.Columns["idperfil"].DataPropertyName = "idperfil";
                    dgvPermisos.Columns["nombre"].DataPropertyName = "nombre";
                    dgvPermisos.Columns["permiso"].DataPropertyName = "permiso";
                    dgvPermisos.Columns["accion"].DataPropertyName = "accion";

                    dgvPermisos.DataSource = dt;
                    for (int i = 0; i < dgvPermisos.Columns.Count; i++)
                        dgvPermisos.AutoResizeColumn(i);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
                }

                if (_tipoOperacion == GLOBALES.CONSULTAR)
                {
                    
                    GLOBALES.INHABILITAR(this, typeof(TextBox));
                    GLOBALES.INHABILITAR(this, typeof(ComboBox));
                    GLOBALES.INHABILITAR(this, typeof(CheckBox));                  
                    toolGuardarNuevo.Enabled = false;
                    dgvPermisos.Enabled = false;
                }
                
            }
        }

        private void toolCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            Autorizaciones.Core.AutorizacionHelper ah = new Autorizaciones.Core.AutorizacionHelper();
            ah.Command = cmd;

            Autorizaciones.Core.PermisosOperaciones p = new Autorizaciones.Core.PermisosOperaciones();
            p.id = int.Parse(dgvPermisos.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == 4) // 0 is the first column, specify the valid index of ur gridview
            {
                bool value = (bool)dgvPermisos.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                p.accion = value;
            }

            try
            {
                cnx.Open();
                ah.actualizaPermiso(p);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Al actualizar la asignación del concepto", "Error");
                cnx.Dispose();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nominas
{
    public partial class frmListaFactorDescuento : Form
    {
        public frmListaFactorDescuento()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        List<FactorDescuento.Core.FactorDescuento> lstFactores;
        #endregion

        private void ListaFactores()
        {
            string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;
            FactorDescuento.Core.FactorDescuentoHelper fd = new FactorDescuento.Core.FactorDescuentoHelper();
            fd.Command = cmd;

            try
            {
                cnx.Open();
                lstFactores = fd.obtenerFactores();
                cnx.Close();
                cnx.Dispose();

                var factor = from f in lstFactores
                             select new
                             {
                                 Id = f.idfactor,
                                 Factor = f.factor,
                                 Fecha = f.fecha
                             };
                dgvFactores.DataSource = factor.ToList();

                for (int i = 0; i < dgvFactores.Columns.Count; i++)
                {
                    dgvFactores.AutoResizeColumn(i);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: \r\n \r\n " + error.Message, "Error");
            }
        }

        private void frmListaFactorDescuento_Load(object sender, EventArgs e)
        {
            dgvFactores.RowHeadersVisible = false;
            ListaFactores();
            CargaPerfil();
        }

        private void CargaPerfil()
        {
            List<Autorizaciones.Core.Ediciones> lstEdiciones = GLOBALES.PERFILEDICIONES("Factor de descuento");

            for (int i = 0; i < lstEdiciones.Count; i++)
            {
                switch (lstEdiciones[i].permiso.ToString())
                {
                    case "Crear":
                        toolNuevo.Enabled = Convert.ToBoolean(lstEdiciones[i].accion);
                        break;
                    case "Consultar": toolConsultar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Editar": toolEditar.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                    case "Eliminar": toolBaja.Enabled = Convert.ToBoolean(lstEdiciones[i].accion); break;
                }
            }
        }

        private void Seleccion(int edicion)
        {
            frmFactorDescuento fd = new frmFactorDescuento();
            fd.StartPosition = FormStartPosition.CenterScreen;
            fd.OnNuevoFactorDescuento += fd_OnNuevoFactorDescuento;
            int fila = 0;
            if (!edicion.Equals(GLOBALES.NUEVO))
            {
                if (dgvFactores.Rows.Count != 0)
                {
                    fila = dgvFactores.CurrentCell.RowIndex;
                    fd._idfactor = int.Parse(dgvFactores.Rows[fila].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("No hay registros que operar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            fd._tipoOperacion = edicion;
            fd.Show();
        }

        void fd_OnNuevoFactorDescuento(int edicion)
        {
            if (edicion == GLOBALES.NUEVO || edicion == GLOBALES.MODIFICAR)
                ListaFactores();
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
            if (dgvFactores.Rows.Count != 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Quiere eliminar el factor?", "Confirmación", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
                    int fila = dgvFactores.CurrentCell.RowIndex;
                    int id = int.Parse(dgvFactores.Rows[fila].Cells[0].Value.ToString());
                    cnx = new SqlConnection(cdn);
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    FactorDescuento.Core.FactorDescuentoHelper fdh = new FactorDescuento.Core.FactorDescuentoHelper();
                    fdh.Command = cmd;
                    FactorDescuento.Core.FactorDescuento factor = new FactorDescuento.Core.FactorDescuento();
                    factor.idfactor = id;

                    try
                    {
                        cnx.Open();
                        fdh.borrarFactor(factor);
                        cnx.Close();
                        cnx.Dispose();
                        ListaFactores();
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
    }
}

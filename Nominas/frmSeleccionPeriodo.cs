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
    public partial class frmSeleccionPeriodo : Form
    {
        public frmSeleccionPeriodo()
        {
            InitializeComponent();
        }

        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        Periodos.Core.PeriodosHelper ph;
        int periodoSeleccionado;
        List<Periodos.Core.Periodos> lstPeriodos;
        #endregion

        #region VARIABLES PUBLICAS
        public int _TipoNomina;
        public int _Ventana;
        #endregion

        private void frmSeleccionPeriodo_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            ph = new Periodos.Core.PeriodosHelper();
            ph.Command = cmd;

            Periodos.Core.Periodos periodo = new Periodos.Core.Periodos();
            periodo.idempresa = GLOBALES.IDEMPRESA;

            lstPeriodos = new List<Periodos.Core.Periodos>();
            try
            {
                cnx.Open();
                lstPeriodos = ph.obtenerPeriodos(periodo);
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: \r\n \r\n" + error.Message, "Error");
            }

            cmbPeriodo.DataSource = lstPeriodos;
            cmbPeriodo.DisplayMember = "pago";
            cmbPeriodo.ValueMember = "idperiodo";

            if (GLOBALES.OBRACIVIL)
                chkObraCivil.Visible = true;
            else
                chkObraCivil.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_Ventana == 0)
            {
                if (GLOBALES.FORMISOPEN("frmListaCalculoNomina"))
                    return;
                frmListaCalculoNomina lcn = new frmListaCalculoNomina();
                lcn.MdiParent = this.MdiParent;
                lcn._tipoNomina = _TipoNomina;
                lcn._periodo = periodoSeleccionado;
                lcn.WindowState = FormWindowState.Maximized;
                if (chkObraCivil.Checked)
                    lcn._obracivil = true;
                else
                    lcn._obracivil = false;
                lcn.Show();
                this.Dispose();
            }
            else if(_Ventana == 1)
            {
                if (GLOBALES.FORMISOPEN("frmImpresionRecibos"))
                    return;
                frmImpresionRecibos ir = new frmImpresionRecibos();
                ir._tiponomina = _TipoNomina;
                ir._periodo = periodoSeleccionado;
                ir.StartPosition = FormStartPosition.CenterScreen;
                ir.Show();
                this.Dispose();
            }
            else if(_Ventana == 2)
            {
                if (GLOBALES.FORMISOPEN("frmEnvioRecibos"))
                    return;
                frmEnvioRecibos er = new frmEnvioRecibos();
                er._tiponomina = _TipoNomina;
                er._periodo = periodoSeleccionado;
                er.StartPosition = FormStartPosition.CenterScreen;
                er.Show();
                this.Dispose();
            }
            else if (_Ventana == 3)
            {
                if (GLOBALES.FORMISOPEN("frmReportes"))
                    return;
                frmReportes r = new frmReportes();
                r._tipoNomina = _TipoNomina;
                r._periodo = periodoSeleccionado;
                r.StartPosition = FormStartPosition.CenterScreen;
                r.Show();
                this.Dispose();
            }
            else if (_Ventana == 4)
            {
                if (GLOBALES.FORMISOPEN("frmVisorReciboNomina"))
                    return;
                frmVisorReciboNomina vrn = new frmVisorReciboNomina();
                vrn._periodo = periodoSeleccionado;
                vrn.StartPosition = FormStartPosition.CenterScreen;
                vrn.Show();
                this.Dispose();
            }
            else if (_Ventana == 5)
            {
                if (GLOBALES.FORMISOPEN("frmCancelacionRecibosNomina"))
                    return;
                frmCancelacionRecibosNomina crn = new frmCancelacionRecibosNomina();
                crn._periodo = periodoSeleccionado;
                crn.StartPosition = FormStartPosition.CenterScreen;
                crn.Show();
                this.Dispose();
            }
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPeriodo.Text)
            {
                case "SEMANAL": periodoSeleccionado = 7; break;
                case "QUINCENAL": periodoSeleccionado = 15; break;
            }
        }
    }
}

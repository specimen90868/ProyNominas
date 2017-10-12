using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Nominas
{
    public partial class frmListaBitacora : Form
    {
        
        #region VARIABLES GLOBALES
        SqlConnection cnx;
        SqlCommand cmd;
        string cdn = ConfigurationManager.ConnectionStrings["cdnNomina"].ConnectionString;
        Bitacora.Core.BitacoraHelper bh;
        #endregion

        public frmListaBitacora()
        {
            InitializeComponent();
        }

        private void frmListaBitacora_Load(object sender, EventArgs e)
        {
            ListaBitacora("", 0);
        }

        void ListaBitacora(string criterio, int indice) {

            cnx = new SqlConnection(cdn);
            cmd = new SqlCommand();
            cmd.Connection = cnx;

            bh = new Bitacora.Core.BitacoraHelper();
            bh.Command = cmd;

            List<Bitacora.Core.Bitacora> lstBitacora = new List<Bitacora.Core.Bitacora>();

            cnx.Open();
            lstBitacora = bh.obtenerBitacoraPaged(indice, criterio, GLOBALES.IDEMPRESA);
            cnx.Close();

            dgvBitacora.DataSource = lstBitacora.ToList();
            for (int i = 0; i < dgvBitacora.Columns.Count; i++)
            {
                dgvBitacora.AutoResizeColumn(i);
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
            {
                ListaBitacora(txtBuscar.Text.Trim(), 0);
            }
        }

        private void toolBuscar_Click(object sender, EventArgs e)
        {
            ListaBitacora(txtBuscar.Text.Trim(), 0);
        }

        private void toolAtras_Click(object sender, EventArgs e)
        {
            if (!toolAdelante.Enabled)
                toolAdelante.Enabled = true;

            int indice = int.Parse(dgvBitacora.Rows[0].Cells[0].Value.ToString());
            if (indice != 1)
            {
                ListaBitacora("", (indice - 101));
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

            int tamGrid = dgvBitacora.Rows.Count;
            int indice = 0;
            if (tamGrid == 100)
            {
                indice = int.Parse(dgvBitacora.Rows[99].Cells[0].Value.ToString());
                ListaBitacora("", indice);
            }
            else if (tamGrid < 100)
                toolAdelante.Enabled = false;
        }
    }
}

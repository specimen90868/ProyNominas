using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora.Core
{
    public class BitacoraHelper : Data.Obj.DataObj
    {
        public List<Bitacora> obtenerBitacoraPaged(int indice, string criterio, int idempresa)
        {
            DataTable dt = new DataTable();
            List<Bitacora> lstBitacora = new List<Bitacora>();
            Command.CommandText = "exec stp_Bitacora_GetPaged @indice, @criterio, @idempresa";
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("indice", indice);
            Command.Parameters.AddWithValue("criterio", criterio);
            Command.Parameters.AddWithValue("idempresa", idempresa);
            dt = SelectData(Command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Bitacora b = new Bitacora();
                b.rownuber = int.Parse(dt.Rows[i]["BitacoraRowNumber"].ToString());
                b.idusuario = int.Parse(dt.Rows[i]["idusuario"].ToString());
                b.usuario = dt.Rows[i]["usuario"].ToString();
                b.idtrabajador = int.Parse(dt.Rows[i]["idtrabajador"].ToString());
                b.idempresa = int.Parse(dt.Rows[i]["idempresa"].ToString());
                b.noempleado = dt.Rows[i]["noempleado"].ToString();
                b.nombre = dt.Rows[i]["nombre"].ToString();
                b.fecha = DateTime.Parse(dt.Rows[i]["fecha"].ToString());
                b.tabla = dt.Rows[i]["tabla"].ToString();
                b.accion = dt.Rows[i]["accion"].ToString();
                b.informacion = dt.Rows[i]["informacion"].ToString();

                lstBitacora.Add(b);
            }
            return lstBitacora;

        }
    }
}

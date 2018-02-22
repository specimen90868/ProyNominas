using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosNominales.Core
{
    public class PeriodosNominalesHelper : Data.Obj.DataObj
    {
        public List<PeriodosNominales> obtenerUltimaNomina(int idempresa, int tiponomina)
        {
            Command.CommandText = @"select fechainicio, fechafin from PeriodosNominales where 
            id = (select top 1 idperiodonom from PagoNomina where idempresa = @idempresa and tiponomina = @tiponomina order by idperiodonom desc)";
            Command.Parameters.Clear();
            Command.Parameters.Add("idempresa", idempresa);
            Command.Parameters.Add("tiponomina", tiponomina);
            DataTable dt = new DataTable();
            dt = SelectData(Command);
            List<PeriodosNominales> lstPeriodos = new List<PeriodosNominales>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PeriodosNominales pn = new PeriodosNominales();
                pn.id = int.Parse(dt.Rows[i]["id"].ToString());
                pn.idempresa = int.Parse(dt.Rows[i]["idempresa"].ToString());
                pn.anio = int.Parse(dt.Rows[i]["anio"].ToString());
                pn.noperiodo = int.Parse(dt.Rows[i]["noperiodo"].ToString());
                pn.fechainicio = DateTime.Parse(dt.Rows[i]["fechainicio"].ToString());
                pn.fechafin = DateTime.Parse(dt.Rows[i]["fechafin"].ToString());
                pn.periodo = int.Parse(dt.Rows[i]["periodo"].ToString());
                pn.tiponomina = int.Parse(dt.Rows[i]["tiponomina"].ToString());
                lstPeriodos.Add(pn);
            }
            return lstPeriodos;
        }
    }
}

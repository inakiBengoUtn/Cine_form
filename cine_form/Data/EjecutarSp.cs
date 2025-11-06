using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cine_form.Data
{
    internal class EjecutarSp
    {

        public DataTable Ejecutar(string sp)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(sp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataSet EjecutarVarios(string sp)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(Properties.Resources.CadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(sp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }

            return ds;
        }
    }
}

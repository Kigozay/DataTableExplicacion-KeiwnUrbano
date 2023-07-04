using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace DataTableExplicacion.Datos
{
    public class ClConexion
    {
        SqlConnection conexion = null;
        public SqlConnection mtdConexion()
        {
            //conexion = new SqlConnection("Data Source=SOGAPRRBCFSD548;Initial Catalog=DataTableExplicacion;Integrated Security=True");
            conexion = new SqlConnection("Data Source=DESKTOP-B93347B\\SQLEXPRESS;Initial Catalog=DataTableExplicacion;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace DataTableExplicacion.Datos
{
    public class ClProcesarSQL
    {
        //Ejecuta Consulta Select en forma desconectada y retorna DataTable
        public DataTable mtdSelectDesc(string Consulta)
        {

            ClConexion objConexion = new ClConexion();
            SqlDataAdapter adaptador = new SqlDataAdapter(Consulta, objConexion.mtdConexion());
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.mtdConexion().Close();
            return tblDatos;
        }

        //Ejecuta Consulta Select en forma conectada y retorna un dataReader
        public int mtdSelecConect(string Consulta)
        {
            ClConexion objConexion = new ClConexion();
            SqlCommand comando = new SqlCommand(Consulta, objConexion.mtdConexion());
            int cont = (int)comando.ExecuteScalar();
            objConexion.mtdConexion().Close();
            return cont;

        }

        //Ejecuta SQL Insert,Update,Delete en forma conectada y retorna entero

        public SqlCommand mtdIUDConect(string ProcesoAlmacenado)
        {
            ClConexion objConexion = new ClConexion();
            SqlCommand comando = new SqlCommand(ProcesoAlmacenado, objConexion.mtdConexion());
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }
    }
}
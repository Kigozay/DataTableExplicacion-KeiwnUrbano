using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DataTableExplicacion.Entidades;

namespace DataTableExplicacion.Datos
{
    public class ClDataTableD
    {
        public List<ClDataTableE> mtdListTable()
        {

            string Consulta = "SELECT * FROM Personal";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblListarPersonal = objSQL.mtdSelectDesc(Consulta);
            List<ClDataTableE> ListarPersonal = new List<ClDataTableE>();
            for (int i = 0; i < tblListarPersonal.Rows.Count; i++)
            {
                ClDataTableE objPersonalE = new ClDataTableE();
                objPersonalE.IdPersonal = int.Parse(tblListarPersonal.Rows[i]["IdPersonal"].ToString());
                objPersonalE.Documento = tblListarPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblListarPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblListarPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Ciudad = tblListarPersonal.Rows[i]["Ciudad"].ToString();
                objPersonalE.Telefono = tblListarPersonal.Rows[i]["Telefono"].ToString();

                ListarPersonal.Add(objPersonalE);


            }
            return ListarPersonal;
        }

        public List<ClDataTableE> mtdTablaFoto()
        {

            string Consulta = "SELECT Foto, Documento, Nombre, Apellido, Ciudad, Telefono FROM Personal";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblListarPersonal = objSQL.mtdSelectDesc(Consulta);
            List<ClDataTableE> ListarPersonal = new List<ClDataTableE>();
            for (int i = 0; i < tblListarPersonal.Rows.Count; i++)
            {
                ClDataTableE objPersonalE = new ClDataTableE();
                objPersonalE.Foto = tblListarPersonal.Rows[i]["Foto"].ToString();
                objPersonalE.Documento = tblListarPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblListarPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblListarPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Ciudad = tblListarPersonal.Rows[i]["Ciudad"].ToString();
                objPersonalE.Telefono = tblListarPersonal.Rows[i]["Telefono"].ToString();

                ListarPersonal.Add(objPersonalE);


            }
            return ListarPersonal;
        }

        public List<ClDataTableE> mtdObtenerPersonalPorId(int IdPersonal)
        {

            string Consulta = "SELECT * FROM Personal WHERE IdPersonal = " + IdPersonal;

            ClProcesarSQL objSQL = new ClProcesarSQL();
            DataTable tblListarPersonal = objSQL.mtdSelectDesc(Consulta);
            List<ClDataTableE> ListarPersonal = new List<ClDataTableE>();
            for (int i = 0; i < tblListarPersonal.Rows.Count; i++)
            {
                ClDataTableE objPersonalE = new ClDataTableE();

                objPersonalE.Documento = tblListarPersonal.Rows[i]["Documento"].ToString();
                objPersonalE.Nombre = tblListarPersonal.Rows[i]["Nombre"].ToString();
                objPersonalE.Apellido = tblListarPersonal.Rows[i]["Apellido"].ToString();
                objPersonalE.Ciudad = tblListarPersonal.Rows[i]["Ciudad"].ToString();
                objPersonalE.Telefono = tblListarPersonal.Rows[i]["Telefono"].ToString();

                ListarPersonal.Add(objPersonalE);


            }
            return ListarPersonal;

        }

        public int mtdActualizar(ClDataTableE objDatos)
        {
            string ProcesosAlmacenado = "ActualizarPersonal";
            ClProcesarSQL objSQL = new ClProcesarSQL();
            SqlCommand Actualizar = objSQL.mtdIUDConect(ProcesosAlmacenado);

            Actualizar.Parameters.AddWithValue("@Documento", objDatos.Documento);
            Actualizar.Parameters.AddWithValue("@Nombre", objDatos.Nombre);
            Actualizar.Parameters.AddWithValue("@Apellido", objDatos.Apellido);
            Actualizar.Parameters.AddWithValue("@Ciudad", objDatos.Ciudad);
            Actualizar.Parameters.AddWithValue("@Telefono", objDatos.Telefono);
            Actualizar.Parameters.AddWithValue("@IdPersonal", objDatos.IdPersonal);

            int DatosActualizar = Actualizar.ExecuteNonQuery();
            return DatosActualizar;
        }
        public int mtdEliminar(ClDataTableE objDatos)
        {
            string ProcesosAlmacenado = "EliminarRegistro";

            ClProcesarSQL objSQL = new ClProcesarSQL();
            SqlCommand Eliminar = objSQL.mtdIUDConect(ProcesosAlmacenado);

            Eliminar.Parameters.AddWithValue("@IdPersonal", objDatos.IdPersonal);

            int DatosActualizar = Eliminar.ExecuteNonQuery();
            return DatosActualizar;

        }
    }
}
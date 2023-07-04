using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataTableExplicacion.Datos;
using DataTableExplicacion.Entidades;

namespace DataTableExplicacion.Logica
{
    public class ClDataTableL
    {
        public List<ClDataTableE> mtdListar()
        {
            ClDataTableD objPersonalD = new ClDataTableD();
            List<ClDataTableE> listarPersonal = objPersonalD.mtdListTable();
            return listarPersonal;
        }

        public List<ClDataTableE> mtdTablaFoto()
        {
            ClDataTableD objPersonalD = new ClDataTableD();
            List<ClDataTableE> listarPersonal = objPersonalD.mtdTablaFoto();
            return listarPersonal;
        }
        public List<ClDataTableE> mtdIdPersonal(int IdPersonal)
        {
            ClDataTableD objPersonalD = new ClDataTableD();
            List<ClDataTableE> listaTable = objPersonalD.mtdObtenerPersonalPorId(IdPersonal);
            return listaTable;
        }

        public int mtdActualizacion(ClDataTableE objDatos)
        {
            ClDataTableD objPersonalD = new ClDataTableD();
            int actu = objPersonalD.mtdActualizar(objDatos);
            return actu;
        }

        public int mtdEliminar(ClDataTableE objDatos)
        {
            ClDataTableD objPersonalD = new ClDataTableD();
            int Eliminar = objPersonalD.mtdEliminar(objDatos);
            return Eliminar;
        }
    }
}
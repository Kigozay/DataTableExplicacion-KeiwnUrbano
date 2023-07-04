using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTableExplicacion.Entidades;
using System.Xml;
using Newtonsoft.Json;
using DataTableExplicacion.Logica;
using System.Web.Services;
using Microsoft.SqlServer.Server;

namespace DataTableExplicacion.Vista
{
    public partial class DataTableVista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClDataTableL objPersonalL = new ClDataTableL();
                List<ClDataTableE> listaPersonal = objPersonalL.mtdListar();
                string Json = JsonConvert.SerializeObject(listaPersonal, Newtonsoft.Json.Formatting.Indented);
                ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData = {Json};", true);

            }


        }


        [WebMethod]
        public static List<ClDataTableE> mtdCargarDatos(int IdPersonal)
        {
            ClDataTableL objPersonalL = new ClDataTableL();
            List<ClDataTableE> Personal = objPersonalL.mtdIdPersonal(IdPersonal);
            if (Personal.Count > 0)
            {
                return Personal;
            }

          return null;
        }


        [WebMethod]
        public static string mtdActualizarPersonal(object data)
        {
            ClDataTableL objPersonalL = new ClDataTableL();
            ClDataTableE objActualizarPersonal = new ClDataTableE();

            var datos = data as IDictionary<string, object>;


            objActualizarPersonal.Documento = datos["Documento"].ToString();
            objActualizarPersonal.Nombre = datos["Nombre"].ToString();
            objActualizarPersonal.Apellido = datos["Apellido"].ToString();
            objActualizarPersonal.Ciudad = datos["Ciudad"].ToString();
            objActualizarPersonal.Telefono = datos["Telefono"].ToString();
            objActualizarPersonal.IdPersonal = int.Parse(datos["IdPersonal"].ToString());

            int resultado = objPersonalL.mtdActualizacion(objActualizarPersonal);

            return "success"; // Devuelve una respuesta al cliente
        }

        [WebMethod]
        public static string mtdEliminar(object formData)
        {
            ClDataTableL objPersonalL = new ClDataTableL();
            ClDataTableE objEliminarPersonal = new ClDataTableE();

            var data = formData as IDictionary<string, object>;

            objEliminarPersonal.IdPersonal = int.Parse(data["IdPersonal"].ToString());

            int resultado = objPersonalL.mtdEliminar(objEliminarPersonal);

            return string.Empty;
        }

        [WebMethod]
        public static List<ClDataTableE> mtdListar()
        {
            ClDataTableL objPersonalL = new ClDataTableL();
            List<ClDataTableE> listaPersonal = objPersonalL.mtdListar();

            return listaPersonal;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTableExplicacion.Entidades;
using DataTableExplicacion.Logica;
using Newtonsoft.Json;

namespace DataTableExplicacion.Vista
{
    public partial class DataTableFoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ClDataTableL objPersonalL = new ClDataTableL();
            List<ClDataTableE> listaPersonal = objPersonalL.mtdTablaFoto();
            string Json = JsonConvert.SerializeObject(listaPersonal, Newtonsoft.Json.Formatting.Indented);
            ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData = {Json};", true);

        }
    }
}
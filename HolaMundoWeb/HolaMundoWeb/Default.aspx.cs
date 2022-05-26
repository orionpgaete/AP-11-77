using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saludarBtn_Click(object sender, EventArgs e)
        {
            //Para los asp components, la propiedad para obtener el valor es Text
            string nombre = this.nombreTxt.Text.Trim();
            //Para los HTML elemnts, la propiedad es InnerText
            this.mensajeH1.InnerText = "Hola " + nombre + " del mundo ASP.net";

        }
    }
}
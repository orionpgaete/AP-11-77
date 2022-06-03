using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidasDAL bebidaDAL = new BebidasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //este Metod se ejecuta cuando se carga el form
            //puede ser:
            // - Cuando es una peticion GET (!Postback)
            // - Cuando es una peticion POST (PostBack)

            if (!IsPostBack)
            {
                //aqui cargo la lista del dropdown
                List<Bebida> bebidas = bebidaDAL.ObtenerBebidas();
                this.bebidaDdl.DataSource = bebidas;
                this.bebidaDdl.DataTextField = "Nombre";
                this.bebidaDdl.DataValueField = "Codigo";
                this.bebidaDdl.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            //esto obtiene el valor del DropDown
            string bebidaValor = this.bebidaDdl.SelectedValue;
            //esto obtiene el texto
            string bebidaTexto = this.bebidaDdl.SelectedItem.Value;
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedItem.Value);
            //2. Construir el objeto de tipo Cliente

            List<Bebida> bebidas = bebidaDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDdl.SelectedItem.Value);

            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut = rut,
                Nivel = nivel,
                BebidaFavorita = bebida
            };
            //3. Llamar al DAL
            clientesDAL.Agregar(cliente);
            //4. Mostrar mensaje de exito
            this.mensajesLbl.Text = "Cliente Ingresado";
            Response.Redirect("VerCliente.aspx");
        }
    }
}
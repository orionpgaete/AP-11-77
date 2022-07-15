using EventosModel;
using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWEB
{
    public partial class MostrarAsistentes : System.Web.UI.Page
    {
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();

        private void cargarGrilla(List<Asistente> asistentes)
        {
            this.grillaAsistente.DataSource = asistentes;
            this.grillaAsistente.DataBind();
        }

        private void cargarGrilla()
        {
            List<Asistente> asistentes;
            if (this.todosChx.Checked)
            {
                asistentes = this.asistentesDAL.ObtenerAsistentes();
            }
            else
            {
                asistentes = this.asistentesDAL.ObtenerAsistentes(this.estadoDDL.SelectedItem.Value);
            }
            this.cargarGrilla(asistentes);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla();
            }
        }

        protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarGrilla();
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            this.estadoDDL.Enabled = !this.todosChx.Checked;
            this.cargarGrilla();
        }

        protected void grillaAsistente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.asistentesDAL.EliminarAsistente(id);
                this.cargarGrilla();
            }
        }
    }
}
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Datagridview_Autogeneratecolumns
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            {
                ddlColores.Items.Add("Rojo");
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Blanco");
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();
            a.Id = int.Parse(txtId.Text);
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;
            a.Color = ddlColores.SelectedValue;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = ChekUsado.Checked;

            if (rdbImportado.Checked)
            {
                a.Importado = true;
            }
            else if (rdbNacional.Checked)
            {
                a.Importado = false;
            }
        }
    }
}

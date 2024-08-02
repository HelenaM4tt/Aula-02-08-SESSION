using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prefeitura
{
    public partial class principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logado"] == null)
            {
                Response.Redirect("index.aspx");
                return;
            }

            if (String.IsNullOrEmpty(Session["logado"].ToString()))
            {
                Response.Redirect("index.aspx");
                return;
            }

            //string login = Session["logado"].ToString();

            //Usuarios usuarios = new Usuarios();
            //Usuario usuario = usuarios.BuscarDados(login);
         
            litNome.Text = Session["nome"].ToString(); 

        }
    }
}
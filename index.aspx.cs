using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prefeitura
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            litMsg.Text = "";
            pnlMensagem.Visible = false;

            if (String.IsNullOrEmpty(txtLogin.Text))
            { 
                litMsg.Text = "Login deve ser informado!";
                pnlMensagem.Visible = true;
                return;
            }

            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                litMsg.Text = "Senha deve ser informada!";
                pnlMensagem.Visible = true;
                return;
            }

            try
            {
                Usuarios usuarios = new Usuarios();
                Usuario usuario = usuarios.Acessar(txtLogin.Text, txtSenha.Text);
                if (usuario == null)
                {
                    litMsg.Text = "Login e/ou Senha Inválidas!";
                    pnlMensagem.Visible = true;
                }
                else
                {
                    Session["logado"] = usuario.Login;
                    Session["nome"] = usuario.Nome;
                    Response.Redirect("principal.aspx");
                }
            }
            catch (Exception erro)
            {
                litMsg.Text = erro.Message.ToString();
                pnlMensagem.Visible = true;
            }
        }
    }
}
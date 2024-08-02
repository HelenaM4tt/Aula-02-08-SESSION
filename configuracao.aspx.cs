using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prefeitura
{
    public partial class configuracao : System.Web.UI.Page
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

            string login = Session["logado"].ToString();


            Usuarios usuarios = new Usuarios();
            Usuario usuario = usuarios.BuscarDados(login);

            litNome.Text = Session["nome"].ToString();

            //litConfiguracao.Text = $@"<a href='configuracao.aspx?login={usuario.Login}' class='botaoPadrao'>
            //                                <span class='material-symbols-outlined'>settings</span> Configurações
            //                            </a>";

            //lnkLogo.NavigateUrl = "principal.aspx?login=" + usuario.Login;

            txtNome.Text = usuario.Nome;
            txtSenhaAtual.Focus();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            litMsg.Text = "";
            pnlMensagem.Visible = false;

            if (String.IsNullOrEmpty(txtSenhaAtual.Text))
            {
                litMsg.Text = "Senha atual deve ser informada!";
                pnlMensagem.Visible = true;
                return;
            }

            if (String.IsNullOrEmpty(txtNovaSenha.Text))
            {
                litMsg.Text = "Nova Senha deve ser informada!";
                pnlMensagem.Visible = true;
                return;
            }

            if (String.IsNullOrEmpty(txtConfirmacaoSenha.Text))
            {
                litMsg.Text = "Confirmação de Senha deve ser informada!";
                pnlMensagem.Visible = true;
                return;
            }

            if (txtNovaSenha.Text != txtConfirmacaoSenha.Text)
            {
                litMsg.Text = "Senhas não conferem!";
                pnlMensagem.Visible = true;
                return;
            }

            try
            {
                Usuarios usuarios = new Usuarios();
                string login = Session["logado"].ToString();
                Usuario usuario  = usuarios.AlterarSenha(login, txtSenhaAtual.Text, txtNovaSenha.Text);
                if (usuario != null)
                {
                    litMsg.Text = "Senha alterada com Sucesso!";
                    pnlMensagem.CssClass = "mensagem msgSucesso";

                    pnlMensagem.Visible = true;
                }
                else 
                {
                    litMsg.Text = "Senha atual incorreta!";
                    pnlMensagem.Visible = true;
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
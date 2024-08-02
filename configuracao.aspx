<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="configuracao.aspx.cs" Inherits="Prefeitura.configuracao" %>

<!DOCTYPE html>

<html lang="pt-br">
<head runat="server">
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="favicon.png">
	<title>Prefeitura de Santos</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@24,400,0,0" /> 
    <link rel="stylesheet" href="css/estilo.css">
    <link rel="stylesheet" href="css/estiloConfiguracao.css">
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <div class="conteudoHeader">

            <a href="principal.aspx">
                <img src="images/logo.png">
            </a>

            <div id="identificacao">
                <span>Olá <asp:Literal ID="litNome" runat="server"></asp:Literal></span>

                <a href='configuracao.aspx' class='botaoPadrao'>
                                            <span class='material-symbols-outlined'>settings</span> Configurações
                                      </a>

                <a href="sair.aspx" class="botaoPadrao">
                    <span class="material-symbols-outlined">logout</span> Sair
                </a>
            </div>
        </div>
    </header>
	
    <main>
        <h1 class="titulo">Configurações da Conta</h1>
        <section class="formulario-perfil">
            <asp:Panel ID="pnlMensagem" CssClass="mensagem msgErro" runat="server" Visible="false">
                <span class="material-symbols-outlined icone-mensagem">warning</span> 
                <span id="mensagemTexto"><asp:Literal ID="litMsg" runat="server"></asp:Literal></span>
            </asp:Panel>
            
            <p>
                <label for="txtNome">Nome: </label>
                <asp:TextBox ID="txtNome" runat="server" Enabled="false"></asp:TextBox>
            </p>

            <p>
                <label for="txtSenhaAtual">Senha Atual: </label>
                <asp:TextBox ID="txtSenhaAtual" TextMode="Password" runat="server" Placeholder="Informe a senha atual"></asp:TextBox>
            </p>

            <p>
                <label for="txtNovaSenha">Nova Senha: </label>
                <asp:TextBox ID="txtNovaSenha" TextMode="Password" runat="server" Placeholder="Defina a nova senha"></asp:TextBox>
            </p>

            <p>
                <label for="txtConfirmacaoSenha">Confirmação Senha: </label>
                <asp:TextBox ID="txtConfirmacaoSenha" TextMode="Password" runat="server" Placeholder="Confirme a nova senha"></asp:TextBox>
            </p>

            <p class="areaBotoesConfiguracao">
                <asp:LinkButton ID="btnSalvar" CssClass="botaoPadrao" runat="server" OnClick="btnSalvar_Click">
                    <span class="material-symbols-outlined icone-mensagem">save</span> Salvar
                </asp:LinkButton>
                <a href="principal.aspx" class="botaoPadrao">Cancelar</a>
            </p>

        </section>
    </main>
    </form>
</body>
</html>

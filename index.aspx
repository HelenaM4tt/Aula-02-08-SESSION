<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Prefeitura.index" %>

<!DOCTYPE html>

<html lang="pt-br">
<head runat="server">
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="favicon.png">
	<title>Prefeitura de Santos</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@24,400,0,0" /> 
    <link rel="stylesheet" href="css/estilo.css">
    <link rel="stylesheet" href="css/estiloLogar.css">
</head>
<body>
    <form id="form1" runat="server">
    <main id="formEntrar">
        <asp:Panel ID="pnlMensagem" runat="server" CssClass="mensagem msgErro" Visible="false">
            <span class="material-symbols-outlined icone-mensagem">warning</span> 
            <span id="mensagemTexto">
                <asp:Literal ID="litMsg" runat="server"></asp:Literal>
            </span>
        </asp:Panel>

        <p class="tituloEntrada">
            <img src="images/logoBranco.png">
        </p>    
        <p>
            <label for="txtLogin">Login:</label>
            <asp:TextBox ID="txtLogin" runat="server" placeholder="Digite seu email"></asp:TextBox>
        </p>
        <p>
            <label for="txtSenha">Senha:</label>
            <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" placeholder="Digite sua senha"></asp:TextBox>
        </p>
        <p>
            <asp:LinkButton ID="btnEntrar" runat="server" OnClick="btnEntrar_Click">
                <span class="material-symbols-outlined">login</span> Entrar
            </asp:LinkButton>
        </p>
	</main>
    </form>
</body>
</html>

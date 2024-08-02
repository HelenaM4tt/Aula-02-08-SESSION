<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="principal.aspx.cs" Inherits="Prefeitura.principal" %>

<!DOCTYPE html>

<html lang="pt-br">
<head runat="server">
    <meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="favicon.png">
	<title>Prefeitura de Santos</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@24,400,0,0" /> 
    <link rel="stylesheet" href="css/estilo.css">
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
    </main>
    </form>
</body>
</html>

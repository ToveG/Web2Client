<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="We2Client.mainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="Content\bootstrap.css" />
        <link rel="stylesheet" type="text/css" href="myStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <div class="jumbotron top-text">
            <h2>Välkommen till</h2>
            <h1>Web2Client</h1>
        </div>    
        <div class="row text">
            <div class="col-md-6">
                <h3>För att kunna köra programmet behöver du först installera det. </h3>
                <h3> Klicka på knappen nedan för att gå till installationen.</h3>
                <br />
                <a href="http://localhost/Web2Client/download.aspx" class="btn btn-info" role="button">Installera</a>
            </div>
            <div class="col-md-6">
                <h3>Redan installerat?</h3> 
                <h3>Klicka på knappen för att börja använda programmet.</h3>
                <br />
                <a href="http://localhost/Web2Client/commandClient.aspx" class="btn btn-info" role="button">Gå till programmet</a>
            </div>
            </div>
        </div>
    </form>
</body>
</html>

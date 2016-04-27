<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="commandClient.aspx.cs" Inherits="We2Client.commandClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Content\bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="myStyle.css" />
</head>
<body>
    <div class="container-fluid">
        <div class="jumbotron top-text">
            <a href="index.aspx"><h1>Web2Client</h1></a>
                
        </div>
        <div class="row">
     
            <div class="col-md-12 main-btns">
                <form id="form2">
                    <a href="Client2Web:01" class="btn btn-info" role="button">Knapp 1</a>
                    <a href="Client2Web:02" class="btn btn-info" role="button">Knapp 2</a>
                    <a href="Client2Web:03" class="btn btn-info" role="button">Knapp 3</a>
                    <a href="Client2Web:04" class="btn btn-info" role="button">Knapp 4</a>
                    <a href="Client2Web:05" class="btn btn-info" role="button">Aktuell Version</a>
                
                </form>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 return-btn">
                       <form id="form1 ">
                    <a href="index.aspx" class="btn btn-info" role="button">Till startsidan</a>

                    <a href="download.aspx" class="btn btn-info" role="button">Installera</a>
                </form>
            </div>
        </div>
    </div>
</body>
</html>

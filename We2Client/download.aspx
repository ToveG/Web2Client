<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="download.aspx.cs" Inherits="We2Client.download" %>

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
            <h1>Web2Client</h1>
        </div>

        <div class="row">
            <div class="col-md-12">
              <form id="form1">
                    <div class="install-btn">
                        <a href="http://localhost/Deploy/setup.exe" class="btn btn-info" role="button">Installera</a>
                    </div>
                </form>
            </div>
            <div class="col-md-12">
                  <form id="form2">
                    <div class="btn-back">
                        <a href="http://localhost/Web2Client/commandClient.aspx" class="btn btn-info" role="button">Till programmet...</a>
                    </div>
                </form>
                
            </div>

        </div>
    </div>
</body>
</html>

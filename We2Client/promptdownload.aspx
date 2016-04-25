<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promptdownload.aspx.cs" Inherits="We2Client.promptdownload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Content\bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="myStyle.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>

</head>
<body>

    <div class="container-fluid">
        <div class="jumbotron top-text">
            <h1>Web2Client</h1>
        </div>

        
<div class="container">





















        <div class="row">
            <div class="col-md-12 text">
                <h4>Det verkar som att du inte har programmet installerat på din dator. </h4>
                <h4>Vänligen klicka nedan för att installera.<br /></h4>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <form id="form1">
                    <div class="install-btn">
                        <a href="Deploy\Client2WebInstaller.application" class="btn btn-info" role="button">Installera</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
          <script type="text/javascript" src="myScript.js"></script>


    <%--  <script type="text/javascript" src="~/Scripts/JavaScript.js"></script>--%>
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</body>
</html>

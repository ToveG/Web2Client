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
        <div class="container">
            <div class="jumbotron top-text">
                <h2>Välkommen till</h2>
                <h1>Web2Client</h1>
            </div>
            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Installera Client2Web</h4>
                        </div>
                        <div class="modal-body">
                            <p>Det verkar som att programmet inte är installerat på din dator, vänligen klicka nedan för att installera applikationen. </p>
                            <a href="Deploy\Client2WebInstaller.application">--> INSTALLERA NU!</a>
                        </div>
                        <div class="modal-footer">
                            <input type="button" class="btn btn-info btn-go" id="close-btn" value="Klart! Ta mig till programmet..." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="modal fade" id="startModal" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" id="modal-close-btn-1" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Installera Client2Web</h4>
                        </div>
                        <div class="modal-body">
                            <p>Det verkar som att programmet inte är installerat på din dator, vänligen klicka nedan för att installera applikationen. </p>
                            <a href="Deploy\Client2WebInstaller.application" class="install-app">--> INSTALLERA NU!</a>
                        </div>
                        <div class="modal-footer">
                            <input type="button" class="btn btn-info btn-go" id="modal-close-btn-2" value="Nej tack." />
                        </div>
                    </div>
                </div>
            </div>
            <div class="row text">
                <div class="col-md-6">
                    <h3>För att kunna köra programmet behöver du först installera det. </h3>
                    <br />
                    <a href="download.aspx" class="btn btn-info" role="button">Installera</a>
                </div>
                <div class="col-md-6">
                    <h3>Redan installerat?<br />
                        Klicka nedan för att komma till programmet. </h3>
                    <br />
                    <input type="button" class="btn btn-info" id="my_btn" value="Start" />
                </div>
            </div>
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="myScript.js"></script>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="command.aspx.cs" Inherits="We2Client.command" %>

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
            <a href="index.aspx">
                <h1>Web2Client</h1>
            </a>
        </div>

           <!-- Modal -->
        <div class="modal fade" id="createModal" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Skapa nytt dokument</h4>
                    </div>
                    <div class="modal-body">
                            Filnamn:
                            <input type="text" name="FileName" placeholder="filnamn" /><br />

                            <input type="radio" name="docType" value="word" />
                            Word<br />
                            <input type="radio" name="docType" value="excel" />
                            Excel<br />
                       
                            <input type="radio" name="docType" value="pp" />
                            PowerPoint  
                    </div>
                    <div class="modal-footer">
                        <input type="submit" class="btn btn-info btn-go" value="Skapa" />

                    </div>
                </div>
            </div>
        </div>

        <table id="myTable" class="table" runat="server">
            <tr>
                <th>Dokument</th>
                <th></th>
                <th></th>
            </tr>
           
            </table>

         <button class="btn btn-info create-btn">Skapa</button>
        <a href="Client2Web:04" class="btn btn-info" role="button">Klistra in</a>

        
        <div class="row">
            <div class="col-md-12 to-start">
                    <a href="index.aspx" class="btn btn-info" role="button">...tillbaka</a>
            </div>
        </div>


    </div>
    </form>
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="scripts/secondScript.js"></script>

</body>
</html>

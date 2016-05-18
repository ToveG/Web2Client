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
            <div class="modal fade testet" id="createModal" role="dialog">
                <div class="modal-dialog ">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Skapa nytt dokument</h4>
                        </div>
                        <div class="modal-body document-modal">
                            <h4>Välj vilken typ av dokument du vill skapa:</h4>
                            <asp:RadioButton  ID="Word" Text="Word" Checked="True" GroupName="RadioGroup1" runat="server" /><br />
                            <asp:RadioButton ID="PowerPoint" Text="Power Point" GroupName="RadioGroup1" runat="server" /><br />
                            <asp:RadioButton ID="Excel" runat="server" Text="Excel" GroupName="RadioGroup1" /><br />
                            Filnamn:
                            <asp:TextBox id="tb3" runat="server" />
                            <asp:Button Text="Skapa" CssClass="btn btn-info" OnClick="SubmitBtn_Click" runat="server"/>
                            <div class="modal-footer">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <asp:ScriptManager runat="server" ID="sm">
            </asp:ScriptManager>
            <table id="myTable" class="table">
                <asp:Repeater runat="server" ID="rprDocTable">
                    <HeaderTemplate>
                        <thead>
                            <tr>
                                <td>ID</td>
                                <td>DOKUMENT</td>
                                <td></td>
                                <td></td>
                            </tr>
                        </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td><%# DataBinder.Eval(Container.DataItem,"id") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"docName") %></td>
                                <td>
                                    <asp:Button runat="server" ID="deleteBtn" CssClass="action-btn btn btn-info" Text="Ta Bort" OnClick="deleteBtn_Click" CommandArgument='<%# Eval("docName") %>' />
                                    <asp:Button runat="server" ID="copyBtn" CssClass="action-btn btn btn-info" Text="Kopiera" OnClick="copyBtn_Click" CommandArgument='<%# Eval("docName") %>' />
                                </td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button runat="server" ID="createBtn" CssClass="action-btn btn btn-info createBtn" OnClientClick="openCreateModal()" Text="Skapa" />
                </ContentTemplate>
            </asp:UpdatePanel>
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

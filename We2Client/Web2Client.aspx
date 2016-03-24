<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web2Client.aspx.cs" Inherits="We2Client.Web2Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web2Client</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <h1> Välkommen till Web2Client!</h1>
        <br />
        <br />
    
        <asp:Button ID="Button2" runat="server" Text="Funktion1" OnClick="Button2_Click" />
        <asp:Button ID="Button4" runat="server" Text="Funktion2" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Funktion3" OnClick="Button5_Click" />
        <asp:Button ID="Button3" runat="server" Text="Funktion4" OnClick="Button3_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Aktuell version" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

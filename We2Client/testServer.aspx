<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testServer.aspx.cs" Inherits="We2Client.testServer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    


    </div>
    </form>
    <form action="w2cService.asmx.cs/HelloWorld" method="post" target="_blank">

        <input type="submit" value="Submit" class="button"/>
        
    </form>




</body>
</html>

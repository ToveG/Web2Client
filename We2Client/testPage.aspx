<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testPage.aspx.cs" Inherits="We2Client.testPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link rel="stylesheet" type="text/css" href="Content\bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="myStyle.css" />
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    


</head>
<body>
<div><h2>Let AJAX change this text</h2></div>

<button>Change Content</button>

    <button onclick="checkAppStatus()">knapp</button>


    <script type="text/javascript" src="myScript.js"></script>
  <%--   //   <script type="text/javascript" src="scripts/myScript.js"></script>--%>
<%--  <script type="text/javascript" src="~/Scripts/JavaScript.js"></script>--%>
<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
</body>
</html>

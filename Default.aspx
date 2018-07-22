<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="GlobalStyle.css" type="text/css" />
    <title id="newUserTitle" runat="server"></title>
</head>
<body>
    <div id="globalHeader" runat="server" class="globalheaderNav"></div>
    <div id="header" runat="server" class="headerNav"></div><br />
    <form id="newUserForm" runat="server">
        <div id="newUserFormIntroText" runat="server" class="formIntro"></div><br /><br />
        <div id="newUserFirstNameText" runat="server" class="formDetail"></div>
        <input id="newUserFirstName" runat="server" type="text" /><br /><br />
        <div id="newUserLastNameText" runat="server" class="formDetail"></div>
        <input id="newUserLastName" runat="server" type="text" /><br /><br />
        <div id="newUserUserNameText" runat="server" class="formDetail"></div>
        <input id="newUserUserName" runat="server" type ="text" /><br /><br />
        <div id="newUserEmailText" runat="server" class="formDetail"></div>
        <input id="newUserEmail" runat="server" type ="text" /><br /><br />
        <button id="newUserSubmitButton" runat="server" class ="button" onserverclick="SubmitClick">Submit</button> <br />
    </form>
    <div id="afterNewUserFormDiv" runat="server"></div>
</body>
</html>

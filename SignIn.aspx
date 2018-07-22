<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="_SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="GlobalStyle.css" type="text/css" />
    <title id="newUserTitle" runat="server"></title>
</head>
<body>
    <div id="globalHeader" runat="server" class="globalheaderNav"></div>
    <div id="header" runat="server" class="headerNav"></div>
    <div id="signInLinkContainingDiv" runat="server" class="headerLinkContainingDiv">
        <a href="SignIn.aspx" id="signInLink" runat="server" class="headerLink"></a>
    </div><br /> 
    <div id="registrationLink" runat="server" class="headerLink"></div><br />
    <br />
    <form id="signInForm" runat="server">
        <div id="signInFormIntroText" runat="server" class="formIntro"></div><br /><br />
        <div id="signInEmailText" runat="server" class="formDetail"></div>
        <input id="signInEmail" runat="server" type ="text" /><br /><br />
        <div id="signInPasswordText" runat="server" class="formDetail"></div>
        <input id="signInPassword" runat="server" type ="text" /><br /><br />
        <button id="signInSubmitButton" runat="server" class ="button">Submit</button> <br />
    </form>
    <div id="afterSignInFormDiv" runat="server"></div>
</body>
</html>
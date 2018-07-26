using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using Submit;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.newUserTitle.Text = "Eriks Banking Site";
        this.globalHeader.InnerHtml = "The Dopest Bank Website Ever";
        this.signInLinkContainingDiv.InnerHtml = "Test Containing Div" + PrimaryNavigationHeader();
        this.newUserFormIntroText.InnerHtml = "Please enter your name.";
        this.newUserFirstNameText.InnerHtml = "First Name:";
        this.newUserLastNameText.InnerHtml = "Last Name:";
        this.newUserUserNameText.InnerHtml = "Username:";
        this.newUserEmailText.InnerHtml = "Email:";
        newUserSubmitButton.ServerClick += new EventHandler(this.SubmitNewUser);
    }

    public void SubmitNewUser(object sender, EventArgs e)
    {
        CreateNewUser newUser = new CreateNewUser(this.newUserFirstName.Value, this.newUserLastName.Value, this.newUserUserName.Value, this.newUserEmail.Value);
        newUser.SubmitNewRegistration();
    }

    public string PrimaryNavigationHeader()
    {
        string headerLinkOne = PrimaryNavigationHeaderLink("SignIn.aspx", "signInLink", "headerLink", "Sign in");
        string headerLinkTwo = PrimaryNavigationHeaderLink("Register.aspx", "registerLink", "headerLink", "Register");
        return headerLinkOne + headerLinkTwo;
    }

    public string PrimaryNavigationHeaderLink(string hrefAnchor, string idAnchor, string classAnchor, string innerHtml)
    {
        return "\n" + "<a href=\"" + hrefAnchor + "\" id=\"" + idAnchor + "\" class=\"" + classAnchor + "\">" + innerHtml + "</a>" + "\n";
    }

    public string EncapsulateDiv(string innerText)
    {
        string openDiv = "<div>";
        string closeDiv = "</div>";
        string combineDiv = openDiv + innerText + closeDiv;
        return combineDiv;
    }

}
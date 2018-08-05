using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using Headers;
using Submit;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.newUserTitle.Text = "Eriks Banking Site";
        this.globalHeader.InnerHtml = GlobalHeader.GlobalHeaderInnerHtml();
        this.signInLinkContainingDiv.InnerHtml = PrimaryNavigationHeader.PrimaryNavigationHeaderInnerHtml();
        this.newUserFormIntroText.InnerHtml = "Please enter your name.";
        this.newUserFirstNameText.InnerHtml = "First Name:";
        this.newUserLastNameText.InnerHtml = "Last Name:";
        this.newUserUserNameText.InnerHtml = "Username:";
        this.newUserEmailText.InnerHtml = "Email:";
        this.afterNewUserFormDiv.InnerHtml = "This is a div after the form.";
        newUserSubmitButton.ServerClick += new EventHandler(this.SubmitNewUser);
    }
    public void SubmitNewUser(object sender, EventArgs e)
    {
        CreateNewUser newUser = new CreateNewUser(this.newUserFirstName.Value, this.newUserLastName.Value, this.newUserUserName.Value, this.newUserEmail.Value);
        newUser.SubmitNewRegistration();
    }
}
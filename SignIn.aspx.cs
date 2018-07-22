using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using Submit;

public partial class _SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.newUserTitle.Text = "Eriks Banking Site";
        this.globalHeader.InnerHtml = "The Dopest Bank Website Ever";
        this.header.InnerHtml = "Please enter your Username and Password";
        this.signInLink.InnerHtml = "Sign in";
        this.signInFormIntroText.InnerHtml = "Please enter your name.";
        this.signInEmailText.InnerHtml = "Email:";
        this.signInPasswordText.InnerHtml = "Password:";
    }
}
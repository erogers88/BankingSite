using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.newUserTitle.Text = "Eriks Banking Site";
        this.header.InnerHtml = "New User Registration";
        this.newUserFormIntroText.InnerHtml = "Please enter your name.";
        this.afterNewUserFormDiv.InnerHtml = "This div appears after the form.";
    }
}
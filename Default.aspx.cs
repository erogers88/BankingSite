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
        this.header.InnerHtml = "New User Registration";
        this.newUserFormIntroText.InnerHtml = "Please enter your name.";
        newUserSubmitButton.ServerClick += new EventHandler(this.SubmitClick);
    }

    public void SubmitClick(object sender, EventArgs e)
    {
        CreateNewUser newUser = new CreateNewUser(this.newUserFirstName.Value, this.newUserLastName.Value, this.newUserUserName.Value, this.newUserEmail.Value);
        newUser.SubmitNewRegistration();
    }
}
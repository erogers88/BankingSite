using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using Headers;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.newUserTitle.Text = "Eriks Banking Site";
        this.globalHeader.InnerHtml = GlobalHeader.GlobalHeaderInnerHtml();
        this.signInLinkContainingDiv.InnerHtml = PrimaryNavigationHeader.PrimaryNavigationHeaderInnerHtml();
        this.afterNewUserFormDiv.InnerHtml = "This is a div after the form.";
    }
}
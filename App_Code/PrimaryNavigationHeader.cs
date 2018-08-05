using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This class returns static HTML for the primary navigation header.
/// </summary>
/// 

namespace Headers
{
    public static class PrimaryNavigationHeader
    {
        public static string PrimaryNavigationHeaderInnerHtml()
        {
            string headerLinkOne = PrimaryNavigationHeaderLink("SignIn.aspx", "signInLink", "headerLink", "Sign in");
            string headerLinkTwo = PrimaryNavigationHeaderLink("Register.aspx", "registerLink", "headerLink", "Register");
            return headerLinkOne + headerLinkTwo;
        }
        private static string PrimaryNavigationHeaderLink(string hrefAnchor, string idAnchor, string classAnchor, string innerHtml)
        {
            return "\n" + "<a href=\"" + hrefAnchor + "\" id=\"" + idAnchor + "\" class=\"" + classAnchor + "\">" + innerHtml + "</a>" + "\n";
        }
        /*
        private static string EncapsulateDiv(string innerText)
        {
            string openDiv = "<div>";
            string closeDiv = "</div>";
            string combineDiv = openDiv + innerText + closeDiv;
            return combineDiv;
        }
        */
    }
}
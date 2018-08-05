using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This class returns static HTML for the global navigation header.
/// </summary>
/// 

namespace Headers
{
    public static class GlobalHeader
    {
        public static string GlobalHeaderInnerHtml()
        {
            string GlobalHeaderText = "The Dopest Bank Website Ever";
            return GlobalHeaderText;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
	    Page.LoadComplete += Page_LoadComplete;


    }
	protected void Page_LoadComplete(object sender, EventArgs e)
    {
	    if (Session["backColor"] != null) {
			Debug.WriteLine(Session["backColor"]);
			Debug.WriteLine(header);
			header.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#" + Session["backColor"]);
	    }
    }
}

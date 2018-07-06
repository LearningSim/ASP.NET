using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Visitors : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
	    if (!IsPostBack) {
			Application.Lock();
			Application["visitorCounter"] = (int)Application["visitorCounter"] + 1;
			Application.UnLock();
	    }

	    Label1.Text = Application["visitorCounter"].ToString();
    }
}
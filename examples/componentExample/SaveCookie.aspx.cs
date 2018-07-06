using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SaveCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void Button1_Click(object sender, EventArgs e) {
		Response.SetCookie(new HttpCookie("name", TextBox1.Text));
	}
}
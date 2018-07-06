using System;
using System.Web.UI;

public partial class Main : MasterPage
{
	public string userName;

	protected void Page_Load(object sender, EventArgs e) {
		if (Page.User.Identity.IsAuthenticated) {
			userName = Page.User.Identity.Name;
		}
		else {
			userName = "Аноним";
		}
	}
}

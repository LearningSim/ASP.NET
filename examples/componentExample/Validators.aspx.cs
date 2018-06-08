using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Validators : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = args.Value.Length >= 6;
    }
}
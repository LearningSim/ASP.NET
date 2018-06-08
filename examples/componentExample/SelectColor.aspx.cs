using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectColor : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        (sender as DropDownList).Style.Add(HtmlTextWriterStyle.BackgroundColor, DropDownList1.SelectedValue);
    }
}
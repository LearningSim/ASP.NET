using System;
using System.Web.UI;

public partial class CompanyContacts : Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        Person1.OkClick += Person1_OkClick;
    }

    void Person1_OkClick(object sender, EventArgs e)
    {
        Title = Person1.Name;
    }
}
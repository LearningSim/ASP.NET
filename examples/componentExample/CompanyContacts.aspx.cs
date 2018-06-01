using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CompanyContacts : System.Web.UI.Page
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
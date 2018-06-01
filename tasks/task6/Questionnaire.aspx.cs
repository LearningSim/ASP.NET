using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Questionnaire : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        UserForm1.OkClick += UserForm1_OkClick;
    }

    void UserForm1_OkClick(object sender, EventArgs e)
    {
        nameLabel.Text = string.Format("Ваше имя: {0}", UserForm1.Name);
    }
}
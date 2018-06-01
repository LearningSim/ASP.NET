using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserForm_UC : System.Web.UI.UserControl
{
    public event EventHandler OkClick = delegate { };
    public string Name
    {
        get
        {
            return txtName.Text;
        }
        set
        {
            txtName.Text = value;
        }
    }
    protected void okBtn_Click(object sender, EventArgs e)
    {
        if (OkClick != null)
        {
            OkClick(sender, e);
        }
    }
}
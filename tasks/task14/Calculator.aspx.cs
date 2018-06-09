using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculator : System.Web.UI.Page
{
    protected void sumBtn_Click(object sender, EventArgs e)
    {
        resultField.Text = (float.Parse(addend1.Text) + float.Parse(addend2.Text)).ToString();
    }
}
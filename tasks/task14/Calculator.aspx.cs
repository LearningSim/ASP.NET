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
        if (IsValid)
        {
            float a = float.Parse(addend1.Text);
            float b = float.Parse(addend2.Text);
            resultField.Text = (a + b).ToString();
        }
    }
}
using System;
using System.Web.UI;

public partial class Person_UC : UserControl
{
    public event EventHandler OkClick = delegate { };

    public string HeaderText
    {
        get
        {
            return headLabel.Text;
        }
        set
        {
            headLabel.Text = value;
        }
    }
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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        OkClick(sender, e);
    }
}
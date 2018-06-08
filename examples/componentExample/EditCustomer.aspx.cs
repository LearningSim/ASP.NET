using System;
using System.Linq;
using System.Web.UI;
using CustomerManagementModel;

public partial class EditCustomer : Page
{
	private CustomerManagementEntities context;

	protected void Page_Init(object sender, EventArgs e)
	{
		context = new CustomerManagementEntities();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		var id = Guid.Parse(Request["ID"]);
		if (!IsPostBack)
		{
			var customer = GetCustomerById(id);
			firstNameField.Text = customer.FirstName;
			LastNameField.Text = customer.LastName;
			addressField.Text = customer.Address;

			countries.DataSource = context.Countries.OrderBy(c => c.Name);
			countries.DataBind();
			countries.SelectedValue = customer.Country.ToString();
		}
	}

	CustomerManagementModel.Customer GetCustomerById(Guid id)
	{
		return
			context.Customers.FirstOrDefault(c => c.ID == id);
	}
}
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
		if (IsPostBack) return;

		var rawId = Request["ID"];
		CustomerManagementModel.Customer customer = null;
		if (rawId != null)
		{
			customer = GetCustomerById(Guid.Parse(rawId));

			firstNameField.Text = customer.FirstName;
			LastNameField.Text = customer.LastName;
			addressField.Text = customer.Address;
		}

		countries.DataSource = context.Countries.OrderBy(c => c.Name);
		countries.DataBind();
		if (rawId != null)
		{
			countries.SelectedValue = customer.Country.ToString();
		}
	}

	private CustomerManagementModel.Customer GetCustomerById(Guid id)
	{
		return
			context.Customers.FirstOrDefault(c => c.ID == id);
	}

	protected void saveBtn_Click(object sender, EventArgs e)
	{
		if (!IsValid)
		{
			return;
		}

		var rawId = Request["ID"];
		CustomerManagementModel.Customer customer;
		if (rawId == null)
		{
			customer = new CustomerManagementModel.Customer();
			context.AddToCustomers(customer);
		}
		else
		{
			customer = GetCustomerById(Guid.Parse(rawId));
		}

		customer.FirstName = firstNameField.Text;
		customer.LastName = LastNameField.Text;
		customer.Address = addressField.Text;
		customer.CountryID =
			(from c in context.Countries
				where c.Name == countries.Text
				select c.ID)
			.FirstOrDefault();

		context.SaveChanges();
		Response.Redirect("~/CustomerByCountry.aspx");
	}
}
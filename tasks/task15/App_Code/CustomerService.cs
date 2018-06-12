using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;
using CustomerManagementModel;

/// <summary>
/// Summary description for CustomerService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CustomerService : System.Web.Services.WebService {
	public CustomerService() {
		//Uncomment the following line if using designed components 
		//InitializeComponent(); 
	}

	[WebMethod]
	public string[] GetCountries() {
		var context = new CustomerManagementEntities();
		var res =
			from c in context.Countries
			orderby c.Name
			select c.Name;
		return res.ToArray();
	}

	[WebMethod]
	public Customer[] GetCustomersByCountry(string country) {
		var context = new CustomerManagementEntities();
		return
			(from customer in context.Customers
				where customer.Country.Name == country
				select customer)
			.ToArray();
	}
}
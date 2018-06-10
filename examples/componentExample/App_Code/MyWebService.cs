using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CustomerManagementModel;

/// <summary>
/// Summary description for MyWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class MyWebService : System.Web.Services.WebService {

    public MyWebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

	[WebMethod]
	public decimal Average(int a, int b)
	{
		return (a + b) / 2M;
	}

	[WebMethod]
	public string[] GetCountries()
	{
		var context = new CustomerManagementEntities();
		var res =
			from c in context.Countries
			orderby c.Name
			select c.Name;
		return res.ToArray();
	}
}

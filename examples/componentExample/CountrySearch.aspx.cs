using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class CountrySearch : Page
{
	protected void searchField_TextChanged(object sender, EventArgs e)
	{
		var searchQuery = searchField.Text;

		//var result = GetCountriesFromXml(searchQuery);
		var result = GetCountriesFromDb(searchQuery);

		if (string.IsNullOrWhiteSpace(searchQuery))
		{
			result = new List<string>();
		}
		countryList.DataSource = result;
		countryList.DataBind();
		if (result.Any())
		{
			countryList.Rows = result.Count();
		}
		else
		{
			countryList.Items.Add("No results");
			countryList.Rows = 1;
		}
	}

	private IEnumerable<string> GetCountriesFromXml(string searchQuery)
	{
		var doc = XElement.Load(Server.MapPath(@"~/Countries.xml"));
		var result =
			from c in doc.Elements("Country")
			where c.Attribute("Name").Value.IndexOf(searchQuery, StringComparison.CurrentCultureIgnoreCase) >= 0
			select c.Attribute("Name").Value;
		return result;
	}

	private IEnumerable<string> GetCountriesFromDb(string searchQuery)
	{
		var context = new CustomerManagementLINQDataContext();
		return 
			from c in context.Countries
			where c.Name.Contains(searchQuery)
			orderby c.Name
			select c.Name;
	}
}
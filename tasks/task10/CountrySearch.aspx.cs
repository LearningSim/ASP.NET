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

		var doc = XElement.Load(Server.MapPath(@"~/Countries.xml"));
		var result =
			from c in doc.Elements("Country")
			where c.Attribute("Name").Value.IndexOf(searchQuery, StringComparison.CurrentCultureIgnoreCase) >= 0
			select c.Attribute("Name").Value;

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
}
using System;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

public partial class CountryByCode : Page
{
	protected void searchBtn_Click(object sender, EventArgs e)
	{
		var isoCode = isoCodeField.Text;
		if (string.IsNullOrWhiteSpace(isoCode)) return;
		var doc = XElement.Load(Server.MapPath(@"~\Countries.xml"));
		var result =
			from c in doc.Elements("Country")
			where c.Attribute("InternetTLD").Value.Equals(isoCode, StringComparison.CurrentCultureIgnoreCase)
			select c.Attribute("Name").Value;

		countryName.Text = result.FirstOrDefault();
	}
}
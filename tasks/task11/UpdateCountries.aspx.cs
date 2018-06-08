using System;
using System.Diagnostics;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;
using CustomerManagementModel;

public partial class UpdateCountries : Page
{
	private CustomerManagementEntities context;

	protected void Page_Init(object sender, EventArgs e)
	{
		context = new CustomerManagementEntities();
	}

	protected void updateBtn_Click(object sender, EventArgs e)
	{
		var doc = XElement.Load(Server.MapPath("~/App_Data/Countries.xml"));
		var formattedCountries =
			from c in doc.Elements("Country")
			where c.Attribute("PhoneNoFormat") != null && !string.IsNullOrWhiteSpace(c.Attribute("PhoneNoFormat").Value)
			select c;

		var countries =
			from formattedCountry in formattedCountries
			from c in context.Countries
			where c.ID.ToString() == formattedCountry.Attribute("ID").Value
			select c;

		foreach (var formattedCountry in formattedCountries)
		{
			var country = new Country
			{
				ID = Guid.Parse(formattedCountry.Attribute("ID").Value),
				Name = formattedCountry.Attribute("Name").Value,
				PhoneNoFormat = formattedCountry.Attribute("PhoneNoFormat").Value,
				DialingCountryCode = formattedCountry.Attribute("DialingCountryCode").Value,
				InternationalDialingCode = formattedCountry.Attribute("InternationalDialingCode").Value,
				InternetTLD = formattedCountry.Attribute("InternetTLD").Value
			};
			context.AddToCountries(country);
		}

		context.SaveChanges();

		Debug.WriteLine("withPhoneIds.Count() "+ formattedCountries.Count());
		Debug.WriteLine("countries.Count() "+ countries.Count());
	}
}
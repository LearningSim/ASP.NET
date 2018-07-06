using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using CustomerManagementModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyWcfService" in code, svc and config file together.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class MyWcfService : IMyWcfService {
	public string CountryByCode(string isoCode) {
		var context = new CustomerManagementEntities();
		return
			(from c in context.Countries
				where c.InternetTLD == isoCode
				select c.Name)
			.FirstOrDefault();
	}
}
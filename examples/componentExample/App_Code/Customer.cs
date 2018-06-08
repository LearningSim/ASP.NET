using System;
using System.Linq;
using System.Web;

namespace CustomerManagementModel
{
	public partial class Customer
	{
		public Customer()
		{
			ID = Guid.NewGuid();
			ZipCode = "";
			City = "";
			CountryID = Guid.NewGuid();
			Url = "";
			CreditLimit = 0;
			NewsSubscriber = true;
			CreatedDate = DateTime.Now;
			CreatedBy = HttpContext.Current != null ? HttpContext.Current.User.Identity.Name : "";
		}

		public Country Country
		{
			get
			{
				var context = new CustomerManagementEntities();
				return context.Countries.FirstOrDefault(c => c.ID == CountryID);
			}
			set { CountryID = value.ID; }
		}
	}
}
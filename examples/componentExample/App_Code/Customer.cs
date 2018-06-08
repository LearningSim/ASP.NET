using System.Linq;

namespace CustomerManagementModel
{
	public partial class Customer
	{
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
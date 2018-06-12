using System;
using System.Windows.Forms;
using CustomerClient.Service;

namespace CustomerClient {
	public partial class Form1 : Form {
		private CustomerService service = new CustomerService();

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			service.GetCountriesCompleted += service_GetCountriesCompleted;
			service.GetCustomersByCountryCompleted += service_GetCustomersByCountryCompleted;
			service.GetCountriesAsync();
		}

		void service_GetCountriesCompleted(object sender, GetCountriesCompletedEventArgs e) {
			if (e.Cancelled) return;
			if (e.Error != null) {
				MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			countryList.DataSource = e.Result;
		}

		private void countryList_SelectedIndexChanged(object sender, EventArgs e) {
			service.GetCustomersByCountryAsync(countryList.SelectedValue.ToString());
		}

		void service_GetCustomersByCountryCompleted(object sender, GetCustomersByCountryCompletedEventArgs e) {
			if (e.Cancelled) return;
			if (e.Error != null) {
				MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			customerGrid.Rows.Clear();
			foreach (var customer in e.Result) {
				customerGrid.Rows.Add(customer.FirstName, customer.LastName, customer.Address, customer.City, customer.Country.Name);
			}
		}
	}
}
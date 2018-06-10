using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsClient.MyService;

namespace WindowsFormsClient {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void fillBtn_Click(object sender, EventArgs e)
		{
			var service = new MyWebService();

			// sync load
			//var countries = service.GetCountries();
			//countryList.DataSource = countries;

			// async
			service.GetCountriesCompleted += service_GetCountriesCompleted;
			service.GetCountriesAsync();
		}

		void service_GetCountriesCompleted(object sender, GetCountriesCompletedEventArgs e) {
			if (e.Cancelled) return;
			if (e.Error != null)
			{
				MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			countryList.DataSource = e.Result;
		}
	}
}

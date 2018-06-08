using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class CustomerByCountry : Page
{
	private SqlConnection con;
	private DataSet dataSet;

	void FillCountryList()
	{
		var sql = "SELECT ID, Name FROM Countries ORDER BY Name";
		var cmd = new SqlCommand(sql, con);
		var reader = cmd.ExecuteReader();

		countries.DataSource = reader;
		countries.DataTextField = "Name";
		countries.DataValueField = "ID";

		countries.DataBound += countries_DataBound;
		countries.DataBind();
		reader.Close();
	}

	void countries_DataBound(object sender, EventArgs e) {
		countries.Items.Insert(0, "Все страны");
	}

	void UpdateGrid()
	{
		var sql = @"SELECT Customers.ID, Customers.FirstName, Customers.LastName, Customers.Address, Customers.Phone, Customers.City, Customers.State, 
					Countries.Name as Country
					from Customers 
					left outer join Countries 
					on Customers.CountryID = Countries.ID 
					order by Customers.LastName";

		var adapter = new SqlDataAdapter(sql, con);
		dataSet = new DataSet();
		adapter.Fill(dataSet, "Customer");

		customerGrid.DataSource = dataSet;
		customerGrid.DataMember = "Customer";
		customerGrid.DataBind();
	}

    protected void Page_Init(object sender, EventArgs e)
    {
		string conSettings = ConfigurationManager.ConnectionStrings["CustomerManagement"].ConnectionString;
		con = new SqlConnection(conSettings);
		con.Open();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
	    if (!IsPostBack)
	    {
			FillCountryList();
			UpdateGrid();
	    }
    }
	protected void countries_SelectedIndexChanged(object sender, EventArgs e) {
		UpdateGrid();
		if (countries.SelectedIndex > 0)
		{
			dataSet.Tables["Customer"].DefaultView.RowFilter = string.Format("Country = '{0}'", countries.SelectedItem.Text);
			customerGrid.DataSource = dataSet.Tables["Customer"].DefaultView;
			customerGrid.DataBind();
		}
	}

	protected void Page_Unload(object sender, EventArgs e) {
		if (con != null)
		{
			con.Close();
		}
	}
}
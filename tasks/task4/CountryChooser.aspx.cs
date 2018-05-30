using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyStorage;

public partial class CountryChooser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UpdateCities();
        }
    }
    protected void countries_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateCities();
    }

    private void UpdateCities()
    {
        cities.Items.Clear();
        var citySource = Storage.GetCitiesByCountry(countries.SelectedValue);
        foreach (var city in citySource)
        {
            cities.Items.Add(city);
        }
    }
}
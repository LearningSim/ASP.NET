using System;
using System.Web.UI;
using MyStorage;

public partial class CountryChooser : Page
{
    private Storage context;

    protected void Page_Init(object sender, EventArgs e)
    {
        context = new Storage();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UpdateCities();
        }
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        context.Dispose();
    }

    protected void countries_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateCities();
    }

    private void UpdateCities()
    {
        cities.Items.Clear();
        var citySource = context.GetCitiesByCountry(countries.SelectedValue);
        foreach (var city in citySource)
        {
            cities.Items.Add(city);
        }
    }
}
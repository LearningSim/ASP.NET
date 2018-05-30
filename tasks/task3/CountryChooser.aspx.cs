using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CountryChooser : System.Web.UI.Page
{
    private Dictionary<string, string[]> cityMap = new Dictionary<string, string[]>
    {
        {"Америка", new string[]{"Вашингтон", "Детроит"}},
        {"Россия", new string[]{"Томск", "Нефтеюганск"}}
    };
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
        foreach (var city in cityMap[countries.SelectedValue])
        {
            cities.Items.Add(city);
        }
    }
}
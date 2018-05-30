using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStorage
{
    public class Storage
    {
        private static Dictionary<string, string[]> cityMap = new Dictionary<string, string[]>
    {
        {"Америка", new string[]{"Вашингтон", "Детроит"}},
        {"Россия", new string[]{"Томск", "Нефтеюганск"}}
    };

        public static IEnumerable<string> GetCitiesByCountry(string country)
        {
            return cityMap[country];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStorage
{
    public class Storage : IDisposable
    {
        private Dictionary<string, string[]> cityMap = new Dictionary<string, string[]>
        {
            {"Америка", new string[]{"Вашингтон", "Детроит"}},
            {"Россия", new string[]{"Томск", "Нефтеюганск"}}
        };

        public void Dispose()
        {
            cityMap = null;
        }

        public IEnumerable<string> GetCitiesByCountry(string country)
        {
            return cityMap[country];
        }
    }
}

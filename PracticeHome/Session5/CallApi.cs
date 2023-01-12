using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using T2203E_CSharp.session5;

namespace CSharp.PracticeHome.Session5
{
    public class CallApi
    {

        public async Task<RootWeather> GetData()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";

            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                RootWeather p = JsonConvert.DeserializeObject<RootWeather>(responseText);
                return p;
            }
            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using APIClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using System.Web;

namespace APIClient
{
    public class APIClientConsumer
    {

        private HttpClient _client = new HttpClient();


        public async Task<SteamAppList> GetStuffAsync(string path)
        {
            var response = await _client.GetStringAsync(path);
            //var data = (JArray)JObject.Parse(response).Children<JProperty>().First(p => p.Path == "data").Value;
            //var test = data.ToObject<List<User>>();
            var test = JsonConvert.DeserializeObject<SteamAppList>(response);
            return test;
        }

        public string GetApiKey()
        {
            return File.ReadAllText(HttpRuntime.AppDomainAppPath.Replace(@"\", "/") + @"dependantFiles/steamApiKey.txt");
        }

        public async Task<SteamAppList> GetApps()
        {
            // Update port # in the following line.
            //get Steam web API Key from folder so it doesn't go in git

            _client.BaseAddress = new Uri("http://api.steampowered.com");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return (await GetStuffAsync("/ISteamApps/GetAppList/v1/?key=" + GetApiKey()));
        }
    }


  


}

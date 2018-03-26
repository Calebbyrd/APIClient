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
using RestAPItest.Models;

namespace APIClient
{
    public class APIClientConsumer
    {
        private HttpClient getNewHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.steampowered.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            return client;

        }

        public async Task<string> GetJsonAsync(string path)
        {
            var client = getNewHttpClient();
            return await client.GetStringAsync(path);
        }

        public string GetApiKey()
        {
            return File.ReadAllText(HttpRuntime.AppDomainAppPath.Replace(@"\", "/") + @"dependantFiles/steamApiKey.txt");
        }

        public async Task<List<App>> GetApps()
        {
            // Update port # in the following line.
            //get Steam web API Key from folder so it doesn't go in git
            //get json string
            var steamAppsList = await GetJsonAsync("/ISteamApps/GetAppList/v1/?key=" + GetApiKey());
            //convert the json string to an object and just return the list of apps
            return JsonConvert.DeserializeObject<SteamAppList>(steamAppsList).AppList.apps.App;
            
        }

        public async Task<SteamProfile> GetUserIdFromVanityUrl(string vanityUrl)
        {
            var profileInfo = await GetJsonAsync("/ISteamUser/ResolveVanityURL/v1/?key=" + GetApiKey() + "&vanityurl=" + vanityUrl);
            // get SteamID
            return JsonConvert.DeserializeObject<SteamProfile>(profileInfo);
            
        }
        public async Task<SteamProfile> GetPlayerSummaries(string steamId)
        {
            var summaries = await GetJsonAsync("/ISteamUser/GetPlayerSummaries/v2/?key=" + GetApiKey() + "&steamids=" + steamId);
            //Get profile data from SteamID
            return JsonConvert.DeserializeObject<SteamProfile>(summaries); 
        }
    }
}

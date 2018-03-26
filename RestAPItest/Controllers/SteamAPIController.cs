using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using APIClient;
using RestAPItest.Models;

namespace RestAPItest.Controllers
{
    public class SteamAPIController : Controller
    {
        private APIClientConsumer _api = new APIClientConsumer();
        // GET: SteamAPI
        public ActionResult Index()
        {
            return View("SteamAPI");
        }

        public async Task<ActionResult> GetSteamApps()
        {
            SteamAppVm steamAppList = new SteamAppVm
            { 
                SteamApps = await _api.GetApps()
            };
            return View("_appList", steamAppList);
        }
        public async Task<ActionResult> GetUserIdFromVanityUrl(string vanityUrl)
        {
            var result = await _api.GetUserIdFromVanityUrl(vanityUrl);
            var profileInfo = await _api.GetPlayerSummaries(result.Response.SteamId);
            return View("_profileInfo", profileInfo);
        }
    }
}
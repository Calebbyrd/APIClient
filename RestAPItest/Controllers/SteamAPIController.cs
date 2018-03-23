using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using APIClient;

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
            var steamAppList = await _api.GetApps();
            return View("_allAppList", steamAppList);
        }
    }
}
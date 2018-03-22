using System;

using System.Web.Mvc;
using APIClient;
using System.Threading.Tasks;
using APIClient.Models;


namespace RestAPItest.Controllers
{
    public class HomeController : Controller
    {
        private APIClientConsumer _api = new APIClientConsumer();
        public async Task<ActionResult> Index()
        {
            var apiKey = _api.GetApiKey();
            //testing source control
            await _api.GetApps();
            return View();
        }
    }
}
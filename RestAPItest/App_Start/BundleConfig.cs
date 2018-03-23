using System.Web;
using System.Web.Optimization;

namespace RestAPItest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").IncludeDirectory("~/Scripts/",
                        "*.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/Base/css").Include(
                "~/Content/Site.css"
            ));

            bundles.Add(new ScriptBundle("~/Content/SteamAPI/js").Include(
                "~/Content/SteamAPI/js-SteamAPI.js"
                ));
            bundles.Add(new StyleBundle("~/Content/SteamAPI/css").Include(
                "~/Content/SteamAPI/css-SteamAPI.css"
            ));

        }
    }
}

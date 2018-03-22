using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Models
{
    public class SteamAppList
    {
        public AppList AppList { get; set; }
        
    }

    public class AppList
    {
        public apps apps { get; set; }
    }
    public class apps
    {
        public List<App> App { get; set; }
    }
    public class App
    {
        public int AppId { get; set; }
        public string Name { get; set; }
    }
}

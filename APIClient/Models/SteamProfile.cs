using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPItest.Models
{
    public class SteamProfile
    {
        public response Response { get; set; }
    }

    public class response
    {
        public string SteamId { get; set; }
        public int Success { get; set; }
    }
}
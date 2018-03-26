using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPItest.Models
{
    public class SteamProfile
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public string SteamId { get; set; }
        public int Success { get; set; }
        public List<Player> Players { get; set; }

    }

    public class Player
    {
        public string Steamid { get; set; }
        public int Communityvisibilitystate { get; set; }
        public int Profilestate { get; set; }
        public string Personaname { get; set; }
        public int Lastlogoff { get; set; }
        public string Profileurl { get; set; }
        public string Avatar { get; set; }
        public string Avatarmedium { get; set; }
        public string Avatarfull { get; set; }
        public int Personastate { get; set; }
        public string Realname { get; set; }
        public string Primaryclanid { get; set; }
        public int Timecreated { get; set; }
        public int Personastateflags { get; set; }
        public string Loccountrycode { get; set; }
    }
}
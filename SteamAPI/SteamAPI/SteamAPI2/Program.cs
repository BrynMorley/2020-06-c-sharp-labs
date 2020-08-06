using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading;
using Steam.Models;
using Steam.Models.SteamCommunity;

namespace SteamAPI2
{
    public class Program
    {   
        static List<Player> players = new List<Player>();
        static Uri url = new Uri("https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=2901A4BCBA478FDD1D4226CECD80A1C7&steamids=76561198033967649");
        
        static void Main(string[] args)
        {
            const string BrynID = "76561198033967649";
            getPlayer(BrynID);
            getRecentGames(BrynID);
              
        }

       public static Root getPlayer(string steamID)
        {
            using (var httpclient = new HttpClient())
            {
                Uri url = new Uri($"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=2901A4BCBA478FDD1D4226CECD80A1C7&steamids={steamID}");
                var data = httpclient.GetStringAsync(url);
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data.Result);
                 Console.WriteLine(myDeserializedClass.response.players[0].personaname);
                return myDeserializedClass;
            }
        }

       public static Root getRecentGames(string steamID)
        {
            using (var httpclient = new HttpClient())
            {
                Uri url = new Uri($"https://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v1/?key=2901A4BCBA478FDD1D4226CECD80A1C7&steamid={steamID}");
                var data = httpclient.GetStringAsync(url);
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data.Result);
                  Console.WriteLine(myDeserializedClass.response.games[0].name);
                Console.WriteLine(myDeserializedClass.response.games[0].img_logo_url);
                return myDeserializedClass;
            }
        }
        public class Player
        {
            public string steamid { get; set; }
            public int communityvisibilitystate { get; set; }
            public int profilestate { get; set; }
            public string personaname { get; set; }
            public string profileurl { get; set; }
            public string avatar { get; set; }
            public string avatarmedium { get; set; }
            public string avatarfull { get; set; }
            public string avatarhash { get; set; }
            public int lastlogoff { get; set; }
            public int personastate { get; set; }
            public string primaryclanid { get; set; }
            public int timecreated { get; set; }
            public int personastateflags { get; set; }
            public string loccountrycode { get; set; }
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Game
        {
            public int appid { get; set; }
            public string name { get; set; }
            public int playtime_2weeks { get; set; }
            public int playtime_forever { get; set; }
            public string img_icon_url { get; set; }
            public string img_logo_url { get; set; }
            public int playtime_windows_forever { get; set; }
            public int playtime_mac_forever { get; set; }
            public int playtime_linux_forever { get; set; }
        }

        public class Response
        {
            public List<Player> players { get; set; }
            public int total_count { get; set; }
            public List<Game> games { get; set; }
        }

        public class Root
        {
            public Response response { get; set; }
        }

    }
}

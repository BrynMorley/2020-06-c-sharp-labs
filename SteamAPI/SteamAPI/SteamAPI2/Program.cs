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

namespace lab_37_http_deserialise_to_json
{
    class Program
    {   
        static List<Player> players = new List<Player>();
        static Uri url = new Uri("https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=2901A4BCBA478FDD1D4226CECD80A1C7&steamids=76561198033967649");

        static void Main(string[] args)
        {
            GetPlayer();
            
        }

        static void GetPlayer()
        {
            using (var httpclient = new HttpClient())
            {
                var data = httpclient.GetStringAsync(url);
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data.Result);
                Console.WriteLine(myDeserializedClass.response.players[0].personaname);
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

        public class Response
        {
            public List<Player> players { get; set; }
        }

        public class Root
        {
            public Response response { get; set; }
        }

    }
}

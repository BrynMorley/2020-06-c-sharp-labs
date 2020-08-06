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

using SteamWebAPI2;
using SteamWebAPI2.Utilities;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Models;
using Steam.Models.SteamCommunity;
using System.Threading.Tasks;

namespace SteamAPI
{

    class Program
    {

        static SteamUser player;
        // factory to be used to generate various web interfaces
        static void Main(string[] args) {


            var webInterfaceFactory = new SteamWebInterfaceFactory("2901A4BCBA478FDD1D4226CECD80A1C7");
            // this will map to the ISteamUser endpoint
            // note that you have full control over HttpClient lifecycle here
            var steamInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());

            ulong brynSteamId = 76561198033967649;

             GetPlayerSummary(brynSteamId, steamInterface);

          
            
        }

        // this will map to ISteamUser/GetPlayerSummaries method in the Steam Web API
        // see PlayerSummaryResultContainer.cs for response documentation
        static async void GetPlayerSummary(ulong steamID, SteamUser steamInterface)
        {
            
            var playerSummaryResponse = await steamInterface.GetPlayerSummaryAsync(steamID);
            var playerSummaryData = playerSummaryResponse.Data;
            
           
            //player = JsonConvert.DeserializeObject<PlayerSummaryModel>(playerSummaryResponse);
            
            
        }

        // this will map to ISteamUser/GetFriendsListAsync method in the Steam Web API
        // see FriendListResultContainer.cs for response documentation
        static async void GetFriendsList(ulong steamID, SteamUser steamInterface)
        {

            var friendsListResponse = await steamInterface.GetFriendsListAsync(steamID);
            var friendsList = friendsListResponse.Data;
        }

    }

}



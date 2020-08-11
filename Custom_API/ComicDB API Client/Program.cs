using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json;

namespace ComicDB_API_Client
{
    class Program
    {
        
        static List<Hero> heroes = new List<Hero>();
        static Hero hero = new Hero();
        
        static List<Villain> villains = new List<Villain>();
        static Villain villain = new Villain();

        static List<Team> teams = new List<Team>();
        static Team team = new Team();

        static Uri url = new Uri("https://localhost:44380/api");
        static void Main(string[] args)
        {
            
            //GET
            GetAllHeroes();
            GetHero(1); 
            GetAllVillains();
            GetVillain(1); 
            GetAllTeams();
            GetTeam(1);

            //PUT
            //PutHero();
            //PutVillain();
            //PutTeam();

            //POST
            var newHero = new Hero();
            var newVillain= new Villain();
            var newTeam = new Team();

            PostHero(newHero);
            PostVillain(newVillain);
            PostTeam(newTeam);


            //DELETE
            int heroID = 1;
            int villainID = 1;
            int teamID = 1;

            DeleteHero(heroID);
            DeleteVillain(villainID);
            DeleteTeam(teamID);
        }

        //GET
        static async void GetAllHeroes() 
        {
            using (var httpClient = new HttpClient())
            {

                var data = await httpClient.GetStringAsync($"{url}/heroes");
                heroes = JsonConvert.DeserializeObject<List<Hero>>(data);

            }
        }
        static async void GetHero(int heroID) 
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{url}/heroes/{heroID}");
                hero = JsonConvert.DeserializeObject<Hero>(data);
            }
        }
        static async void GetAllVillains() 
        {
            using (var httpClient = new HttpClient())
            {

                var data = await httpClient.GetStringAsync($"{url}/villains");
                villains = JsonConvert.DeserializeObject<List<Villain>>(data);

            }
        }
        static async void GetVillain(int villainID) 
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{url}/villains/{villainID}");
                villain = JsonConvert.DeserializeObject<Villain>(data);
            }
        }
        static async void GetAllTeams() 
        {
            using (var httpClient = new HttpClient())
            {

                var data = await httpClient.GetStringAsync($"{url}/teams");
                teams = JsonConvert.DeserializeObject<List<Team>>(data);

            }
        }
        static async void GetTeam(int teamID)
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{url}/teams/{teamID}");
                team = JsonConvert.DeserializeObject<Team>(data);
            }
        }

        //PUT
        static void PutHero(int heroID) 
        {
            
        }
        static void PutVillain(int villainID) 
        { 
        
        }
        static void PutTeam(int teamID)
        { 
        
        }
        //POST
        static async void PostHero(Hero hero) 
        {
            string newHeroAsJson = JsonConvert.SerializeObject(hero);
            var httpContent = new StringContent(newHeroAsJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync($"{url}/heroes", httpContent);
                Console.WriteLine();
            }
        }
        static async void PostVillain(Villain villain)
        {
            string newVillainAsJson = JsonConvert.SerializeObject(villain);
            var httpContent = new StringContent(newVillainAsJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync($"{url}/villains", httpContent);
                Console.WriteLine();
            }
        }
        static async void PostTeam(Team team) 
        {
            string newTeamAsJson = JsonConvert.SerializeObject(team);
            var httpContent = new StringContent(newTeamAsJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync($"{url}/teams", httpContent);
                Console.WriteLine();
            }
        }
        //DELETE
        static async void DeleteHero(int heroID) 
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.DeleteAsync($"{url}/heros/{heroID}");
                if (httpResponse.IsSuccessStatusCode)
                { Console.WriteLine($"Record of id {heroID} deleted successfully"); }
                else
                {
                    Console.WriteLine($"Deletion of id {heroID} failed");
                }
            }
        }
        static async void DeleteVillain(int villainID) 
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.DeleteAsync($"{url}/villains/{villainID}");
                if (httpResponse.IsSuccessStatusCode)
                { Console.WriteLine($"Record of id {villainID} deleted successfully"); }
                else
                {
                    Console.WriteLine($"Deletion of id {villainID} failed");
                }
            }
        }
        static async void DeleteTeam(int teamID)
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.DeleteAsync($"{url}/teams/{teamID}");
                if (httpResponse.IsSuccessStatusCode)
                { Console.WriteLine($"Record of id {teamID} deleted successfully"); }
                else
                {
                    Console.WriteLine($"Deletion of id {teamID} failed");
                }
            }
        }
    }
}

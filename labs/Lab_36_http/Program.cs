using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

namespace Lab_36_http
{
    class Program
    {
        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos/1");
        static Uri url2 = new Uri("https://www.bbc.co.uk");
        static void Main(string[] args)
        {
            //GetDataUsingWebClient();
            // GetPageUsingWebClient();
            // GetPageUsingWebRequest();

            //GetDataUsingHttpClient();

            User user = new User().deserialise(url);


            Console.WriteLine(user.Title);
        }

        static void GetDataUsingWebClient()
        {
            var webclient = new WebClient { Proxy = null };
            var data = webclient.DownloadString(url);
            Console.WriteLine(data);
        }
        static void GetPageUsingWebClient()
        {
            var webclient = new WebClient { Proxy = null };
            webclient.DownloadFile(url2,"bbcWebPage.html");
            Process.Start(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe", "bbcWebPage.html");
        }

        static void GetPageUsingWebRequest()
        {
            var bbcPageRequest = WebRequest.Create(url2);
            bbcPageRequest.Proxy = null;

            var bbcPageResponse = bbcPageRequest.GetResponse();

            Console.WriteLine("\n\nBBC page has arrived\n");
            Console.WriteLine(bbcPageResponse.ContentType);
            Console.WriteLine(bbcPageResponse.ContentLength);

            Console.WriteLine("Getting page Header Information");
            var pageRequestHeaders = bbcPageResponse.Headers.AllKeys;
            foreach (var key in pageRequestHeaders)
            {
                Console.WriteLine($"{key}");

                //foreach (var value in bbcPageRequest.Headers.GetValues(key))
                //{
                //    Console.WriteLine($"\t{value}");
                //}
            }
            
        }
        static void GetDataUsingHttpClient()
        {
            var httpClient = new HttpClient();
            var httpResponse = httpClient.GetStringAsync(url);
            var data = httpResponse.Result;
            Console.WriteLine("\n\nGetting data using HTTPClient\n");
            Console.WriteLine(data);

            var json = JObject.Parse(data);

            Console.WriteLine(json["userID"]);
            Console.WriteLine(json["id"]);
            Console.WriteLine(json["title"]);
            Console.WriteLine(json["completed"]);
        }
    }


    class User
    {
       
        public int UserId{ get; set;}
        public  int ID { get; set; }
        public  string Title { get; set; }
        public  bool Completed { get; set; }

       public User deserialise(Uri url)
        { 
        var httpClient = new HttpClient();
            var httpResponse = httpClient.GetStringAsync(url);
            var data = httpResponse.Result;
            User user = JsonConvert.DeserializeObject<User>(data);
            return user;

        }
    }
}

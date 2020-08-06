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

namespace lab_37_http_deserialise_to_json
{
    class Program
    {
        static List<ToDo> todos = new List<ToDo>();
        static List<ToDo> todosAsync = new List<ToDo>();
        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos");
        static void Main(string[] args)
        {
            GetTodos();
            Console.WriteLine(todos.Count);
            todos.ForEach(item => Console.WriteLine($"ID: {item.ID,-10} User: {item.UserId,-15}" + $"Title: {item.Title}"));

            GetTodosAsync();
            Thread.Sleep(1000);

            Console.WriteLine(todosAsync.Count);
            todosAsync.ForEach(item => Console.WriteLine($"ID: {item.ID,-10} User: {item.UserId,-15}" + $"Title: {item.Title}"));
            
        }

        static void GetTodos()
        {
            using (var httpclient = new HttpClient())
            {
                var data = httpclient.GetStringAsync(url);
                todos = JsonConvert.DeserializeObject<List<ToDo>>(data.Result);

            }
        }
        static async void GetTodosAsync()
        {
            using (var httpclient = new HttpClient())
            {
                var data = await httpclient.GetStringAsync(url);
                todosAsync = JsonConvert.DeserializeObject<List<ToDo>>(data);

            }
        }
        class ToDo
        {

            public int UserId { get; set; }
            public int ID { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
        }
    }
}

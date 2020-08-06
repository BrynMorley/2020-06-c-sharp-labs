using lab_38_northwind_api_client.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;

namespace lab_38_northwind_api_client
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();
        static Uri url = new Uri("https://localhost:44320/api/Customers");
        static Uri url2 = new Uri("https://localhost:44320/api/Customers/ALFKI");
        static void Main(string[] args)
        {

            Thread.Sleep(10000);
            //Async Get All Customers
            GetAllCustomers();

            //Async Get One 
            GetOneCustomer();

            Thread.Sleep(10000);
                Console.WriteLine(customers);
                Console.WriteLine(customer);

        }
        static async void GetAllCustomers()
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(url);
                customers = JsonConvert.DeserializeObject<List<Customer>>(data);

            }
        }
        static async void GetOneCustomer()
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(url2);
                customer = JsonConvert.DeserializeObject<Customer>(data);

            }
        }
    }
}

using lab_38_northwind_api_client.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace lab_38_northwind_api_client
{
    class Program
    {
        private static Random random = new Random();
        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();
        static Uri url = new Uri("https://localhost:44320/api/Customers");
        
        static void Main(string[] args)
        {

            Thread.Sleep(10000);
          

            // Post a customer
            var newCustomer = new Customer()
            {
                CustomerId = RandomString(),
                ContactName = "Phil",
                CompanyName = "My company",
                City = "London",
                Country = "UK"
            };

            PostCustomerAsync(newCustomer);
            //Async Get All Customers
            GetAllCustomers();

            //Async Get One 
            GetOneCustomer("ALFKI");

            Thread.Sleep(2000);
                Console.WriteLine(customers);
                Console.WriteLine(customer);

            // DeleteCustomer(newCustomer.CustomerId);
            //DeleteCustomerAsync(newCustomer.CustomerId);
         DeleteCustomerAsyncTask(newCustomer.CustomerId).Wait();
        }
        static async void GetAllCustomers()
        {
            using (var httpClient = new HttpClient())
            {
                
                var data = await httpClient.GetStringAsync(url);
                customers = JsonConvert.DeserializeObject<List<Customer>>(data);

            }
        }
        static async void GetOneCustomer(string customerID)
        {
           
            using (var httpClient = new HttpClient())
            {
                
                var data = await httpClient.GetStringAsync($"{url}/{customerID}");
                
                    customer = JsonConvert.DeserializeObject<Customer>(data);
               

            }
        }

        static async void PostCustomerAsync(Customer customer)
        {
           
                string newCustomerAsJson = JsonConvert.SerializeObject(customer);
                var httpContent = new StringContent(newCustomerAsJson);

                httpContent.Headers.ContentType.MediaType = "application/json";
                httpContent.Headers.ContentType.CharSet = "UTF-8";

                using (var httpClient = new HttpClient())
                {
                    var httpResponse = await httpClient.PostAsync(url, httpContent);
                    Console.WriteLine();
                }
            
        }   

        static void DeleteCustomer(string customerID)
        {
            using (var httpClient= new HttpClient())
            {
                var httpResponse = httpClient.DeleteAsync($"{url}/{customerID}");
                if(httpResponse.Result.IsSuccessStatusCode)
                { Console.WriteLine($"Record of id {customerID} deleted successfully"); }
                else
                {
                    Console.WriteLine($"Deletion of id {customerID} failed");
                }
            }
        }
        static async void DeleteCustomerAsync(string customerID)
        {
            using (var httpClient= new HttpClient())
            {
                var httpResponse =await httpClient.DeleteAsync($"{url}/{customerID}");
                if(httpResponse.IsSuccessStatusCode)
                { Console.WriteLine($"Record of id {customerID} deleted successfully"); }
                else
                {
                    Console.WriteLine($"Deletion of id {customerID} failed");
                }
            }
        }

        static async Task<HttpResponseMessage> DeleteCustomerAsyncTask(string customerID)
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.DeleteAsync($"{url}/{customerID}");

                if (httpResponse.IsSuccessStatusCode)
                { 
                    Console.WriteLine($"Record of id {customerID} deleted successfully");
                    return httpResponse;
                }
                else
                {
                    Console.WriteLine($"Deletion of id {customerID} failed");
                    return null;
                }
            }
        }
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());
           
            
        }
    }

}

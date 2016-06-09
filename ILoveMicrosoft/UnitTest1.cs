using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotDolls.Controllers;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ILoveMicrosoft
{
    [TestClass]
    public class UnitTest1
    {
        private const string URL = "https://localhost:5000/api/Geek";

        [TestMethod]
        public void TestMethod1()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("").Result;  // Blocking call!

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStreamAsync().Result;
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
 }

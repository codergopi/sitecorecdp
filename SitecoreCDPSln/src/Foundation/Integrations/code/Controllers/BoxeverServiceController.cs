using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Web.Http;

namespace SitecoreCDP.Foundation.Integrations.Controllers
{
    public class BoxeverServiceController : ApiController
    {
        public string API_KEY_ID { get; set; }
        public string API_KEY_SECRET { get; set; }
        public HttpClient client { get; set; }
        public BoxeverServiceController()
        {
            API_KEY_ID = "pqsmpg99hzkfe1za3socuk3x1d6cvv69";
            API_KEY_SECRET = "iEArOpePHuUpvqA412TOzjNTai0MjDvj";
            client = new HttpClient
            {
                BaseAddress = new Uri("https://api.boxever.com/v2")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string key = API_KEY_ID + ":" + API_KEY_SECRET;

            var plainTextBytes = Encoding.UTF8.GetBytes(key);
            string val = Convert.ToBase64String(plainTextBytes);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + val);
        }
        [Route("api/getguestdata/{id}")]
        public string GetGuestData(string id)
        {
            var guestapi = "/guests/";
            if (client != null)
            {
                var response = client.GetAsync($"{guestapi}{id}").Result;
                string content = string.Empty;
                using (StreamReader stream = new StreamReader(response.Content.ReadAsStreamAsync().Result, true))
                {
                    content = stream.ReadToEnd();
                }
                //Company myDeserializedClass = JsonSerializer.Deserialize<Company>(content);
                return response.ToString();
            }
            return null;

        }
    }
}

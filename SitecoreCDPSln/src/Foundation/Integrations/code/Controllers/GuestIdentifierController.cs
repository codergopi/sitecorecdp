using SitecoreCDP.Foundation.Integrations.Models;
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
using System.Web.Routing;

namespace SitecoreCDP.Foundation.Integrations.Controllers
{
    public class GuestIdentifierController : ApiController
    {
        [Route("api/identifyguest/{id}")]
        public GuestInfo GetGuestData(string id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.boxever.com/");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            string API_KEY_ID = "pqsmpg99hzkfe1za3socuk3x1d6cvv69";
            string API_KEY_SECRET = "iEArOpePHuUpvqA412TOzjNTai0MjDvj";

            string key = API_KEY_ID + ":" + API_KEY_SECRET;

            var plainTextBytes = Encoding.UTF8.GetBytes(key);
            string val = Convert.ToBase64String(plainTextBytes);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + val);

            var response = client.GetAsync("/v2/guests/" + id).Result;

            string content = string.Empty;
            using (StreamReader stream = new StreamReader(response.Content.ReadAsStreamAsync().Result, true))
            {
                content = stream.ReadToEnd();
            }

            GuestInfo result = JsonSerializer.Deserialize<GuestInfo>(content);

            return result;
        }
    }
}

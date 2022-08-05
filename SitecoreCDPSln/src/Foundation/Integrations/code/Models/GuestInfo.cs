using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace SitecoreCDP.Foundation.Integrations.Models
{
    public class GuestInfo
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
        [JsonPropertyName("ref")]
        public string Ref { get; set; }
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
        [JsonPropertyName("modifiedAt")]
        public string ModifiedAt { get; set; }
        [JsonPropertyName("firstSeen")]
        public string FirstSeen { get; set; }
        [JsonPropertyName("lastSeen")]
        public string LastSeen { get; set; }
        [JsonPropertyName("guestType")]
        public string GuestType { get; set; }
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [JsonPropertyName("identityStatus")]
        public string IdentityStatus { get; set; }

    }
}
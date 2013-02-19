namespace Hohashi.AddressValidator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web;

    using Newtonsoft.Json;

    public class AddressValidator
    {
        public AddressValidator(string apiUrl, string authId, string authToken)
        {
            this.ApiUrl = apiUrl;
            this.AuthenticationId = HttpUtility.UrlEncode(authId);
            this.AuthenticationToken = HttpUtility.UrlEncode(authToken);
        }

        private string ApiUrl { get; set; }

        private string AuthenticationId { get; set; }

        private string AuthenticationToken { get; set; }

        public List<CandidateAddress> Validate(Address address)
        {
            var addresslist = new List<Address> { address };

            string jsonAddress = JsonConvert.SerializeObject(addresslist);

            HttpContent content = new StringContent(jsonAddress);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.ApiUrl);

                string requestUri = "street-address/" + "?auth-id=" + this.AuthenticationId + "&auth-token="
                                    + this.AuthenticationToken;

                HttpResponseMessage response = client.PostAsync(requestUri, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    var candidates =
                        JsonConvert.DeserializeObject<CandidateAddress[]>(response.Content.ReadAsStringAsync().Result);
                    return candidates.ToList();
                }

                return null;
            }
        }
    }
}
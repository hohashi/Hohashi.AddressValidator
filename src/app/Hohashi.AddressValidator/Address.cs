namespace Hohashi.AddressValidator
{
    using Newtonsoft.Json;

    public class Address
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zip { get; set; }
    }
}
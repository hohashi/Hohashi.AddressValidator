namespace Hohashi.AddressValidator
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    [Table("Component")]
    public class Component
    {
        [JsonIgnore]
        public virtual int ComponentId { get; set; }

        [JsonProperty("urbanization")]
        public string Urbanization { get; set; }

        [JsonProperty("primary_number")]
        public string PrimaryNumber { get; set; }

        [JsonProperty("street_name")]
        public string StreetName { get; set; }

        [JsonProperty("street_predirection")]
        public string StreetPredirection { get; set; }

        [JsonProperty("street_postdirection")]
        public string StreetPostdirection { get; set; }

        [JsonProperty("street_suffix")]
        public string StreetSuffix { get; set; }

        [JsonProperty("secondary_number")]
        public string SecondaryNumber { get; set; }

        [JsonProperty("secondary_designator")]
        public string SecondaryDesignator { get; set; }

        [JsonProperty("pmb_designator")]
        public string PmbDesignator { get; set; }

        [JsonProperty("pmb_number")]
        public string PmbNumber { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("state_abbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("plus4_code")]
        public string Plus4Code { get; set; }

        [JsonProperty("delivery_point")]
        public string DeliveryPoint { get; set; }

        [JsonProperty("delivery_point_check_digit")]
        public string DeliveryPointCheckDigit { get; set; }
    }
}
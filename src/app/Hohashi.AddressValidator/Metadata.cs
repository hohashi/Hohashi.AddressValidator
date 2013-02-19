namespace Hohashi.AddressValidator
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    [Table("Metadata")]
    public class Metadata
    {
        [Key]
        [JsonIgnore]
        public int MetadataId { get; set; }

        [JsonProperty("record_type")]
        public string RecordType { get; set; }

        [JsonProperty("county_fips")]
        public string CountyFips { get; set; }

        [JsonProperty("county_name")]
        public string CountyName { get; set; }

        [JsonProperty("carrier_route")]
        public string CarrierRoute { get; set; }

        [JsonProperty("congressional_district")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("building_default_indicator")]
        public string BuildingDefaultIndicator { get; set; }

        [JsonProperty("rdi")]
        public string Rdi { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }
    }
}
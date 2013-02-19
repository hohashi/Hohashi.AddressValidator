namespace Hohashi.AddressValidator
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    [Table("Analysis")]
    public class Analysis
    {
        [Key]
        [JsonIgnore]
        public int AnalysisId { get; set; }

        [JsonProperty("dpv_match_code")]
        public string DpvMatchCode { get; set; }

        [JsonProperty("dpv_footnotes")]
        public string DpvFootnotes { get; set; }

        [JsonProperty("dpv_cmra")]
        public string DpvCmra { get; set; }

        [JsonProperty("dpv_vacant")]
        public string DpvVacant { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("ews_match")]
        public bool EwsMatch { get; set; }

        [JsonProperty("footnotes")]
        public string Footnotes { get; set; }

        [JsonProperty("lacslink_code")]
        public string LacsLinkCode { get; set; }

        [JsonProperty("lacslink_indicator")]
        public string LacsLinkIndicator { get; set; }
    }
}
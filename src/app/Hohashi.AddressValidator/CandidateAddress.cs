namespace Hohashi.AddressValidator
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Newtonsoft.Json;

    [Table("CandidateAddress")]
    public class CandidateAddress
    {
        [Key]
        [JsonIgnore]
        public virtual int CandidateAddressId { get; set; }

        [JsonProperty("input_index")]
        public virtual int InputIndex { get; set; }

        [JsonProperty("candidate_index")]
        public virtual int CandidateIndex { get; set; }

        [JsonProperty("addressee")]
        public virtual int Addressee { get; set; }

        [JsonProperty("delivery_line_1")]
        public virtual string DeliveryLine1 { get; set; }

        [JsonProperty("delivery_line_2")]
        public virtual string DeliveryLine2 { get; set; }

        [JsonProperty("last_line")]
        public virtual string LastLine { get; set; }

        [JsonProperty("delivery_point_barcode")]
        public virtual string DeliveryPointBarcode { get; set; }

        [JsonIgnore]
        public virtual int ComponentId { get; set; }

        [JsonProperty("components")]
        public virtual Component Component { get; set; }

        [JsonIgnore]
        public virtual int MetadataId { get; set; }

        [JsonProperty("metadata")]
        public virtual Metadata Metadata { get; set; }

        [JsonIgnore]
        public virtual int AnalysisId { get; set; }

        [JsonProperty("analysis")]
        public virtual Analysis Analysis { get; set; }
    }
}
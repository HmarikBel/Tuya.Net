using Newtonsoft.Json;

namespace Tuya.Net.Data
{
    /// <summary>
    /// Tuya Device Specification (function or status) DTO.
    /// </summary>
    public class Specification
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the data point ID.
        /// </summary>
        [JsonProperty("dp_id", NullValueHandling = NullValueHandling.Ignore)]
        public int DpId { get; set; }

        /// <summary>
        /// Gets or sets the specification type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the specification values.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string? Values { get; set; }
    }
}

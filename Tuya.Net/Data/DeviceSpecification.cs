using Newtonsoft.Json;

namespace Tuya.Net.Data
{
    /// <summary>
    /// Tuya Device Specification DTO.
    /// </summary>
    public class DeviceSpecification
    {
        /// <summary>
        /// Gets or sets the device category.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets the device function specifications.
        /// </summary>
        [JsonProperty("functions", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Specification>? Functions { get; set; }

        /// <summary>
        /// Gets or sets the device status specifications.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Specification>? Status { get; set; }
    }
}

using Newtonsoft.Json;

namespace Tuya.Net.Data;

/// <summary>
/// Instruction info.
/// </summary>
public class ReportLog
{
    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; } = "";

    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    [JsonProperty("eventTime")]
    public long EventUnixTimeMilliseconds { get; set; }

    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    [JsonIgnore]
    public DateTime EventTime
    {
        get => DateTimeOffset.FromUnixTimeMilliseconds(EventUnixTimeMilliseconds).DateTime;
        set => EventUnixTimeMilliseconds = new DateTimeOffset(value).ToUnixTimeMilliseconds();
    }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}
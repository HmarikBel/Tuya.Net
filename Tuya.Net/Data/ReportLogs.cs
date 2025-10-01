using Newtonsoft.Json;

namespace Tuya.Net.Data;

/// <summary>
/// Report Logs.
/// </summary>
public class ReportLogs
{
    [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
    public string DeviceId { get; set; } = "";

    [JsonProperty("deviceId", NullValueHandling = NullValueHandling.Ignore)]
    public string DeviceIdV21
    {
        set => DeviceId = value;
        get => DeviceId;
    }

    [JsonProperty("has_more")]
    public bool HasMore { get; set; }

    [JsonProperty("hasMore")]
    public bool HasMoreV21
    {
        set => HasMore = value;
        get => HasMore;
    }

    [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
    public ReportLog[]? Logs { get; set; }

    [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
    public int Total { get; set; }
}
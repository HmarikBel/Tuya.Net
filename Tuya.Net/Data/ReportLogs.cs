using Newtonsoft.Json;

namespace Tuya.Net.Data;

/// <summary>
/// Report Logs.
/// </summary>
public class ReportLogs
{
    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime? Date { get; set; }

    [JsonProperty("hasMore")]
    public bool HasMore { get; set; }

    [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
    public ReportLog[]? Logs { get; set; }
}
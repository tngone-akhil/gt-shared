namespace TNG.Shared.Lib.Mongo.Models;
public class KpiResponse
{
    public long TotalUserCount { get; set; }
    public long ClientCount { get; set; }
    public long AdminCount { get; set; }
    public long PendingTaskCount { get; set; }
    public long CompletedTaskCount { get; set; }
    public long TotalTaskCount { get; set; }
    public decimal PerformanceScore{get;set;}
}
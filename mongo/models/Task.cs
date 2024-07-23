using MongoDB.Bson.Serialization.Attributes;
namespace TNG.Shared.Lib.Mongo.Models;
public class Tasks
{
    public string TaskId{get;set;}
    public string Concept { get; set; }
    public string Location { get; set; }
    public string MaintenanceWork { get; set; }
    public string Poc { get; set; }
    public string Responsibility { get; set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateOnly ConcernRaisedDate { get; set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public TimeOnly RaisedTime { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
    public string Aging { get; set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateOnly ApprovedQuotationDate { get; set; }
    public string ActionPlan { get; set; }
    public string Remarks { get; set; }
    public double TotalHours{get;set;}
}
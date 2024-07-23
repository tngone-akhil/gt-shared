namespace TNG.Shared.Lib.Mongo.Models;
public class KpiFilter
{
    public DateOnly ToDate{get;set;}
    public DateOnly FromDate{get;set;}
    public string Location{get;set;}
}
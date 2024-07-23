using System.ComponentModel.DataAnnotations;
namespace TNG.Shared.Lib.Mongo.Models;
public class TaskCreationRequest
{
    [Required(ErrorMessage ="Concept cannot be null or empty")]
    public string Concept{get;set;}
     [Required(ErrorMessage ="Location cannot be null or empty")]
    public string Location{get;set;}
     [Required(ErrorMessage ="Maintenance Work cannot be null or empty")]
    public string MaintenanceWork{get;set;}
     [Required(ErrorMessage ="Person of contact in store name cannot be null or empty")]
    public string Poc{get;set;}
     [Required(ErrorMessage ="Responsibility cannot be null or empty")]
    public string Responsibility{get;set;}
     [Required(ErrorMessage ="Concern Raised Date cannot be null or empty")]
    public DateOnly ConcernRaisedDate{get;set;}
     [Required(ErrorMessage ="Raised Time cannot be null or empty")]
    public TimeOnly RaisedTime{get;set;}
     [Required(ErrorMessage ="Priority cannot be null or empty")]
    public string Priority{get;set;}
     [Required(ErrorMessage ="Status cannot be null or empty")]
    public string Status{get;set;}
     [Required(ErrorMessage ="Aging cannot be null or empty")]
    public string Aging{get;set;}
     [Required(ErrorMessage ="Approved Quotation Date cannot be null or empty")]
    public DateOnly ApprovedQuotationDate{get;set;}
     [Required(ErrorMessage ="Action Plan cannot be null or empty")]
    public string ActionPlan{get;set;}

}
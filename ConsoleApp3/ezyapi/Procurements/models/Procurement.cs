using System.ComponentModel.DataAnnotations;
using ConsoleApp3.ezyapi.Constants;
using ConsoleApp3.ezyapi.Contracts;

namespace ConsoleApp3.ezyapi.Procurements.Models;

public class Procurement : IUpdatableModel
{
    [Required][MaxLength(3)] public string? ActivityCode { get; set; }
    [Required][MaxLength(30)] public string? ActivityName { get; set; }
    public DateTime? DateCreation { get; set; }
    public DateTime? DateLastUpdate { get; set; }
    [Required][MaxLength(50)] public string? UniqueProcurementID { get; set; }
    [MaxLength(30)] public string? SupplierOrderNumberDO { get; set; }
    [MaxLength(3)] public string? OwnerCode { get; set; }
    [MaxLength(3)] public string? ProcurementTypeCode { get; set; }
    [MaxLength(14)] public string? ProcurementGroup { get; set; }
    [MaxLength(80)] public string? ProcurementGroupDescription { get; set; }
    [MaxLength(14)] public string? SupplierCode { get; set; }
    [MaxLength(80)] public string? SupplierName { get; set; }
    [Required] public DateTime? ExpectedReceiptDate { get; set; }
    [MaxLength(200)] public string? CustomField1 { get; set; }
    [MaxLength(200)] public string? CustomField2 { get; set; }
    [MaxLength(256)] public string? CustomField3 { get; set; }
    [MaxLength(256)] public string? CustomField4 { get; set; }
    [MaxLength(256)] public string? CustomField5 { get; set; }
    [MaxLength(256)] public string? CustomField6 { get; set; }
    [MaxLength(256)] public string? CustomField7 { get; set; }
    [MaxLength(256)] public string? CustomField8 { get; set; }

    [Required] public ICollection<ProcurementEntry> ProcurementEntries { get; set; } = new List<ProcurementEntry>();

    public string Id => !string.IsNullOrEmpty(UniqueProcurementID) ? UniqueProcurementID : Globals.NullString;
}

using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace ConsoleApp3.ezyapi.Procurements.Models;

public class ProcurementEntry
{
    public long Id { get; set; }

    [SwaggerSchema(description: "Code de l'activité", Title = "CODACTI")]
    [MaxLength(3)]
    public string? ActivityCode { get; set; }

    [SwaggerSchema(description: "", Title = "DATECREATION")]
    public DateTime DateCreation { get; set; }

    [SwaggerSchema(description: "", Title = "DATELASTUPDATE")]
    public DateTime DateLastUpdate { get; set; }

    [SwaggerSchema(description: "Identifiant unique de l'approvisionnement", Title = "IDRECEP")]
    [MaxLength(50)]
    public string UniqueProcurementID { get; set; }

    [SwaggerSchema(description: "N° de ligne de commande", Title = "IDLIGNE")]
    [MaxLength(35)]
    [Required]
    public string? LineID { get; set; }

    [SwaggerSchema(description: "Référence article", Title = "CODARTI")]
    [MaxLength(17)]
    [Required]
    public string? ArticleReference { get; set; }

    [SwaggerSchema(description: "Quantité attendue sur la réception", Title = "QTTEATT")]
    [Required]
    public int? ExpectedQuantity { get; set; }

    [SwaggerSchema(description: "N° de commande fournisseur chez le DO", Title = "COMFOUR")]
    [MaxLength(30)]
    public string? SupplierOrderNumberDO { get; set; }

    [SwaggerSchema(description: "Unité d'œuvre de la réception", Title = "UNITREC")]
    [MaxLength(3)]
    public string? ReceptionUnitOfMeasure { get; set; }

    [SwaggerSchema(description: "Prix attaché a l'article a la réception", Title = "PRIXREC")]
    public int? ArticlePriceAtReception { get; set; }

    [SwaggerSchema(description: "N° de lot attendu pour la ligne", Title = "ARTILOT")]
    [MaxLength(50)]
    public string? ExpectedLotNumber { get; set; }

    [SwaggerSchema(description: "Date annoncée pour l'article", Title = "DATEART")]
    public DateTime? AnnouncedArticleDate { get; set; }

    [SwaggerSchema(description: "Date limite d'expédition de l'article", Title = "DFVARTI")]
    public DateTime? ArticleShippingDeadline { get; set; }

    [SwaggerSchema(description: "PCB de l'article", Title = "PCBARTI")]
    public int? ArticlePCB { get; set; }

    [SwaggerSchema(description: "SPCB de l'article", Title = "SPCARTI")]
    public int? ArticleSPCB { get; set; }

    [SwaggerSchema(description: "Message à la ligne ", Title = "MESGLIG")]
    [MaxLength(30)]
    public string? LineMessage { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF1")]
    [MaxLength(200)]
    public string? CustomField1 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF2")]
    [MaxLength(200)]
    public string? CustomField2 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF3")]
    [MaxLength(256)]
    public string? CustomField3 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF4")]
    [MaxLength(256)]
    public string? CustomField4 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF5")]
    [MaxLength(256)]
    public string? CustomField5 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF6")]
    [MaxLength(256)]
    public string? CustomField6 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF7")]
    [MaxLength(256)]
    public string? CustomField7 { get; set; }

    [SwaggerSchema(description: "Champ spécifique disponible", Title = "SPECIF8")]
    [MaxLength(256)]
    public string? CustomField8 { get; set; }

    [SwaggerSchema(description: "", Title = "DATEPROCESSED")]
    public DateTime? DateProcessed { get; set; }
}

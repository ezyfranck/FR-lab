using ConsoleApp3.ezyapi.Constants;
using ConsoleApp3.ezyapi.Contracts;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace ConsoleApp3.ezyapi.Partner.models
{
    public class Customer : IUpdatableModel
    {
        [SwaggerSchema(description: "Code de l'activité", Title = "CODACTI")]
        [MaxLength(3)]
        [Required]
        public string? ActivityCode { get; set; }

        [SwaggerSchema(Title = "DATECREATION")]
        public DateTime DateCreation { get; set; }

        [SwaggerSchema(Title = "DATELASTUPDATE")]
        public DateTime DateLastUpdate { get; set; }

        [SwaggerSchema(description: "Nom de l'activité", Title = "LIBACTI")]
        [MaxLength(30)]
        [Required]
        public string? ActivityName { get; set; }

        [SwaggerSchema(description: "Code destinataire", Title = "CODDEST")]
        [MaxLength(13)]
        [Required]
        public string? RecipientCode { get; set; }

        [SwaggerSchema(description: "Libellé destinataire - Nom complet du destinataire.", Title = "DESTNOM")]
        [MaxLength(30)]
        public string? RecipientName { get; set; }

        [SwaggerSchema(description: "Top transfert - Indique si le destinataire est configuré pour des transferts.",
            Title = "TRANSFERTS")]
        public bool? TopTransferts { get; set; }

        [SwaggerSchema(description: "Distribution channel code - Code associé au canal de distribution du destinataire.",
            Title = "DESTDISTRIBUTION")]
        [MaxLength(3)]
        public string? DistributionChannelCode { get; set; }

        [SwaggerSchema(description: "Region code - Code de la région attribuée au destinataire.", Title = "DESTREGION")]
        [MaxLength(3)]
        public string? RecipientRegionCode { get; set; }

        [SwaggerSchema(description: "Bank holiday group code - Code du groupe de jours fériés associé au destinataire.",
            Title = "DESTHOLIDAY")]
        [MaxLength(3)]
        public string? BankHolidayGroupCode { get; set; }

        [SwaggerSchema(
            description: "Il existe un contrat date concernant la date d'ordonnancement minimum avec le destinataire.",
            Title = "DATEORDOMIN")]
        public bool? MinSchedulingDateContractExists { get; set; }

        [SwaggerSchema(
            description: "Il existe un contrat date concernant la date d'ordonnancement supérieure avec le destinataire.",
            Title = "DATEORDOSUP")]
        public bool? MaxSchedulingDateContractExists { get; set; }

        [SwaggerSchema(description: "Manquants - possibilité de générer un reliquat en admin. Par défaut TRUE",
            Title = "RLQMANUAL")]
        public bool? IsResidualStockManagementManual { get; set; }

        [SwaggerSchema(description: "Manquants - reliquat automatique. Par défaut FALSE", Title = "RLQAUTO")]
        public bool? IsResidualStockManagementAuto { get; set; }

        [SwaggerSchema(description: "Solder la préparation manuellement. Par défaut TRUE", Title = "SOLDEMANUAL")]
        public bool? IsManuallyBalance { get; set; }

        [SwaggerSchema(description: "Solder la préparation automatiquement. Par défaut TRUE", Title = "SOLDEAUTO")]
        public bool? IsAutomaticallyBalance { get; set; }

        [SwaggerSchema(description: "Solde à la validation du dernier prélèvement. Par défaut FALSE",
            Title = "SOLDELASTPICK")]
        public bool? IsSoldeLastpick { get; set; }

        [SwaggerSchema(description: "Destinataire intermédiaire. Par défaut FALSE", Title = "INTERMEDIARY")]
        public bool? IsIntermediary { get; set; }

        [SwaggerSchema(description: "Livraison globalisée. Par défaut FALSE", Title = "INTERNAL")]
        public bool? IsInternal { get; set; }

        [SwaggerSchema(description: "Allocated RHDs - Indique si des RHD (Ressources Humaines Déléguées) sont alloués.",
            Title = "COMPTEAGRES")]
        public bool? IsCompteagres { get; set; }

        [SwaggerSchema(description: "Consignee address 1 - Première ligne de l'adresse du destinataire.",
            Title = "DESTADR1")]
        [MaxLength(30)]
        public string? RecipientAddress1 { get; set; }

        [SwaggerSchema(description: "Consignee address 2 - Deuxième ligne de l'adresse du destinataire.",
            Title = "DESTADR2")]
        [MaxLength(30)]
        public string? RecipientAddress2 { get; set; }

        [SwaggerSchema(
            description: "Consignee address 3 - Troisième ligne de l'adresse du destinataire (Code postal + ville).",
            Title = "DESTCPOS")]
        [MaxLength(9)]
        public string? RecipientPostalCode { get; set; }

        [SwaggerSchema(
            description:
            "Consignee address 4 - Quatrième ligne de l'adresse du destinataire (Division territoriale + Suppays + Nompays).",
            Title = "DESTVILL")]
        [MaxLength(20)]
        public string? RecipientCity { get; set; }

        [SwaggerSchema(
            description: "Consignee address 5 - Cinquième ligne de l'adresse du destinataire (Division territoriale).",
            Title = "DIVISIONTERRITORIALE")]
        [MaxLength(9)]
        public string? RecipientState { get; set; }

        [SwaggerSchema(description: "Consignee address 6 - Sixième ligne de l'adresse du destinataire (Suppays).",
            Title = "SUPPAYS")]
        [MaxLength(3)]
        public string? RecipientCountry { get; set; }

        [SwaggerSchema(description: "Consignee address 7 - Septième ligne de l'adresse du destinataire (Nompays).",
            Title = "NOMPAYS")]
        [MaxLength(16)]
        public string? RecipientCountryName { get; set; }

        [SwaggerSchema(description: "Consignee telephone - Numéro de téléphone du destinataire.", Title = "DESTTEL")]
        [MaxLength(15)]
        public string? RecipientPhone { get; set; }

        [SwaggerSchema(description: "Consignee fax - Numéro de fax du destinataire.", Title = "DESTFAX")]
        [MaxLength(15)]
        public string? RecipientFax { get; set; }

        [SwaggerSchema(description: "Consignee other number - Autre numéro de contact du destinataire.",
            Title = "DESTTEL2")]
        [MaxLength(15)]
        public string? RecipientPhone2 { get; set; }

        [SwaggerSchema(description: "Comment - Commentaire associé au destinataire.", Title = "DESTCOM")]
        [MaxLength(70)]
        public string? RecipientComment { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF1")]
        [MaxLength(200)]
        public string? CustomField1 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF2")]
        [MaxLength(200)]
        public string? CustomField2 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF3")]
        [MaxLength(200)]
        public string? CustomField3 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF4")]
        [MaxLength(200)]
        public string? CustomField4 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF5")]
        [MaxLength(200)]
        public string? CustomField5 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF6")]
        [MaxLength(200)]
        public string? CustomField6 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF7")]
        public int? CustomField7 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF8")]
        public int? CustomField8 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF9")]
        public int? CustomField9 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF10")]
        public int? CustomField10 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF11")]
        public DateTime? CustomField11 { get; set; }

        [SwaggerSchema(description: "Champ spécifique", Title = "SPECIF12")]
        public DateTime? CustomField12 { get; set; }

        public string Id => !string.IsNullOrEmpty(RecipientCode) ? RecipientCode : Globals.NullString;
    }
}

using ConsoleApp3.ezyapi.Constants;
using ConsoleApp3.ezyapi.Contracts;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3.ezyapi.Product.models
{

    public class Barcode
    {
        [Required][MaxLength(17)] public string? Code { get; set; }
        public bool? IsPrimary { get; set; }
        [MaxLength(17)] public string BarcodeUnit { get; set; } = "UVC";
        public int BarcodeQuantity { get; set; } = 1;

        public string Id => !string.IsNullOrEmpty(Code) ? Code : Globals.NullString;
    }
    public class Article : IUpdatableModel
    {
        [Required][MaxLength(3)] public string? ActivityCode { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateLastUpdated { get; set; }
        [Required][MaxLength(30)] public string? ActivityName { get; set; }
        [Required][MaxLength(17)] public string? ArticleReference { get; set; }
        [Required][MaxLength(60)] public string? LongArticleDescription { get; set; }
        [Required][MaxLength(30)] public string? ShortArticleDescription { get; set; }
        [MaxLength(30)] public string? DOReferenceCode { get; set; }
        public bool NomenclatureManaged { get; set; } = false;
        public int ArticleType { get; set; } = 0;
        [Required] public int? NetWeightPerUVC { get; set; } = 0;
        public int? GrossWeightPerUVC { get; set; } = 0;
        public int? LengthPerUVC { get; set; } = 0;
        public int? WidthPerUVC { get; set; } = 0;
        public int? HeightPerUVC { get; set; } = 0;
        public int? QuantityPerPCB { get; set; } = 0;
        public int? QuantityPerSPCB { get; set; } = 0;
        public int? GrossWeightPerPCB { get; set; } = 0;
        public int? LengthPerPCB { get; set; } = 0;
        public int? WidthPerPCB { get; set; } = 0;
        public int? HeightPerPCB { get; set; } = 0;
        public int? GrossWeightPerSPCB { get; set; } = 0;
        public int? LengthPerSPCB { get; set; } = 0;
        public int? WidthPerSPCB { get; set; } = 0;
        public int? HeightPerSPCB { get; set; } = 0;
        [MaxLength(25)] public string? ArticleCategory { get; set; }
        [MaxLength(25)] public string? ArticleRotationClass { get; set; }
        [MaxLength(25)] public string? ReceptionMethod { get; set; }
        [MaxLength(25)] public string? StorageMethod { get; set; }
        [MaxLength(25)] public string? PreferredStorageZone { get; set; }
        [MaxLength(25)] public string? PreferredStorageAisle { get; set; }
        [MaxLength(25)] public string? StorageClass { get; set; }
        [MaxLength(25)] public string? PreparationMethod { get; set; }
        [MaxLength(30)] public string? ArticlePackaging { get; set; }
        [MaxLength(50)] public string? SupplierArticleReference { get; set; }
        [MaxLength(100)] public string? SupplierArticleDescription { get; set; }
        [MaxLength(14)] public string? SupplierCode { get; set; }
        [MaxLength(20)] public string? SupplierArticleReference2 { get; set; }
        [MaxLength(20)] public string? SupplierArticleReference3 { get; set; }
        [MaxLength(20)] public string? SupplierArticleReference4 { get; set; }
        [MaxLength(20)] public string? SupplierArticleReference5 { get; set; }
        [MaxLength(8)] public string? BrandCode { get; set; }
        [MaxLength(1)] public string? ArticleAnalysisCode { get; set; } = "E";
        public int? ArticlePrice1 { get; set; }
        public int? ArticlePrice2 { get; set; }
        public int? ArticlePrice3 { get; set; }
        public int? ArticlePrice4 { get; set; }
        [MaxLength(10)] public string? ArticleFamily { get; set; }
        [MaxLength(20)] public string? ArticleSubFamily { get; set; }
        [MaxLength(20)] public string? ArticleBrand { get; set; }
        [MaxLength(50)] public string? ArticleSize { get; set; }
        [MaxLength(30)] public string? ArticleColor { get; set; }
        [MaxLength(20)] public string? ArticleTypology { get; set; }
        [MaxLength(100)] public string? ModelReference { get; set; }
        [MaxLength(100)] public string? ModelDescription { get; set; }
        public bool SaleExpirationDate { get; set; } = false;
        public int? ReceptionDeadlineInDays { get; set; }
        public int? ShippingDeadlineInDays { get; set; }
        public bool? SerializedArticle { get; set; }
        public bool? LotTrackedArticle { get; set; }
        public bool? MiniArticlesManaged { get; set; }
        public bool? QuantityDeclarationManaged { get; set; }
        public bool? FragileArticle { get; set; }
        public DateTime? CustomField1 { get; set; }
        public DateTime? CustomField2 { get; set; }
        [MaxLength(256)] public string? CustomField3 { get; set; }
        [MaxLength(256)] public string? CustomField4 { get; set; }
        [MaxLength(256)] public string? CustomField5 { get; set; }
        [MaxLength(256)] public string? CustomField6 { get; set; }
        [MaxLength(256)] public string? CustomField7 { get; set; }
        [MaxLength(256)] public string? CustomField8 { get; set; }
        [MaxLength(256)] public string? CustomField9 { get; set; }
        [MaxLength(256)] public string? CustomField10 { get; set; }
        [MaxLength(256)] public string? CustomField11 { get; set; }
        public int? CustomField12 { get; set; }
        public int? CustomField13 { get; set; }
        public int? CustomField14 { get; set; }
        public int? CustomField15 { get; set; }
        public int? CustomField16 { get; set; }
        public DateTime? CustomField17 { get; set; }
        public DateTime? CustomField18 { get; set; }
        public int? UVCQuantityPerCartonOrPalette { get; set; }
        public int? WeightPerCartonOrPalette { get; set; }
        public int? LengthPerCartonOrPalette { get; set; }
        public int? WidthPerCartonOrPalette { get; set; }
        public int? HeightPerCartonOrPalette { get; set; }
        [MaxLength(15)] public string? CustomsCode { get; set; }
        [MaxLength(15)] public string? CountryOfOriginCode { get; set; }
        public bool? TopHazardousMaterial { get; set; }
        public bool? TopAlcoholArticle { get; set; }
        public bool? TopConsignedArticle { get; set; }
        public List<Barcode>? Barcodes { get; set; }

        public string Id => !string.IsNullOrEmpty(ArticleReference) ? ArticleReference : Globals.NullString;
    }
}

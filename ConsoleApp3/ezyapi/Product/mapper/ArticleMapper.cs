using ConsoleApp3.ezyapi.Product.models;
using models;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ezyapi.Product.mapper
{

    public static class ArticleMapper
    {

        public static OdooDictionaryModel ToDbModel(Article article, ProductProductOdooModel? existingInstance = null)
        {
            return OdooDictionaryModel.Create(() => new ProductProductOdooModel()
            {
                Name = article.ArticleReference,
                Description = article.LongArticleDescription,
                LstPrice = article.ArticlePrice1
            });
/*
            var instance = existingInstance ?? new ProductProductOdooModel();
*//*
            if (article.Id != "NULL_STRING")
            {
                instance.Id = long.Parse(article.Id);
            }
*//*
      //      instance.DefaultCode = article.ArticleReference;
            
            instance.Name = article.ArticleReference;
            instance.Description = article.LongArticleDescription;
            instance.LstPrice = article.ArticlePrice1;*/
  
            /*
               instance.Fm1arti = article.ArticleFamily;
               instance.Fm2arti = article.ArticleSubFamily;
               instance.Marque1 = article.ArticleBrand;
               instance.Taille1 = article.ArticleSize;
               instance.Coloris = article.ArticleColor;
               instance.Typolog = article.ArticleTypology;
               instance.Refmodl = article.ModelReference;
               instance.Desmodl = article.ModelDescription;
               instance.Dlvarti = article.SaleExpirationDate;
               instance.Dlvrece = article.ReceptionDeadlineInDays;
               instance.Dlvexpe = article.ShippingDeadlineInDays;
               instance.Noserie = article.SerializedArticle;
               instance.Noslots = article.LotTrackedArticle;
               instance.Nominia = article.MiniArticlesManaged;
               instance.Decarti = article.QuantityDeclarationManaged;
               instance.Artifra = article.FragileArticle;
               instance.Specif1 = article.CustomField1;
               instance.Specif2 = article.CustomField2;
               instance.Specif3 = article.CustomField3;
               instance.Specif4 = article.CustomField4;
               instance.Specif5 = article.CustomField5;
               instance.Specif6 = article.CustomField6;
               instance.Specif7 = article.CustomField7;
               instance.Specif8 = article.CustomField8;
               instance.Specif9 = article.CustomField9;
               instance.Specif10 = article.CustomField10;
               instance.Specif11 = article.CustomField11;
               instance.Specif12 = article.CustomField12;
               instance.Specif13 = article.CustomField13;
               instance.Specif14 = article.CustomField14;
               instance.Specif15 = article.CustomField15;
               instance.Specif16 = article.CustomField16;
               instance.Specif17 = article.CustomField17;
               instance.Specif18 = article.CustomField18;
               instance.Coddoua = article.CustomsCode;
               instance.Codprov = article.CountryOfOriginCode;
               instance.RTopArticleDangereux = article.TopHazardousMaterial ?? false;
               instance.RTopArticleAlcool = article.TopAlcoholArticle ?? false;
               instance.RTopArticleConsigne = article.TopConsignedArticle ?? false;
            */

            /*
                // Champs non autorisés à la modification
                instance.SyncWms = true;
                instance.Pcbarti = existingInstance?.Pcbarti ?? article.QuantityPerPCB;
                instance.Spcarti = existingInstance?.Spcarti ?? article.QuantityPerSPCB;
                instance.Suparti = existingInstance?.Suparti ?? article.UVCQuantityPerCartonOrPalette;

                instance.Poidnet = existingInstance?.Poidnet ?? article.NetWeightPerUVC;
                instance.Poiduvc = existingInstance?.Poiduvc ?? article.GrossWeightPerUVC;
                instance.Longuvc = existingInstance?.Longuvc ?? article.LengthPerUVC;
                instance.Larguvc = existingInstance?.Larguvc ?? article.WidthPerUVC;
                instance.Hautuvc = existingInstance?.Hautuvc ?? article.HeightPerUVC;

                instance.Hautpcb = existingInstance?.Hautpcb ?? article.HeightPerPCB;
                instance.Largpcb = existingInstance?.Largpcb ?? article.WidthPerPCB;
                instance.Longpcb = existingInstance?.Longpcb ?? article.LengthPerPCB;
                instance.Poidpcb = existingInstance?.Poidpcb ?? article.GrossWeightPerPCB;

                instance.Poidspc = existingInstance?.Poidspc ?? article.GrossWeightPerSPCB;
                instance.Longspc = existingInstance?.Longspc ?? article.LengthPerSPCB;
                instance.Largspc = existingInstance?.Largspc ?? article.WidthPerSPCB;
                instance.Hautspc = existingInstance?.Hautspc ?? article.HeightPerSPCB;

                instance.Poidsup = existingInstance?.Poidsup ?? article.WeightPerCartonOrPalette;
                instance.Longsup = existingInstance?.Longsup ?? article.LengthPerCartonOrPalette;
                instance.Largsup = existingInstance?.Largsup ?? article.WidthPerCartonOrPalette;
                instance.Hautsup = existingInstance?.Hautsup ?? article.HeightPerCartonOrPalette;
            */
        }

        public static Article ToApiModel(ProductProductOdooModel article)
        {
            return new Article
            {

                //Id = string.Parse(article.Id);
                ArticleReference = article.DefaultCode,
                LongArticleDescription = article.Description,
                ArticlePrice1 = (int?)article.LstPrice

                /*
                ActivityCode = article.Codacti,
                DateCreated = article.DateCreation,
                DateLastUpdated = article.DateLastUpdate,
                ActivityName = article.Libacti,
                ArticleReference = article.Codarti,
                LongArticleDescription = article.Ds1arti,
                ShortArticleDescription = article.Ds2arti,
                DOReferenceCode = article.Refclie,
                NomenclatureManaged = article.Nomencl,
                ArticleType = article.TypeArti,
                NetWeightPerUVC = article.Poidnet,
                GrossWeightPerUVC = article.Poiduvc,
                LengthPerUVC = article.Longuvc,
                WidthPerUVC = article.Larguvc,
                HeightPerUVC = article.Hautuvc,
                QuantityPerPCB = article.Pcbarti,
                QuantityPerSPCB = article.Spcarti,
                GrossWeightPerPCB = article.Poidpcb,
                LengthPerPCB = article.Longpcb,
                WidthPerPCB = article.Largpcb,
                HeightPerPCB = article.Hautpcb,
                GrossWeightPerSPCB = article.Poidspc,
                LengthPerSPCB = article.Longspc,
                WidthPerSPCB = article.Largspc,
                HeightPerSPCB = article.Hautspc,
                ArticleCategory = article.Catarti,
                ArticleRotationClass = article.Abcarti,
                ReceptionMethod = article.Mdrarti,
                StorageMethod = article.Mdsarti,
                PreferredStorageZone = article.Zonpref,
                PreferredStorageAisle = article.Allpref,
                StorageClass = article.Clastoc,
                PreparationMethod = article.Mdparti,
                ArticlePackaging = article.Embarti,
                SupplierArticleReference = article.Reffour,
                SupplierArticleDescription = article.Desfour,
                SupplierCode = article.Codfour,
                SupplierArticleReference2 = article.Refour2,
                SupplierArticleReference3 = article.Refour3,
                SupplierArticleReference4 = article.Refour4,
                SupplierArticleReference5 = article.Refour5,
                BrandCode = article.Codmarq,
                ArticleAnalysisCode = article.Canarti,
                ArticlePrice1 = article.Px1arti,
                ArticlePrice2 = article.Px2arti,
                ArticlePrice3 = article.Px3arti,
                ArticlePrice4 = article.Px4arti,
                ArticleFamily = article.Fm1arti,
                ArticleSubFamily = article.Fm2arti,
                ArticleBrand = article.Marque1,
                ArticleSize = article.Taille1,
                ArticleColor = article.Coloris,
                ArticleTypology = article.Typolog,
                ModelReference = article.Refmodl,
                ModelDescription = article.Desmodl,
                SaleExpirationDate = article.Dlvarti,
                ReceptionDeadlineInDays = article.Dlvrece,
                ShippingDeadlineInDays = article.Dlvexpe,
                SerializedArticle = article.Noserie,
                LotTrackedArticle = article.Noslots,
                MiniArticlesManaged = article.Nominia,
                QuantityDeclarationManaged = article.Decarti,
                FragileArticle = article.Artifra,
                CustomField1 = article.Specif1,
                CustomField2 = article.Specif2,
                CustomField3 = article.Specif3,
                CustomField4 = article.Specif4,
                CustomField5 = article.Specif5,
                CustomField6 = article.Specif6,
                CustomField7 = article.Specif7,
                CustomField8 = article.Specif8,
                CustomField9 = article.Specif9,
                CustomField10 = article.Specif10,
                CustomField11 = article.Specif11,
                CustomField12 = article.Specif12,
                CustomField13 = article.Specif13,
                CustomField14 = article.Specif14,
                CustomField15 = article.Specif15,
                CustomField16 = article.Specif16,
                CustomField17 = article.Specif17,
                CustomField18 = article.Specif18,
                UVCQuantityPerCartonOrPalette = article.Suparti,
                WeightPerCartonOrPalette = article.Poidsup,
                LengthPerCartonOrPalette = article.Longsup,
                WidthPerCartonOrPalette = article.Largsup,
                HeightPerCartonOrPalette = article.Hautsup,
                CustomsCode = article.Coddoua,
                CountryOfOriginCode = article.Codprov,
                TopHazardousMaterial = article.RTopArticleDangereux ?? false,
                TopAlcoholArticle = article.RTopArticleAlcool ?? false,
                TopConsignedArticle = article.RTopArticleConsigne ?? false,
                Barcodes = barcodes?.Select(BarcodeMapper.ToApiModel).ToList(),
                // ArticleHazardouz = articleHazardouz != null ? new HazardousArticleMapper().ToApiModel(articleHazardouz) : null, 
                */
            };
        }
    }
}
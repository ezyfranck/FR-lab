using ConsoleApp3.ezyapi.Procurements.Models;
using ConsoleApp3.ezyapi.Connection.Database.Models;
//using global:: ConsoleApp3.ezyapi.Procurements.Models;

namespace ConsoleApp3.ezyapi.Procurements.mapper
{
    public static class ProcurementEntryMapper
    {
        public static ProcurementEntry ToApiModel(AnaproLigne anaproLigne)
        {
            return new ProcurementEntry
            {
                Id = anaproLigne.Id,
                DateCreation = anaproLigne.DateCreation,
                DateLastUpdate = anaproLigne.DateLastUpdate,
                LineID = anaproLigne.Idligne,
                ArticleReference = anaproLigne.Codarti,
                ExpectedQuantity = anaproLigne.Qtteatt,
                SupplierOrderNumberDO = anaproLigne.Comfour,
                ReceptionUnitOfMeasure = anaproLigne.Unitrec,
                ArticlePriceAtReception = anaproLigne.Prixrec,
                ExpectedLotNumber = anaproLigne.Artilot,
                AnnouncedArticleDate = anaproLigne.Dateart,
                ArticleShippingDeadline = anaproLigne.Dfvarti,
                ArticlePCB = anaproLigne.Pcbarti,
                ArticleSPCB = anaproLigne.Spcarti,
                LineMessage = anaproLigne.Mesglig,
                CustomField1 = anaproLigne.Specif1,
                CustomField2 = anaproLigne.Specif2,
                CustomField3 = anaproLigne.Specif3,
                CustomField4 = anaproLigne.Specif4,
                CustomField5 = anaproLigne.Specif5,
                CustomField6 = anaproLigne.Specif6,
                CustomField7 = anaproLigne.Specif7,
                CustomField8 = anaproLigne.Specif8,
                DateProcessed = anaproLigne.DateProcessed
            };
        }

        public static AnaproLigne ToDbModel(ProcurementEntry procurementEntry, Procurement parent, string? runId)
        {
            return new AnaproLigne
            {
                Codacti = parent.ActivityCode,
                DateCreation = DateTime.UtcNow,
                DateLastUpdate = DateTime.UtcNow,
                Idrecep = parent.UniqueProcurementID!,
                Idligne = procurementEntry.LineID!,

                Codarti = procurementEntry.ArticleReference,
                Qtteatt = procurementEntry.ExpectedQuantity,
                Comfour = procurementEntry.SupplierOrderNumberDO,
                Unitrec = procurementEntry.ReceptionUnitOfMeasure,
                Prixrec = procurementEntry.ArticlePriceAtReception,
                Artilot = procurementEntry.ExpectedLotNumber,
                Dateart = procurementEntry.AnnouncedArticleDate,
                Dfvarti = procurementEntry.ArticleShippingDeadline,
                Pcbarti = procurementEntry.ArticlePCB,
                Spcarti = procurementEntry.ArticleSPCB,
                Mesglig = procurementEntry.LineMessage,
                Specif1 = procurementEntry.CustomField1,
                Specif2 = procurementEntry.CustomField2,
                Specif3 = procurementEntry.CustomField3,
                Specif4 = procurementEntry.CustomField4,
                Specif5 = procurementEntry.CustomField5,
                Specif6 = procurementEntry.CustomField6,
                Specif7 = procurementEntry.CustomField7,
                Specif8 = procurementEntry.CustomField8,
                Nomflux = runId,
            };
        }
    }
}

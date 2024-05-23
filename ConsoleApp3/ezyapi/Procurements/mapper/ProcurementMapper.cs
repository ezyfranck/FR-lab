using ConsoleApp3.ezyapi.Connection.Database.Models;
using ConsoleApp3.ezyapi.Procurements.Models;

namespace ConsoleApp3.ezyapi.Procurements.mapper
{
    public static class ProcurementMapper
    {
        public static Procurement ToApiModel(Anapro anapro)
        {
            return new Procurement
            {
                ActivityCode = anapro.Codacti,
                ActivityName = anapro.Libacti,
                DateCreation = anapro.DateCreation,
                DateLastUpdate = anapro.DateLastUpdate,
                UniqueProcurementID = anapro.Idrecep,
                SupplierOrderNumberDO = anapro.Numrcli,
                OwnerCode = anapro.Codprop,
                ProcurementTypeCode = anapro.Typappr,
                ProcurementGroup = anapro.Idgroup,
                ProcurementGroupDescription = anapro.Dsgroup,
                SupplierCode = anapro.Codfour,
                SupplierName = anapro.Fournom,
                ExpectedReceiptDate = anapro.Daterec,
                CustomField1 = anapro.Specif1,
                CustomField2 = anapro.Specif2,
                CustomField3 = anapro.Specif3,
                CustomField4 = anapro.Specif4,
                CustomField5 = anapro.Specif5,
                CustomField6 = anapro.Specif6,
                CustomField7 = anapro.Specif7,
                CustomField8 = anapro.Specif8,
                ProcurementEntries = anapro.Lignes
                    .Select(ProcurementEntryMapper.ToApiModel).ToList()
            };
        }

        public static Anapro ToDbModel(Procurement procurement, string? runId)
        {
            return new Anapro
            {
                Codacti = procurement.ActivityCode,
                Libacti = procurement.ActivityName,
                DateCreation = DateTime.UtcNow,
                DateLastUpdate = DateTime.UtcNow,
                Idrecep = procurement.UniqueProcurementID!,
                Typtrai = 1,
                Numrcli = procurement.SupplierOrderNumberDO,
                Codprop = procurement.OwnerCode,
                Typappr = procurement.ProcurementTypeCode,
                Idgroup = procurement.ProcurementGroup,
                Dsgroup = procurement.ProcurementGroupDescription,
                Codfour = procurement.SupplierCode,
                Fournom = procurement.SupplierName,
                Daterec = procurement.ExpectedReceiptDate,
                Specif1 = procurement.CustomField1,
                Specif2 = procurement.CustomField2,
                Specif3 = procurement.CustomField3,
                Specif4 = procurement.CustomField4,
                Specif5 = procurement.CustomField5,
                Specif6 = procurement.CustomField6,
                Specif7 = procurement.CustomField7,
                Specif8 = procurement.CustomField8,
                Logexclusionflux = false,

                Lignes = procurement.ProcurementEntries
                    .Select(x => ProcurementEntryMapper.ToDbModel(x, procurement, runId)).ToList(),
            };
        }
    }
}

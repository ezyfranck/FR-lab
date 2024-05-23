
namespace ConsoleApp3.ezyapi.Connection.Database.Models
{

    public class Anapro
    {
        public long Id { get; set; }

        public string? Codacti { get; set; }

        public string? Libacti { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DateLastUpdate { get; set; }

        public string Idrecep { get; set; } = null!;

        public int? Typtrai { get; set; }

        public string? Numrcli { get; set; }

        public string? Codprop { get; set; }

        public string? Typappr { get; set; }

        public string? Idgroup { get; set; }

        public string? Dsgroup { get; set; }

        public string? Codfour { get; set; }

        public string? Fournom { get; set; }

        public DateTime? Daterec { get; set; }

        public string? Specif1 { get; set; }

        public string? Specif2 { get; set; }

        public string? Specif3 { get; set; }

        public string? Specif4 { get; set; }

        public string? Specif5 { get; set; }

        public string? Specif6 { get; set; }

        public string? Specif7 { get; set; }

        public string? Specif8 { get; set; }

        public bool? Logexclusionflux { get; set; }

        public ICollection<AnaproLigne> Lignes { get; set; } = new List<AnaproLigne>();
    }
}

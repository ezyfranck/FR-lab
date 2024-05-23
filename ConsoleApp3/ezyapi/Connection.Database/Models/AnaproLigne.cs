using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ezyapi.Connection.Database.Models
{
    public class AnaproLigne
    {
        public long Id { get; set; }

        public string? Codacti { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DateLastUpdate { get; set; }

        public string Idrecep { get; set; } = null!;

        public string Idligne { get; set; } = null!;

        public string? Codarti { get; set; }

        public int? Qtteatt { get; set; }

        public string? Comfour { get; set; }

        public string? Unitrec { get; set; }

        public int? Prixrec { get; set; }

        public string? Artilot { get; set; }

        public DateTime? Dateart { get; set; }

        public DateTime? Dfvarti { get; set; }

        public int? Pcbarti { get; set; }

        public int? Spcarti { get; set; }

        public string? Mesglig { get; set; }

        public string? Specif1 { get; set; }

        public string? Specif2 { get; set; }

        public string? Specif3 { get; set; }

        public string? Specif4 { get; set; }

        public string? Specif5 { get; set; }

        public string? Specif6 { get; set; }

        public string? Specif7 { get; set; }

        public string? Specif8 { get; set; }

        public DateTime? DateProcessed { get; set; }

        public string? Nomflux { get; set; }

        public string? NomfluxOut { get; set; }
    }
}

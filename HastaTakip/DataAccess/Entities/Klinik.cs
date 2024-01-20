#nullable disable

using DataAccess.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Klinik : Record
    {

        // 1. Yöntem
        // public string Adi { get; set; } = null!;

        // 2. Yöntem
        [Required] // Attribute, Data Annotations
        [StringLength(200)]
        public string Adi { get; set; }
        public string Aciklamasi { get; set; }
        public List<Doktor> Doktorlar { get; set; }
    }
}
